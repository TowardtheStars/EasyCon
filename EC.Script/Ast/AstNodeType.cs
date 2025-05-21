namespace EC.Script.Ast;

internal enum AstNodeType
{
    // Statements
    NopStatement,
    ImportDeclaration, // reserve
    ConstDeclaration, // _const = 1
    VariableDeclaration, // $var = 42
    IfStatement, // if...elif...else...endif
    ForStatement, // for...next
    FunctionStatement, // func...endfunc
    ExpressionStatement, // $foo = 1+2
    BlockStatement,
    KeyActionStatement,

    // Expressions
    ErrorExpression,
    LiteralExpression, // 3.14, "str_test"
    VariableExpression, // _常量, $变量, @扩展变量（搜图等）
    AssignmentExpression, // _pi = 3
    CompoundAssignmentExpression, // $i += 1
    UnaryExpression,
    BinaryExpression,
    CallExpression,
    ConversionExpression,
}
