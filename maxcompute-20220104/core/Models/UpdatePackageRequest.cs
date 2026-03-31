// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdatePackageRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;add&quot;: {
        ///         &quot;allowedProjectList&quot;: [
        ///             {
        ///                 &quot;label&quot;: &quot;2&quot;,
        ///                 &quot;project&quot;: &quot;project_name&quot;
        ///             }
        ///         ],
        ///         &quot;resourceList&quot;: {
        ///             &quot;table&quot;: [
        ///                 {
        ///                     &quot;name&quot;: &quot;table_name&quot;,
        ///                     &quot;actions&quot;: [
        ///                         &quot;Describe&quot;,
        ///                         &quot;Select&quot;
        ///                     ]
        ///                 },
        ///                 {
        ///                     &quot;name&quot;: &quot;table_name&quot;,
        ///                     &quot;actions&quot;: [
        ///                         &quot;Describe&quot;,
        ///                         &quot;Select&quot;
        ///                     ]
        ///                 }
        ///             ],
        ///             &quot;resource&quot;: [
        ///                 {
        ///                     &quot;name&quot;: &quot;&quot;,
        ///                     &quot;actions&quot;: []
        ///                 },
        ///                 {
        ///                     &quot;name&quot;: &quot;&quot;,
        ///                     &quot;actions&quot;: []
        ///                 }
        ///             ],
        ///             &quot;function&quot;: [
        ///                 {
        ///                     &quot;name&quot;: &quot;&quot;,
        ///                     &quot;actions&quot;: []
        ///                 },
        ///                 {
        ///                     &quot;name&quot;: &quot;&quot;,
        ///                     &quot;actions&quot;: []
        ///                 }
        ///             ]
        ///         }
        ///     },
        ///     &quot;remove&quot;: {
        ///         &quot;allowedProjectList&quot;: [
        ///             {
        ///                 &quot;project&quot;: &quot;project_name&quot;
        ///             },
        ///             {
        ///                 &quot;project&quot;: &quot;project_2&quot;
        ///             }
        ///         ],
        ///         &quot;resourceList&quot;: {
        ///             &quot;table&quot;: [
        ///                 {
        ///                     &quot;name&quot;: &quot;table_name&quot;
        ///                 },
        ///                 {
        ///                     &quot;name&quot;: &quot;table_name&quot;
        ///                 }
        ///             ],
        ///             &quot;resource&quot;: [
        ///                 {
        ///                     &quot;name&quot;: &quot;&quot;
        ///                 },
        ///                 {
        ///                     &quot;name&quot;: &quot;&quot;
        ///                 }
        ///             ],
        ///             &quot;function&quot;: [
        ///                 {
        ///                     &quot;name&quot;: &quot;&quot;
        ///                 },
        ///                 {
        ///                     &quot;name&quot;: &quot;&quot;
        ///                 }
        ///             ]
        ///         }
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
