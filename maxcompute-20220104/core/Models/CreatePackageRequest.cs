// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreatePackageRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;name&quot;: &quot;test_packege&quot;, 
        ///     &quot;resourceList&quot;: { 
        ///         &quot;table&quot;: [
        ///             {
        ///                 &quot;name&quot;: &quot;table_name&quot;,
        ///                 &quot;actions&quot;: [
        ///                     &quot;Describe&quot;,
        ///                     &quot;Select&quot;
        ///                 ]
        ///             },
        ///             {
        ///                 &quot;name&quot;: &quot;table_name&quot;,
        ///                 &quot;actions&quot;: [
        ///                     &quot;Describe&quot;,
        ///                     &quot;Select&quot;
        ///                 ]
        ///             }
        ///         ],
        ///         &quot;resource&quot;: [
        ///             {
        ///                 &quot;name&quot;: &quot;&quot;,
        ///                 &quot;actions&quot;: []
        ///             },
        ///             {
        ///                 &quot;name&quot;: &quot;&quot;,
        ///                 &quot;actions&quot;: []
        ///             }
        ///         ],
        ///         &quot;function&quot;: [
        ///             {
        ///                 &quot;name&quot;: &quot;&quot;,
        ///                 &quot;actions&quot;: []
        ///             },
        ///             {
        ///                 &quot;name&quot;: &quot;&quot;,
        ///                 &quot;actions&quot;: []
        ///             }
        ///         ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to install the package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isInstall")]
        [Validation(Required=false)]
        public bool? IsInstall { get; set; }

    }

}
