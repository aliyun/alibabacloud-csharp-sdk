// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RunClusterCheckRequest : TeaModel {
        /// <summary>
        /// <para>The check options.</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>The check target. If the type parameter is set to NodePoolUpgrade, this parameter must be set to the node pool ID. For other check types, this parameter is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np1f6779297c4444a3a1cdd29be8******</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The check type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NodePoolUpgrade</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
