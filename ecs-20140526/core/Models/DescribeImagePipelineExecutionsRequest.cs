// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image build task.</para>
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
        /// <para>The maximum number of entries per page for paging. Valid values: 1 to 500.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the value of NextToken returned in the previous call. You do not need to set this parameter for the first request.</para>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The status of the image build task. You can specify multiple values at the same time. Separate multiple values with commas (,). Example: <c>BUILDING,DISTRIBUTING</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PREPARING: The task is being prepared. Resources such as the temporary intermediate instance are being created.</description></item>
        /// <item><description>REPAIRING: The task is being repaired. The source image is being repaired.</description></item>
        /// <item><description>BUILDING: The task is being built. Custom commands are being run and the image is being created.</description></item>
        /// <item><description>TESTING: The task is being tested. Custom test commands are being run.</description></item>
        /// <item><description>DISTRIBUTING: The task is being distributed. Image copying and sharing are being performed.</description></item>
        /// <item><description>RELEASING: Resources are being reclaimed. Temporary resources generated during the build process are being released.</description></item>
        /// <item><description>SUCCESS: The task succeeded.</description></item>
        /// <item><description>PARTITION_SUCCESS: The task partially succeeded. The image was built, but exceptions may have occurred during distribution or resource cleanup.</description></item>
        /// <item><description>FAILED: The task failed.</description></item>
        /// <item><description>TEST_FAILED: The test failed. The image was created, but the test failed.</description></item>
        /// <item><description>CANCELLING: The task is being canceled.</description></item>
        /// <item><description>CANCELLED: The task was canceled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is empty, image build tasks in all states are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BUILDING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImagePipelineExecutionsRequestTag> Tag { get; set; }
        public class DescribeImagePipelineExecutionsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. Valid values of N: 1 to 20.</para>
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
