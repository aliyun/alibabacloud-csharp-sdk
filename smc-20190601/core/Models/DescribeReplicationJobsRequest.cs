// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeReplicationJobsRequest : TeaModel {
        /// <summary>
        /// <para>The business status of the migration job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Preparing: The migration is being prepared.</description></item>
        /// <item><description>Syncing: Data is being synchronized.</description></item>
        /// <item><description>Processing: The migration is in progress.</description></item>
        /// <item><description>Cleaning: Intermediate resources are being released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Preparing</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The IDs of the destination Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the migration jobs. You can specify a maximum of 50 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j-bp19vlwm0tyigbmj****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public List<string> JobId { get; set; }

        /// <summary>
        /// <para>The type of the migration job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: server migration.</description></item>
        /// <item><description>1: operating system migration.</description></item>
        /// <item><description>2: cross-zone migration.</description></item>
        /// <item><description>3: agentless migration for a VMware VM.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public int? JobType { get; set; }

        /// <summary>
        /// <para>The name of the migration job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testMigrationTaskName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud region to which you want to migrate the source server.</para>
        /// <para>For example, if you want to migrate a source server to the China (Hangzhou) region, set this parameter to <c>cn-hangzhou</c>. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw3ty5y7****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The IDs of the source servers. You can specify a maximum of 50 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp1e2fsl57knvuug****</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public List<string> SourceId { get; set; }

        /// <summary>
        /// <para>The status of the migration job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ready: The migration job is not started.</description></item>
        /// <item><description>Running: The migration job is running.</description></item>
        /// <item><description>Stopped: The migration job is paused.</description></item>
        /// <item><description>InError: An error occurs in the migration job.</description></item>
        /// <item><description>Finished: The migration job is complete.</description></item>
        /// <item><description>Waiting: The migration job is waiting to run.</description></item>
        /// <item><description>Expired: The migration job has expired.</description></item>
        /// <item><description>Deleting: The migration job is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The information about tags that are attached to the SMC resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeReplicationJobsRequestTag> Tag { get; set; }
        public class DescribeReplicationJobsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag N that is added to the SMC resource. Valid values of N: 1 to 20.</para>
            /// <para>The tag key can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N that is added to the SMC resource. Valid values of N: 1 to 20.</para>
            /// <para>The tag value can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.<a href="http://https://%E3%80%82"></a></para>
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
