Using ChessExample;

public class CheckerBoardPositionTests
{
    [Fact] // проверяем на обработку null
    public void ParsingNullPosition()
    {
        var good = CheckerBoardPosition.TryParse(null, null, out var result);

        Assert.False(good);
        Assert.Null(result);
    }
    
    [Fact] // проверяем на валидность координат
    public void ValidsKoordinats() 
    {
     
        byte x = 1; 
        byte y = 3; 
        
        var result = new CheckerBoardPosition(x, y); 
        
        Assert.Equal(x, result.X); 
        Assert.Equal(y, result.Y); 
    }
    
    [Fact] //проверяем конвертацию координат в шахматную запись
    public void InvalidToString() 
    {
        var checkerBoardPosition = new CheckerBoardPosition(3, 6); 
        
        string resultString = checkerBoardPosition.ToString(); 
        
        Assert.Equal("C6", resultString); 
    }
    
    [Fact] //обратноя проверка как шахматная запись конвертируется в координаты
    public void ParsingPosition() 
    {
        string inputPosition = "B2"; 
        
        var resultPosition = CheckerBoardPosition.Parse(inputPosition, null); 
        
        Assert.Equal(2, resultPosition.X); 
        Assert.Equal(2, resultPosition.Y); 
    }
    
    [Theory] //ну, невалидные параметры проверяем
    [InlineData(0, 1)] 
    [InlineData(10, 1)] 
    [InlineData(4, 0)] 
    [InlineData(4, 15)] 
    [InlineData(10, 15)] 
    [InlineData(0, 0)] 
    public void ErrorParameter(byte x, byte y) 
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new CheckerBoardPosition(x, y)); 
    }
    
    
}