// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ModifyComponentAssetRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the asset. The value is a JSON object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;name&quot;: &quot;test asset&quot;,
        ///     &quot;componentName&quot;: &quot;SLS&quot;,
        ///     &quot;params&quot;: [
        ///         {
        ///             &quot;name&quot;: &quot;end_point&quot;,
        ///             &quot;value&quot;: &quot;xxx&quot;
        ///         },
        ///         {
        ///             &quot;name&quot;: &quot;sub_id&quot;,
        ///             &quot;value&quot;: &quot;xxxx&quot;
        ///         },
        ///         {
        ///             &quot;name&quot;: &quot;access_key&quot;,
        ///             &quot;value&quot;: &quot;xxxx&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("AssetConfig")]
        [Validation(Required=false)]
        public string AssetConfig { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
