// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class VerifyPythonFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F72685FB-A6E6-5A9A-97F7-6DC1056E63CE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The verification result. If the parameter is left empty, the syntax of the code snippet is correct.</para>
        /// </summary>
        [NameInMap("Syntax")]
        [Validation(Required=false)]
        public List<VerifyPythonFileResponseBodySyntax> Syntax { get; set; }
        public class VerifyPythonFileResponseBodySyntax : TeaModel {
            /// <summary>
            /// <para>The number that indicates the end column of the error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("EndColumn")]
            [Validation(Required=false)]
            public int? EndColumn { get; set; }

            /// <summary>
            /// <para>The number that indicates the end line of the error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("EndLineNumber")]
            [Validation(Required=false)]
            public int? EndLineNumber { get; set; }

            /// <summary>
            /// <para>The error message for the error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>undefined name \&quot;ab\&quot;</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The severity level of the error code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>4: moderate</description></item>
            /// <item><description>8: serious</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public int? Severity { get; set; }

            /// <summary>
            /// <para>The number that indicates the start column of the error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StartColumn")]
            [Validation(Required=false)]
            public int? StartColumn { get; set; }

            /// <summary>
            /// <para>The number that indicates the start line of the error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StartLineNumber")]
            [Validation(Required=false)]
            public int? StartLineNumber { get; set; }

        }

    }

}
