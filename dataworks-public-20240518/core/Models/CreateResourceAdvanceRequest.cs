// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateResourceAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The file stream or Object Storage Service (OSS) download URL of the resource file.</para>
        /// <remarks>
        /// <para>Notice: This field allows you to specify a file stream or an OSS download URL. If you specify an OSS download URL, make sure that the URL is publicly accessible. A pre-signed URL is recommended.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://bucketname1.oss-cn-shanghai.aliyuncs.com/example">http://bucketname1.oss-cn-shanghai.aliyuncs.com/example</a></para>
        /// </summary>
        [NameInMap("ResourceFile")]
        [Validation(Required=false)]
        public Stream ResourceFileObject { get; set; }

        /// <summary>
        /// <para>The FlowSpec information that describes the resource file. For more information about the specification, see <a href="https://github.com/aliyun/dataworks-spec/blob/master/README_zh_CN.md">FlowSpec</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;version&quot;: &quot;1.1.0&quot;,
        ///     &quot;kind&quot;: &quot;Resource&quot;,
        ///     &quot;spec&quot;: {
        ///         &quot;fileResources&quot;: [
        ///             {
        ///                 &quot;name&quot;: &quot;OpenAPITestResource.py&quot;,
        ///                 &quot;script&quot;: {
        ///                     &quot;content&quot;: &quot;&quot;,
        ///                     &quot;path&quot;: &quot;XX/OpenAPITest/ResourcesTest/OpenAPITestResource.py&quot;,
        ///                     &quot;runtime&quot;: {
        ///                         &quot;command&quot;: &quot;ODPS_PYTHON&quot;
        ///                     }
        ///                 },
        ///                 &quot;type&quot;: &quot;python&quot;,
        ///                 &quot;file&quot;: {
        ///                     &quot;storage&quot;: {}
        ///                 },
        ///                 &quot;datasource&quot;: {
        ///                     &quot;name&quot;: &quot;odps_first&quot;,
        ///                     &quot;type&quot;: &quot;odps&quot;
        ///                 }
        ///             }
        ///         ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
