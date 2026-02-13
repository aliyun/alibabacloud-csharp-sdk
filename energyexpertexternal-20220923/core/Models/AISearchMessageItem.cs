// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AISearchMessageItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;user：How to test my network speed?\naisearch：To check your network speed, you can use...&quot;</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

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
        [NameInMap("params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>miniapp</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
