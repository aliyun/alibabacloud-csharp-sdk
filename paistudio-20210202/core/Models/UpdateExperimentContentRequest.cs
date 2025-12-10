// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class UpdateExperimentContentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;metadata&quot;: {       &quot;name&quot;: &quot;实验名称&quot;,       &quot;id&quot;: &quot;pai_exp_xxxdfafafasfa&quot;,       &quot;desc&quot;: &quot;实验描述&quot;,     },     &quot;nodes&quot;: [     ],     &quot;edges&quot;: [     ],     &quot;globalParams&quot;: [     ],     &quot;globalSettings&quot;:[     ]  }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

    }

}
