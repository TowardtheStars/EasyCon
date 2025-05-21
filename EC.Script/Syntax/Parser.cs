namespace EC.Script.Syntax;

internal sealed class Parser
{
    private readonly DiagnosticBag _diagnostics = [];
    private readonly SyntaxTree _syntaxTree;

    public Parser(SyntaxTree syntaxTree)
    {
        var lexer = new Lexer(syntaxTree);
        lexer.Lex().ToArray();
        _syntaxTree = syntaxTree;
    }

    public DiagnosticBag Diagnostics => _diagnostics;

    private SyntaxToken NextToken()
    {
        throw new NotImplementedException();
    }

    private SyntaxToken MatchToken(TokenType kind)
    {
        throw new NotImplementedException();
    }

    public MainUnitSyntax ParseMainUnit()
    {
        var statements = new List<StatementSyntax>();
        throw new NotImplementedException();
    }

    private StatementSyntax ParseImportDeclaration()
    {
        var importKeyword = MatchToken(TokenType.ImportKeyword);
        //var pathLiteral = ParseStringLiteral();
        throw new NotImplementedException();
    }

    private FunctionDeclarationSyntax ParseFunctionDeclaration()
    {
        var functionKeyword = MatchToken(TokenType.FunctionKeyword);
        var name = MatchToken(TokenType.IdentifierToken);
        //var parameters = ParseParameterList();
        var body = new List<StatementSyntax>();
        ExpressionSyntax returnValue = null;

        throw new NotImplementedException();
    }


    private StatementSyntax ParseStatement()
    {
        //return Current.Kind switch {
        //    TokenType.IfKeyword => ParseIfStatement(),
        //    TokenType.ForKeyword => ParseForStatement(),
        //    TokenType.BreakKeyword => ParseBreakStatement(),
        //    TokenType.ContinueKeyword => ParseContinueStatement(),
        //    TokenType.ReturnKeyword => ParseReturnStatement(),
        //    TokenType.IdentifierToken when IsKeyActionToken() => ParseKeyAction(),
        //    _ => ParseAssignmentOrExpressionStatement()
        //};
        throw new NotImplementedException();
    }

    private StatementSyntax ParseKeyAction()
    {
        throw new NotImplementedException();
    }

    private StatementSyntax ParseButtonKeyAction()
    {
        var buttons = new List<SyntaxToken>();
        var duration = 50; // 默认50ms

        throw new NotImplementedException();
    }

    private StatementSyntax ParseStickKeyAction()
    {
        throw new NotImplementedException();
    }

    private IfStatementSyntax ParseIfStatement()
    {
        var ifKeyword = MatchToken(TokenType.IfKeyword);
        var condition = ParseExpression();
        var thenStatements = new List<StatementSyntax>();

        throw new NotImplementedException();
    }

    private ForStatementSyntax ParseForStatement()
    {
        var forKeyword = MatchToken(TokenType.ForKeyword);
        throw new NotImplementedException();
    }

    private AssignmentStatement ParseAssignmentStatement()
    {
        var target = ParseExpression();
        throw new NotImplementedException();
    }

    private ExpressionSyntax ParseExpression()
    {
        return ParseBinaryExpression();
    }

    private ExpressionSyntax ParseBinaryExpression(int parentPrecedence = 0)
    {
        //ExpressionSyntax left;
        //var unaryPrecedence = Current.Kind.GetUnaryOperatorPrecedence();

        //if (unaryPrecedence != 0 && unaryPrecedence >= parentPrecedence)
        //{
        //    var operatorToken = NextToken();
        //    var operand = ParseBinaryExpression(unaryPrecedence);
        //    left = new UnaryExpressionSyntax(_syntaxTree, operatorToken, operand);
        //}
        //else
        //{
        //    left = ParsePrimaryExpression();
        //}

        //while (true)
        //{
        //    var precedence = Current.Kind.GetBinaryOperatorPrecedence();
        //    if (precedence == 0 || precedence <= parentPrecedence)
        //        break;

        //    var operatorToken = NextToken();
        //    var right = ParseBinaryExpression(precedence);
        //    left = new BinaryExpressionSyntax(_syntaxTree, left, operatorToken, right);
        //}

        //return left;
        throw new NotImplementedException();
    }

    private ExpressionSyntax ParsePrimaryExpression()
    {
        //switch (Current.Kind)
        //{
        //    case TokenType.IdentifierToken when Current.Text.StartsWith("@"):
        //        return ParseImageSearchVariable();
        //    case TokenType.NumberToken:
        //        return ParseNumberLiteral();
        //    case TokenType.StringToken:
        //        return ParseStringLiteral();
        //    case TokenType.IdentifierToken when Peek(1).Kind == TokenType.LeftPHToken:
        //        return ParseCallExpression();
        //    case TokenType.IdentifierToken when Current.Text.StartsWith("$") || Current.Text.StartsWith("_"):
        //        return ParseVariable();
        //    case TokenType.LeftPHToken:
        //        return ParseParenthesizedExpression();
        //    case TokenType.LeftBKToken:
        //        return ParseIndexExpression();
        //    default:
        //        // 错误处理
        //        _diagnostics.ReportUnexpectedToken(Current.Span, Current.Kind);
        //        return new BadExpressionSyntax(_syntaxTree);
        //}
        throw new NotImplementedException();
    }

    private ExpressionSyntax ParseVariable()
    {
        throw new NotImplementedException();
    }

    private CallExpressionSyntax ParseCallExpression()
    {
        var identifier = MatchToken(TokenType.IdentifierToken);
        var leftParen = MatchToken(TokenType.LeftPHToken);
        var arguments = new List<ExpressionSyntax>();

        throw new NotImplementedException();
    }

    private ParenthesizedExpressionSyntax ParseParenthesizedExpression()
    {
        var left = MatchToken(TokenType.LeftPHToken);
        var expression = ParseExpression();
        var right = MatchToken(TokenType.RightPHToken);
        return new ParenthesizedExpressionSyntax(_syntaxTree, left, expression, right);
    }

    private ExpressionSyntax ParseImageSearchVariable()
    {
        var identifier = MatchToken(TokenType.IdentifierToken);
        // 验证变量格式（必须以@开头）
        if (!identifier.Text.StartsWith("@"))
        {
            _diagnostics.ReportInvalidNumber(identifier.Span, identifier.Text);
        }
        throw new NotImplementedException();
    }
}
