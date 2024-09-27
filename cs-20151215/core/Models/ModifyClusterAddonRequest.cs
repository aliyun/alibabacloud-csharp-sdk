// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterAddonRequest : TeaModel {
        /// <summary>
        /// <para>The custom parameter settings that you want to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CpuRequest&quot;:&quot;800m&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

    }

}
