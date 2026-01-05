// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DataWorks workspace. To obtain the workspace ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and navigate to the workspace configuration page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The specific file stream or OSS download link contained in the resource.</para>
        /// <remarks>
        /// <para> This field allows users to provide a file stream or an OSS download link. When providing an OSS download link, ensure that the OSS link is publicly accessible. A presigned URL is recommended.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://bucketname1.oss-cn-shanghai.aliyuncs.com/example">http://bucketname1.oss-cn-shanghai.aliyuncs.com/example</a></para>
        /// </summary>
        [NameInMap("ResourceFile")]
        [Validation(Required=false)]
        public string ResourceFile { get; set; }

        /// <summary>
        /// <para>The FlowSpec field information about the file resource. For more information, see <a href="https://github.com/aliyun/dataworks-spec/blob/master/README_zh_CN.md">FlowSpec</a>.</para>
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
