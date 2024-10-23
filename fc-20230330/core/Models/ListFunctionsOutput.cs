// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListFunctionsOutput : TeaModel {
        [NameInMap("functions")]
        [Validation(Required=false)]
        public List<Function> Functions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>next_function_name</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
