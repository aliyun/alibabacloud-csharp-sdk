// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image building task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-5fb8facb8ed7427c****</para>
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// <para>The ID of the image template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip-2ze5tsl5bp6nf2b3****</para>
        /// </summary>
        [NameInMap("ImagePipelineId")]
        [Validation(Required=false)]
        public string ImagePipelineId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 500.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the <c>NextToken</c> value returned from a previous call to this operation. This parameter is not required for the first call.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
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
        /// <para>The status of the image building task. You can specify multiple values, separated by commas. Example: <c>BUILDING,DISTRIBUTING</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PREPARING: The system is preparing resources, such as a temporary transit instance.</para>
        /// </description></item>
        /// <item><description><para>REPAIRING: The system is repairing the source image.</para>
        /// </description></item>
        /// <item><description><para>BUILDING: The system is building the image. This includes executing user-defined commands and creating the image.</para>
        /// </description></item>
        /// <item><description><para>TESTING: The system is testing the created image by running user-defined test commands.</para>
        /// </description></item>
        /// <item><description><para>DISTRIBUTING: The system is distributing the image. This includes copying and sharing the image.</para>
        /// </description></item>
        /// <item><description><para>RELEASING: The system is releasing temporary resources generated during the build process.</para>
        /// </description></item>
        /// <item><description><para>SUCCESS: The task completed successfully.</para>
        /// </description></item>
        /// <item><description><para>PARTITION_SUCCESS: The task is partially successful. The image was created, but an error may have occurred during distribution or resource cleanup.</para>
        /// </description></item>
        /// <item><description><para>FAILED: The image building task failed.</para>
        /// </description></item>
        /// <item><description><para>TEST_FAILED: The image was created successfully, but it failed the user-defined tests.</para>
        /// </description></item>
        /// <item><description><para>CANCELLING: The system is canceling the image building task.</para>
        /// </description></item>
        /// <item><description><para>CANCELLED: The image building task was canceled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you omit this parameter, the operation returns image building tasks of all statuses.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BUILDING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImagePipelineExecutionsRequestTag> Tag { get; set; }
        public class DescribeImagePipelineExecutionsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. The value of N can be from 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. The value of N can be from 1 to 20.</para>
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
