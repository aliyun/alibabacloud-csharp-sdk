// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterAddonRequest : Darabonba.Model {
        /// <summary>
        /// <para>The custom parameter settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CpuRequest&quot;:&quot;800m&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

    }

}

