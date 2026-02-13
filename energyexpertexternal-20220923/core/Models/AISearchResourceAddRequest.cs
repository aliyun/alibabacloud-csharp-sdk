// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AISearchResourceAddRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///  &quot;miniapp_id&quot;: &quot;test_miniapp&quot;,
        ///       &quot;title&quot;: &quot;testApp&quot;,
        ///       &quot;version&quot;: &quot;1.0.5&quot;,
        ///       &quot;description&quot;: &quot;description-mock&quot;,
        ///       &quot;slogan&quot;: &quot;slogan-mock&quot;,
        ///       &quot;icon&quot;: &quot;<a href="https://img.alicdn.com/test_icon.png">https://img.alicdn.com/test_icon.png</a>&quot;,
        ///       &quot;detail_desc&quot;: &quot;detail-mock&quot;
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>miniapp</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
