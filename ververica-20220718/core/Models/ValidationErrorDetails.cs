// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ValidationErrorDetails : TeaModel {
        /// <summary>
        /// <para>The number of the column at which the error starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("columnNumber")]
        [Validation(Required=false)]
        public string ColumnNumber { get; set; }

        /// <summary>
        /// <para>The number of the column at which the error ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("endColumnNumber")]
        [Validation(Required=false)]
        public string EndColumnNumber { get; set; }

        /// <summary>
        /// <para>The number of the row at which the error ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("endLineNumber")]
        [Validation(Required=false)]
        public string EndLineNumber { get; set; }

        /// <summary>
        /// <para>The number the row at which the error starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("lineNumber")]
        [Validation(Required=false)]
        public string LineNumber { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
