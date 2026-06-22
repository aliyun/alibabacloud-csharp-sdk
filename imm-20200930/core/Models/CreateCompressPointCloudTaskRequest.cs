// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateCompressPointCloudTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the compression algorithm. Valid values:</para>
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
        /// <para><b>If you do not have special requirements, leave this parameter empty.</b></para>
        /// <para>The chained authorization configuration. This parameter is not required. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access other entity resources</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The parameters for K-d tree compression.</para>
        /// </summary>
        [NameInMap("KdtreeOption")]
        [Validation(Required=false)]
        public KdtreeOption KdtreeOption { get; set; }

        /// <summary>
        /// <para>The notification configuration. For more information, click Notification. For the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// <remarks>
        /// <para>Intelligent Media Management API callbacks do not support specifying a webhook address. Use MNS instead.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The parameters for Octree compression.</para>
        /// </summary>
        [NameInMap("OctreeOption")]
        [Validation(Required=false)]
        public OctreeOption OctreeOption { get; set; }

        /// <summary>
        /// <para>The PCD property fields to compress and the compression order. After compression, the data is decompressed in this order.</para>
        /// <list type="bullet">
        /// <item><description><para>If you use Octree compression from the Point Cloud Library (PCL), only [&quot;xyz&quot;] is supported.</para>
        /// </description></item>
        /// <item><description><para>If you use K-d tree compression from the Draco library, [&quot;xyz&quot;] or [&quot;xyz&quot;, &quot;intensity&quot;] is supported.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PointCloudFields")]
        [Validation(Required=false)]
        public List<string> PointCloudFields { get; set; }

        /// <summary>
        /// <para>The format of the point cloud file. Only the PCD format is supported. The default value is pcd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcd</para>
        /// </summary>
        [NameInMap("PointCloudFileFormat")]
        [Validation(Required=false)]
        public string PointCloudFileFormat { get; set; }

        /// <summary>
        /// <para>The project name. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
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
        /// <para>The URI must be in the format oss\://${Bucket}/${Object}. ${Bucket} is the name of the OSS bucket in the same region as the project. ${Object} is the full path of the file, including the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test/src/test.pcd</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>Custom tags to search for and filter asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;LabelKey&quot;: &quot;Value&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The OSS URI of the output file after compression.</para>
        /// <para>The URI must be in the format oss\://${Bucket}/${Object}. ${Bucket} is the name of the OSS bucket in the same region as the project. ${Object} is the full path of the file, including the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test/tgt</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>Custom information that is returned in the asynchronous notification message. You can use this information to associate notification messages in your system. The maximum length is 2048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
