// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FunctionCall : TeaModel {
        /// <summary>
        /// <para>The parameters detected by the large language model.</para>
        /// </summary>
        [NameInMap("Arguments")]
        [Validation(Required=false)]
        public string Arguments { get; set; }

        /// <summary>
        /// <para>The function name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>search_file</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
