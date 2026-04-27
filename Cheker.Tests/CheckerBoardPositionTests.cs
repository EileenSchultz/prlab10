Using ChessExample;

public class CheckerBoardPositionTests
{
    [Fact]
    public void ParsingNullPosition()
    {
        var good = CheckerBoardPosition.TryParse(null, null, out var result);

        Assert.False(good);
        Assert.Null(result);
    }
    
    [Fact] 
    public void ValidsKoordinats() 
    {
     
        byte x = 1; 
        byte y = 3; 
        
        var result = new CheckerBoardPosition(x, y); 
        
        Assert.Equal(x, result.X); 
        Assert.Equal(y, result.Y); 
    }
    
    [Fact] 
    public void InvalidToString() 
    {
        var checkerBoardPosition = new CheckerBoardPosition(3, 6); 
        
        string resultString = checkerBoardPosition.ToString(); 
        
        Assert.Equal("C6", resultString); 
    }
    
    [Fact] 
    public void ParsingPosition() 
    {
        string inputPosition = "B2"; 
        
        var resultPosition = CheckerBoardPosition.Parse(inputPosition, null); 
        
        Assert.Equal(2, resultPosition.X); 
        Assert.Equal(2, resultPosition.Y); 
    }
    
    
    //добавтьб Theory на разные параметры
    
    
}