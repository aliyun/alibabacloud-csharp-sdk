// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairsResponseBody : TeaModel {
        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Details about the replication pairs.
        /// </summary>
        [NameInMap("ReplicaPairs")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaPairsResponseBodyReplicaPairs> ReplicaPairs { get; set; }
        public class DescribeDiskReplicaPairsResponseBodyReplicaPairs : TeaModel {
            /// <summary>
            /// The bandwidth used to asynchronously replicate data from the primary disk to the secondary disk. Unit: Kbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// The billing method of the replication pair.
            /// 
            /// Valid values:
            /// 
            /// *   PREPAY: subscription
            /// *   POSTPAY: pay-as-you-go
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The time when the replication pair was created. The value of this parameter is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the replication pair.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the secondary disk.
            /// </summary>
            [NameInMap("DestinationDiskId")]
            [Validation(Required=false)]
            public string DestinationDiskId { get; set; }

            /// <summary>
            /// The region ID of the secondary disk.
            /// </summary>
            [NameInMap("DestinationRegion")]
            [Validation(Required=false)]
            public string DestinationRegion { get; set; }

            /// <summary>
            /// The zone ID of the secondary disk.
            /// </summary>
            [NameInMap("DestinationZoneId")]
            [Validation(Required=false)]
            public string DestinationZoneId { get; set; }

            /// <summary>
            /// The time when the replication pair expires. The value of this parameter is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// The time when data was last replicated from the primary disk to the secondary disk in the replication pair. The value of this parameter is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("LastRecoverPoint")]
            [Validation(Required=false)]
            public long? LastRecoverPoint { get; set; }

            /// <summary>
            /// The name of the replication pair.
            /// </summary>
            [NameInMap("PairName")]
            [Validation(Required=false)]
            public string PairName { get; set; }

            /// <summary>
            /// The initial source region (primary region) of the replication pair.
            /// </summary>
            [NameInMap("PrimaryRegion")]
            [Validation(Required=false)]
            public string PrimaryRegion { get; set; }

            /// <summary>
            /// The initial source zone (primary zone) of the replication pair.
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// The recovery point objective (RPO) of the replication pair. Unit: seconds.
            /// </summary>
            [NameInMap("RPO")]
            [Validation(Required=false)]
            public long? RPO { get; set; }

            /// <summary>
            /// The ID of the replication pair-consistent group to which the replication pair belongs.
            /// </summary>
            [NameInMap("ReplicaGroupId")]
            [Validation(Required=false)]
            public string ReplicaGroupId { get; set; }

            /// <summary>
            /// The name of the replication pair-consistent group to which the replication pair belongs.
            /// </summary>
            [NameInMap("ReplicaGroupName")]
            [Validation(Required=false)]
            public string ReplicaGroupName { get; set; }

            /// <summary>
            /// The ID of the replication pair.
            /// </summary>
            [NameInMap("ReplicaPairId")]
            [Validation(Required=false)]
            public string ReplicaPairId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the replication pair belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The type of the site from which the information of the replication pair and replication pair-consistent group is obtained. Valid values:
            /// 
            /// *   production: primary site
            /// *   backup: secondary site
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// The ID of the primary disk.
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// The region ID of the primary disk.
            /// </summary>
            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            /// <summary>
            /// The zone ID of the primary disk.
            /// </summary>
            [NameInMap("SourceZoneId")]
            [Validation(Required=false)]
            public string SourceZoneId { get; set; }

            /// <summary>
            /// The initial destination region (secondary region) of the replication pair.
            /// </summary>
            [NameInMap("StandbyRegion")]
            [Validation(Required=false)]
            public string StandbyRegion { get; set; }

            /// <summary>
            /// The initial destination zone (secondary zone) of the replication pair.
            /// </summary>
            [NameInMap("StandbyZone")]
            [Validation(Required=false)]
            public string StandbyZone { get; set; }

            /// <summary>
            /// The state of the replication pair. Valid values:
            /// 
            /// *   invalid: The replication pair is invalid. When a replication pair becomes abnormal, it enters this state.
            /// *   creating: The replication pair is being created.
            /// *   created: The replication pair is created.
            /// *   create_failed: The replication pair cannot be created.
            /// *   initial_syncing: Data is synchronized from the primary disk to the secondary disk for the first time. After a replication pair is created and activated, the replication pair is in this state the first time data is synchronized from the primary disk to the secondary disk.
            /// *   manual_syncing: Data is being manually synchronized from the primary disk to the secondary disk. After data is manually synchronized from the primary disk to the secondary disk, the replication pair returns to the Stopped state. The first time data is manually synchronized from the primary disk to the secondary disk, the replication pair is in the manual_syncing state during the synchronization.
            /// *   syncing: Data is being synchronized from the primary disk to the secondary disk. While data is being asynchronously replicated from the primary disk to the secondary disk not for the first time, the replication pair is in this state.
            /// *   normal: The replication pair is working as expected. When the system finishes replicating data from the primary disk to the secondary disk within the current replication cycle, the replication pair enters this state.
            /// *   stopping: The replication pair is being stopped.
            /// *   stopped: The replication pair is stopped.
            /// *   stop_failed: The replication pair cannot be stopped.
            /// *   failovering: A failover is being performed.
            /// *   failovered: A failover is performed.
            /// *   failover_failed: A failover cannot be performed.
            /// *   reprotecting: A reverse replication is being performed.
            /// *   reprotect_failed: A reverse replication cannot be performed.
            /// *   deleting: The replication pair is being deleted.
            /// *   delete_failed: The replication pair cannot be deleted.
            /// *   deleted: The replication pair is deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The message that describes the state of the replication pair. This parameter has a value when `Status` has a value of invalid or `create_failed`. Valid values:
            /// 
            /// *   PrePayOrderExpired: The replication pair has expired.
            /// *   PostPayOrderCeaseService: The pay-as-you-go replication pair has been stopped due to an overdue payment.
            /// *   DeviceRemoved: The primary or secondary disk has been deleted.
            /// *   DeviceKeyChanged: The `DeviceKey` mapping of the primary or secondary disk has changed.
            /// *   DeviceSizeChanged: The `DeviceSize` value of the primary or secondary disk has changed.
            /// *   OperationDenied.QuotaExceed: The maximum number of replication pairs that can be created has been reached.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// The tags of the replication pair.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDiskReplicaPairsResponseBodyReplicaPairsTags> Tags { get; set; }
            public class DescribeDiskReplicaPairsResponseBodyReplicaPairsTags : TeaModel {
                /// <summary>
                /// The tag key of the replication pair.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the replication pair.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
