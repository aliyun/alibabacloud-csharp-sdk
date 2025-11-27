// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateCompressPointCloudTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The compression algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>octree</description></item>
        /// <item><description>kdtree</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>octree</para>
        /// </summary>
        [NameInMap("CompressMethod")]
        [Validation(Required=false)]
        public string CompressMethod { get; set; }

        /// <summary>
        /// <para><b>If you have no special requirements, leave this parameter empty.</b></para>
        /// <para>The configurations of authorization chains. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The k-d tree compression options.</para>
        /// </summary>
        [NameInMap("KdtreeOption")]
        [Validation(Required=false)]
        public string KdtreeOptionShrink { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// <remarks>
        /// <para> The IMM operation does not support a callback URL. We recommend that you use Simple Message Queue (SMQ) to receive notifications.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The octree compression options.</para>
        /// </summary>
        [NameInMap("OctreeOption")]
        [Validation(Required=false)]
        public string OctreeOptionShrink { get; set; }

        /// <summary>
        /// <para>The PCD property fields and the compression order in which the data is decompressed after the compression is complete.</para>
        /// <list type="bullet">
        /// <item><description>If octree of Point Cloud Library (PCL) is used for compression, [&quot;xyz&quot;] is supported.</description></item>
        /// <item><description>If Draco k-dimensional (k-d) tree is used for compression, [&quot;xyz&quot;] and [&quot;xyz&quot;, &quot;intensity&quot;] are supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PointCloudFields")]
        [Validation(Required=false)]
        public string PointCloudFieldsShrink { get; set; }

        /// <summary>
        /// <para>The file format. Set the value to the default value: pcd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcd</para>
        /// </summary>
        [NameInMap("PointCloudFileFormat")]
        [Validation(Required=false)]
        public string PointCloudFileFormat { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The OSS URL of the PCD file.</para>
        /// <para>Specify the value in the oss://${Bucket}/${Object} format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region as the current project. <c>${Object}</c> specifies the path of the object with the extension included.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test/src/test.pcd</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The custom tags, which can be used to search for and filter asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;LabelKey&quot;: &quot;Value&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The OSS URL of the output file after compression.</para>
        /// <para>Specify the value in the oss://${Bucket}/${Object} format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region as the current project. <c>${Object}</c> specifies the path of the object with the extension included.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test/tgt</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The custom data, which is returned in an asynchronous notification and facilitates notification management. The maximum length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
