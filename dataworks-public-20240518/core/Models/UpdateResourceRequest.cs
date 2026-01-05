// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateResourceRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the Data Studio file resource.</para>
        /// <remarks>
        /// <para> This field is of type Long in SDK versions prior to 8.0.0, and of type String in SDK version 8.0.0 and later. This change does not affect the normal use of the SDK; parameters are still returned according to the type defined in the SDK. Compilation failures due to the type change may occur only when upgrading the SDK across version 8.0.0, in which case users need to manually correct the data type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>543217824470354XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
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
        ///                 &quot;name&quot;: &quot;OpenAPI_Test_Resource.py&quot;,
        ///                 &quot;script&quot;: {
        ///                     &quot;content&quot;: &quot;&quot;,
        ///                     &quot;path&quot;: &quot;XX/OpenAPI_Test/Resources_Test/OpenAPI_Test_Resource.py&quot;,
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
