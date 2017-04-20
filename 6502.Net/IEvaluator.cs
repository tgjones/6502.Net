﻿//-----------------------------------------------------------------------------
// Copyright (c) 2017 Nate Burnett <informedcitizenry@gmail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to 
// deal in the Software without restriction, including without limitation the 
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

using System;

namespace Asm6502.Net
{
    /// <summary>
    /// Defines an interface for an expression evaluator that can evaluate mathematical 
    /// expressions from strings.
    /// </summary>
    public interface IEvaluator
    {
        /// </summary>
        /// <param name="expression">The string representation of the mathematical expression.</param>
        /// <returns>The result of the expression evaluation.</returns>
        /// <exception cref="ExpressionEvaluator.ExpressionException">ExpressionEvaluator.ExpressionException</exception>
        long Eval(string expression);

        /// </summary>
        /// <param name="condition">The string representation of the conditional expression.</param>
        /// <returns>Returns true, if the expression is true, false otherwise.</returns>
        /// <exception cref="ExpressionEvaluator.ExpressionException">ExpressionEvaluator.ExpressionException</exception>
        bool EvalCondition(string expression);

        /// <summary>
        /// Determines whether the expression can be evaluated from the current
        /// symbol lookup state of the calling client.
        /// </summary>
        /// <param name="expression">The expression to test whether it can be evaluated.</param>
        /// <returns>True, if the expression can be evaluated, otherwise false.</returns>
        bool CanEvaluate(string expression);

        /// <summary>
        /// Gets or sets the char-encoding transform, e.g. ASCII to Commodore PETSCII.
        /// </summary>
        Func<byte, byte> CharEncoding { get; set; }
    }
}