// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeReplicationJobsRequest : TeaModel {
        /// <summary>
        /// The business status of the migration job. Valid values:
        /// 
        /// *   Preparing: The migration is being prepared.
        /// *   Syncing: Data is being synchronized.
        /// *   Processing: The migration is in progress.
        /// *   Cleaning: Intermediate resources are being released.
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// The IDs of the destination Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// The IDs of the migration jobs. You can specify a maximum of 50 IDs.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public List<string> JobId { get; set; }

        /// <summary>
        /// The type of the migration job. Valid values:
        /// 
        /// *   0: server migration.
        /// *   1: operating system migration.
        /// *   2: cross-zone migration.
        /// *   3: agentless migration for a VMware VM.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public int? JobType { get; set; }

        /// <summary>
        /// The name of the migration job.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud region to which you want to migrate the source server.
        /// 
        /// For example, if you want to migrate a source server to the China (Hangzhou) region, set this parameter to `cn-hangzhou`. You can call the [DescribeRegions](~~25609~~) operation to query the latest regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The IDs of the source servers. You can specify a maximum of 50 IDs.
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public List<string> SourceId { get; set; }

        /// <summary>
        /// The status of the migration job. Valid values:
        /// 
        /// *   Ready: The migration job is not started.
        /// *   Running: The migration job is running.
        /// *   Stopped: The migration job is paused.
        /// *   InError: An error occurs in the migration job.
        /// *   Finished: The migration job is complete.
        /// *   Waiting: The migration job is waiting to run.
        /// *   Expired: The migration job has expired.
        /// *   Deleting: The migration job is being deleted.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The information about tags that are attached to the SMC resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeReplicationJobsRequestTag> Tag { get; set; }
        public class DescribeReplicationJobsRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag N that is added to the SMC resource. Valid values of N: 1 to 20.
            /// 
            /// The tag key can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that is added to the SMC resource. Valid values of N: 1 to 20.
            /// 
            /// The tag value can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.[](http://https://。)
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
