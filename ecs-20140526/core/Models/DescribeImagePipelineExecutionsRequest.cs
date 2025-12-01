// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>null</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-5fb8facb8ed7427c****</para>
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// <para>The value of tag N of the image creation task. Valid values of N: 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip-2ze5tsl5bp6nf2b3****</para>
        /// </summary>
        [NameInMap("ImagePipelineId")]
        [Validation(Required=false)]
        public string ImagePipelineId { get; set; }

        /// <summary>
        /// <para>The status of the image creation task. You can specify multiple values. Separate the values with commas (,). Example: <c>BUILDING,DISTRIBUTING</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PREPARING: Resources, such as the intermediate instance, are being created.</description></item>
        /// <item><description>REPAIRING: The source image is being repaired.</description></item>
        /// <item><description>BUILDING: The user-defined commands are being run and an image is being created.</description></item>
        /// <item><description>TESTING: The user-defined test commands are being run.</description></item>
        /// <item><description>DISTRIBUTING: The created image is being copied and shared.</description></item>
        /// <item><description>RELEASING: The temporary resources generated during the image creation process are being released.</description></item>
        /// <item><description>SUCCESS: The image creation task is completed.</description></item>
        /// <item><description>PARTITION_SUCCESS: The image creation task is partially completed. The image is created, but exceptions may occur when the image was copied or shared or when temporary resources were released.</description></item>
        /// <item><description>FAILED: The image creation task fails.</description></item>
        /// <item><description>TEST_FAILED: The image is created, but the test fails.</description></item>
        /// <item><description>CANCELLING: The image creation task is being canceled.</description></item>
        /// <item><description>CANCELLED: The image creation task is canceled.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you leave this parameter empty, all image creation tasks are queried regardless of task status.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the image creation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the image template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUILDING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the image creation task.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImagePipelineExecutionsRequestTag> Tag { get; set; }
        public class DescribeImagePipelineExecutionsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the image creation task. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
