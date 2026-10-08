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
        /// <item><description><para>octree: octree</para>
        /// </description></item>
        /// <item><description><para>kdtree: K-d tree</para>
        /// </description></item>
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
        /// <para><b>Leave this parameter empty unless you have special requirements.</b></para>
        /// <para>The China authorization configuration. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The K-d tree compression parameters.</para>
        /// </summary>
        [NameInMap("KdtreeOption")]
        [Validation(Required=false)]
        public string KdtreeOptionShrink { get; set; }

        /// <summary>
        /// <para>The message notification configuration. For more information, click Notification. For information about the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// <remarks>
        /// <para>Intelligent Media Management does not support specifying a callback URL for API call callbacks. Use Message Service (MNS) instead.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The octree compression parameters.</para>
        /// </summary>
        [NameInMap("OctreeOption")]
        [Validation(Required=false)]
        public string OctreeOptionShrink { get; set; }

        /// <summary>
        /// <para>The PCD attribute fields that participate in compression and the compression order. After compression, data is decompressed in this order.</para>
        /// <list type="bullet">
        /// <item><description><para>If you use PCL library octree compression, [&quot;xyz&quot;] is supported.</para>
        /// </description></item>
        /// <item><description><para>If you use Draco library K-d tree compression, [&quot;xyz&quot;] or [&quot;xyz&quot;, &quot;intensity&quot;] is supported.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PointCloudFields")]
        [Validation(Required=false)]
        public string PointCloudFieldsShrink { get; set; }

        /// <summary>
        /// <para>The point cloud file format. Only PCD format is supported. Default value: pcd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcd</para>
        /// </summary>
        [NameInMap("PointCloudFileFormat")]
        [Validation(Required=false)]
        public string PointCloudFileFormat { get; set; }

        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The OSS URI of the point cloud file.</para>
        /// <para>The OSS URI follows the format oss://${Bucket}/${Object}, where <c>${Bucket}</c> is the name of an OSS bucket in the same region as the current project, and <c>${Object}</c> is the full path of the file including the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test/src/test.pcd</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The custom tags that are used to search for and filter asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;LabelKey&quot;: &quot;Value&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The OSS URI of the compressed output file.</para>
        /// <para>The OSS URI follows the format oss://${Bucket}/${Object}, where <c>${Bucket}</c> is the name of an OSS bucket in the same region as the current project, and <c>${Object}</c> is the full path of the file including the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test/tgt</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The custom information, which is returned in asynchronous message notifications to help you associate message notifications within your system. Maximum length: 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
