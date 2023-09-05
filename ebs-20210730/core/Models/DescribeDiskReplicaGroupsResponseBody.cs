// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaGroupsResponseBody : TeaModel {
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
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Details about the replication pair-consistent groups.
        /// </summary>
        [NameInMap("ReplicaGroups")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaGroupsResponseBodyReplicaGroups> ReplicaGroups { get; set; }
        public class DescribeDiskReplicaGroupsResponseBodyReplicaGroups : TeaModel {
            /// <summary>
            /// The bandwidth value. Unit: Mbit/s. This parameter is unavailable and has a system-preset value.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// The description of the replication pair-consistent group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the region in which the secondary site is deployed.
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// The ID of the zone in which the secondary site is deployed.
            /// </summary>
            [NameInMap("DestinationZoneId")]
            [Validation(Required=false)]
            public string DestinationZoneId { get; set; }

            /// <summary>
            /// The name of the replication pair-consistent group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The time when data was last replicated from the primary disks to the secondary disks in the replication pair-consistent group. The value of this parameter is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("LastRecoverPoint")]
            [Validation(Required=false)]
            public long? LastRecoverPoint { get; set; }

            /// <summary>
            /// The IDs of the replications pairs that belong to the replication pair-consistent group.
            /// </summary>
            [NameInMap("PairIds")]
            [Validation(Required=false)]
            public List<byte[]> PairIds { get; set; }

            /// <summary>
            /// The number of replications pairs that belong to the replication pair-consistent group.
            /// </summary>
            [NameInMap("PairNumber")]
            [Validation(Required=false)]
            public long? PairNumber { get; set; }

            /// <summary>
            /// The initial source region (primary region) of the replication pair-consistent group.
            /// </summary>
            [NameInMap("PrimaryRegion")]
            [Validation(Required=false)]
            public string PrimaryRegion { get; set; }

            /// <summary>
            /// The initial source zone (primary zone) of the replication pair-consistent group.
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// The recovery point objective (RPO) of the replication pair-consistent group. Unit: seconds.
            /// </summary>
            [NameInMap("RPO")]
            [Validation(Required=false)]
            public long? RPO { get; set; }

            /// <summary>
            /// The ID of the replication pair-consistent group.
            /// </summary>
            [NameInMap("ReplicaGroupId")]
            [Validation(Required=false)]
            public string ReplicaGroupId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the replication group belongs.
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
            /// The ID of the region in which the primary site is deployed.
            /// </summary>
            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            /// <summary>
            /// The ID of the zone in which the primary site is deployed.
            /// </summary>
            [NameInMap("SourceZoneId")]
            [Validation(Required=false)]
            public string SourceZoneId { get; set; }

            /// <summary>
            /// The initial destination region (secondary region) of the replication pair-consistent group.
            /// </summary>
            [NameInMap("StandbyRegion")]
            [Validation(Required=false)]
            public string StandbyRegion { get; set; }

            /// <summary>
            /// The initial destination zone (secondary zone) of the replication pair-consistent group.
            /// </summary>
            [NameInMap("StandbyZone")]
            [Validation(Required=false)]
            public string StandbyZone { get; set; }

            /// <summary>
            /// The state of the replication pair-consistent group. Valid values:
            /// 
            /// *   invalid: The replication pair-consistent group is invalid, which indicates that abnormal replication pairs are present in the replication pair-consistent group.
            /// *   creating: The replication pair-consistent group is being created.
            /// *   created: The replication pair-consistent group is created.
            /// *   create_failed: The replication pair-consistent group cannot be created.
            /// *   manual_syncing: Data is being manually synchronized between the disks in the replication pair-consistent group. The first time data is being manually synchronized between the disks in a replication pair-consistent group, the replication pair-consistent group is in this state.
            /// *   syncing: Data is being synchronized between the disks in the replication pair-consistent group. While data is being asynchronously replicated from the primary disks to the secondary disks not for the first time, the replication pair-consistent group is in this state.
            /// *   normal: The replication pair-consistent group is working as expected. When the system finishes replicating data from the primary disks to the secondary disks within the current replication cycle, the replication pair-consistent group enters this state.
            /// *   stopping: The replication pair-consistent group is being stopped.
            /// *   stopped: The replication pair-consistent group is stopped.
            /// *   stop_failed: The replication pair-consistent group cannot be stopped.
            /// *   failovering: A failover is being performed.
            /// *   failovered: A failover is performed.
            /// *   failover_failed: A failover cannot be performed.
            /// *   reprotecting: A reverse replication is being performed.
            /// *   reprotect_failed: A reverse replication cannot be performed.
            /// *   deleting: The replication pair-consistent group is being deleted.
            /// *   delete_failed: The replication pair-consistent group cannot be deleted.
            /// *   deleted: The replication pair-consistent group is deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the replication pair.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDiskReplicaGroupsResponseBodyReplicaGroupsTags> Tags { get; set; }
            public class DescribeDiskReplicaGroupsResponseBodyReplicaGroupsTags : TeaModel {
                /// <summary>
                /// The tag key of the replication group.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the replication group.
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
