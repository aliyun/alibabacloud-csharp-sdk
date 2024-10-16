// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetModelFeatureFGInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;features&quot;: [{&quot;feature_name&quot;: &quot;item_id&quot;,&quot;feature_type&quot;: &quot;id_feature&quot;,&quot;value_type&quot;: &quot;String&quot;,&quot;expression&quot;: &quot;item:item_id&quot;,&quot;default_value&quot;: &quot;-1024&quot;,&quot;combiner&quot;: &quot;mean&quot;,&quot;need_prefix&quot;: false},{&quot;feature_name&quot;: &quot;f1&quot;,&quot;feature_type&quot;: &quot;lookup_feature&quot;,&quot;value_type&quot;: &quot;Integer&quot;,&quot;map&quot;: &quot;item:f1&quot;,&quot;key&quot;: &quot;user:1&quot;,&quot;default_value&quot;: &quot;0&quot;,&quot;combiner&quot;: &quot;mean&quot;,&quot;need_prefix&quot;: false,&quot;needDiscrete&quot;: false,&quot;needWeighting&quot;: false,&quot;needKey&quot;: false}],&quot;reserves&quot;: [&quot;f1&quot;]}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6B662A64-E4BF-56F8-BF5F-4C63F34EC0A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
