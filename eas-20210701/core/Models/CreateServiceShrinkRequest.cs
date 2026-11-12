// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5db780a0-9d3e-4f35-a84a-xxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enter development mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Develop")]
        [Validation(Required=false)]
        public string Develop { get; set; }

        /// <summary>
        /// <para>Specifies whether to only perform a dry run for this request.</para>
        /// <list type="bullet">
        /// <item><description><para>true: A check request is sent, and no actual operation is performed. If the check fails, the corresponding error is returned. If the check succeeds, the error code DryRunOperation is returned.</para>
        /// </description></item>
        /// <item><description><para>false (default): A normal request is sent.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The user-defined labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string LabelsShrink { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The request body. For instructions on key request parameter settings, see <b>Table 1. Request body parameters</b> and <b>Table 2. Metadata parameters</b> below. For more details about parameter settings, see <a href="https://help.aliyun.com/document_detail/450525.html">All related metric description for service models</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service deployed by using an image:
        /// {
        ///   &quot;name&quot;: &quot;foo&quot;,
        ///   &quot;metadata&quot;: {
        ///     &quot;instance&quot;: 2,
        ///     &quot;memory&quot;: 7000,
        ///     &quot;cpu&quot;: 4
        ///     },
        ///   &quot;containers&quot;: [
        ///     {
        ///       &quot;image&quot;: &quot;<b><b>&quot;,
        ///       &quot;script&quot;: &quot;</b></b> --listen=0.0.0.0 --server_port=8000 --headless&quot;,
        ///       &quot;port&quot;: 8000
        ///     }
        ///   ],
        ///   &quot;storage&quot;: [
        ///     {
        ///       &quot;oss&quot;: {
        ///         &quot;path&quot;: &quot;oss://examplebuket/data111/&quot;,
        ///         &quot;readOnly&quot;: false
        ///       },
        ///       &quot;properties&quot;: {
        ///         &quot;resource_type&quot;: &quot;model&quot;
        ///       },
        ///       &quot;mount_path&quot;: &quot;/data&quot;
        ///     }
        ///   ]
        /// }
        /// AI-Web application deployed by using an image:
        /// {
        ///   &quot;name&quot;: &quot;foo&quot;,
        ///   &quot;metadata&quot;: {
        ///     &quot;instance&quot;: 1,
        ///     &quot;memory&quot;: 7000,
        ///     &quot;cpu&quot;: 4,
        ///     &quot;enable_webservice&quot;: true
        ///   },
        ///   &quot;containers&quot;: [
        ///     {
        ///       &quot;image&quot;: &quot;<b><b>&quot;,
        ///       &quot;script&quot;: &quot;</b></b> --listen=0.0.0.0 --server_port=8000 --headless&quot;,
        ///       &quot;port&quot;: 8000
        ///     }
        ///   ],
        ///   &quot;storage&quot;: [
        ///     {
        ///       &quot;oss&quot;: {
        ///         &quot;path&quot;: &quot;oss://examplebucket/data111/&quot;,
        ///         &quot;readOnly&quot;: false
        ///       },
        ///       &quot;properties&quot;: {
        ///       &quot;resource_type&quot;: &quot;model&quot;
        ///       },
        ///       &quot;mount_path&quot;: &quot;/data&quot;
        ///     }
        ///   ]
        /// }
        /// Service deployed by using a model and a processor:
        /// {
        ///   &quot;metadata&quot;: {
        ///     &quot;instance&quot;: 1,
        ///     &quot;memory&quot;: 7000,
        ///     &quot;cpu&quot;: 4
        ///   },
        ///   &quot;name&quot;: &quot;foo&quot;,
        ///   &quot;model_config&quot;: {},
        ///   &quot;processor_type&quot;: &quot;python&quot;,
        ///   &quot;processor_path&quot;: &quot;oss://<b><b>&quot;,
        ///   &quot;processor_entry&quot;: &quot;a.py&quot;,
        ///   &quot;model_path&quot;: &quot;oss://</b></b>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
