// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ToolCall : TeaModel {
        /// <summary>
        /// <para>The definition of the function that can be called by the AI assistant.</para>
        /// </summary>
        [NameInMap("Function")]
        [Validation(Required=false)]
        public FunctionCall Function { get; set; }

        /// <summary>
        /// <para>The type of the tool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>function</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
