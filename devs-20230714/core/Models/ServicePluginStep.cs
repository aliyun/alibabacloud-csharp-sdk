// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ServicePluginStep : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("args")]
        [Validation(Required=false)]
        public Dictionary<string, object> Args { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingding-robot</para>
        /// </summary>
        [NameInMap("plugin")]
        [Validation(Required=false)]
        public string Plugin { get; set; }

    }

}
