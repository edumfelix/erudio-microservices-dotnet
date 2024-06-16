using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNum}/{secondNum}")]
    public IActionResult Sum(string firstNum, string secondNum)
    {
        return PerformOperation(firstNum, secondNum, (firstNum, secondNum) => (firstNum + secondNum));
    }

    [HttpGet("sub/{firstNum}/{secondNum}")]
    public IActionResult Subtract(string firstNum, string secondNum)
    {
        return PerformOperation(firstNum, secondNum, (firstNum, secondNum) => (firstNum - secondNum));
    }
    
    [HttpGet("div/{firstNum}/{secondNum}")]
    public IActionResult Divide(string firstNum, string secondNum)
    {
        return PerformOperation(firstNum, secondNum, (firstNum, secondNum) => (firstNum / secondNum));
    }
    
    [HttpGet("mult/{firstNum}/{secondNum}")]
    public IActionResult Multiply(string firstNum, string secondNum)
    {
        return PerformOperation(firstNum, secondNum, (firstNum, secondNum) => (firstNum * secondNum));
    }

    [HttpGet("sqrt/{number}")]
    public IActionResult SquareRoot(string number)
    {
        if (IsNumeric(number))
        {
            var result = Math.Sqrt((double)ConvertToDecimal(number));
            return Ok(result.ToString());
        }
        return BadRequest("Invalid Input");
    }

    private decimal ConvertToDecimal(string strNumber)
    {
        decimal number;
        if (decimal.TryParse(strNumber, out number))
        {
            return number;
        }
        return 0;
    }

    private bool IsNumeric(string strNumber)
    {
        double number;

        bool isNumber = double.TryParse(
            strNumber, 
            System.Globalization.NumberStyles.Any, 
            System.Globalization.NumberFormatInfo.InvariantInfo,
            out number);

        return isNumber;
    }

    private IActionResult PerformOperation(string firstNum, string secondNum, Func<decimal, decimal, decimal> operation)
    {
        if (IsNumeric(firstNum) && IsNumeric(secondNum))
        {
            var number1 = ConvertToDecimal(firstNum);
            var number2 = ConvertToDecimal(secondNum);
            var result = operation(number1, number2);
            return Ok(result.ToString());
        }
        return BadRequest("Invalid Input");
    }
}
    