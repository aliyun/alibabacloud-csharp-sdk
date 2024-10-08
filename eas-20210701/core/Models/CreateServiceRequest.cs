// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enter development mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Develop")]
        [Validation(Required=false)]
        public string Develop { get; set; }

        /// <summary>
        /// <para>The custom label.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

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
        /// <para>The request body. For more information about the key request parameters, see <b>Table 1. Request body parameters</b> and <b>Table 2. Metadata parameters</b>. For more information about all related parameters, see <a href="https://help.aliyun.com/document_detail/450525.html">Parameters of model services</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service deployment by using an image:
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
        /// AI-Web application deployment by using an image:
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
        /// Service deployment by using models and processors:
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
