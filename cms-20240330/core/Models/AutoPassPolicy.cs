// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AutoPassPolicy : TeaModel {
        /// <summary>
        /// <para>The selected command prefix. The array must contain exactly one prefix. You must specify either this parameter or fullCommand.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;starops sls&quot;]</para>
        /// </summary>
        [NameInMap("commandPrefix")]
        [Validation(Required=false)]
        public List<string> CommandPrefix { get; set; }

        /// <summary>
        /// <para>The full command for exact matching. The command must not be empty. You must specify either this parameter or commandPrefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>starops tool list</para>
        /// </summary>
        [NameInMap("fullCommand")]
        [Validation(Required=false)]
        public string FullCommand { get; set; }

        /// <summary>
        /// <para>The version required for a valid rule. The current version is v1.0.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
