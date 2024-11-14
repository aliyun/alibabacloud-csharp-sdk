// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The information about the replication pair-consistent groups.</para>
        /// </summary>
        [NameInMap("ReplicaGroups")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaGroupsResponseBodyReplicaGroups> ReplicaGroups { get; set; }
        public class DescribeDiskReplicaGroupsResponseBodyReplicaGroups : TeaModel {
            /// <summary>
            /// <para>The bandwidth value. Unit: Kbit/s. This parameter is not publicly available and has a system-preset value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The description of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the secondary site is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the zone in which the secondary site is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-e</para>
            /// </summary>
            [NameInMap("DestinationZoneId")]
            [Validation(Required=false)]
            public string DestinationZoneId { get; set; }

            /// <summary>
            /// <para>The name of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myreplicagrouptest</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The time when data was last replicated from the primary disks to the secondary disks in the replication pair-consistent group. The value of this parameter is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637835114</para>
            /// </summary>
            [NameInMap("LastRecoverPoint")]
            [Validation(Required=false)]
            public long? LastRecoverPoint { get; set; }

            /// <summary>
            /// <para>The IDs of replication pairs that belong to the replication pair-consistent group.</para>
            /// </summary>
            [NameInMap("PairIds")]
            [Validation(Required=false)]
            public List<byte[]> PairIds { get; set; }

            /// <summary>
            /// <para>The number of replication pairs that belong to the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PairNumber")]
            [Validation(Required=false)]
            public long? PairNumber { get; set; }

            /// <summary>
            /// <para>The initial source region (primary region) of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("PrimaryRegion")]
            [Validation(Required=false)]
            public string PrimaryRegion { get; set; }

            /// <summary>
            /// <para>The initial source zone (primary zone) of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// <para>The recovery point objective (RPO) of the replication pair-consistent group. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("RPO")]
            [Validation(Required=false)]
            public long? RPO { get; set; }

            /// <summary>
            /// <para>The IDs of the replication pair-consistent groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-myreplica****</para>
            /// </summary>
            [NameInMap("ReplicaGroupId")]
            [Validation(Required=false)]
            public string ReplicaGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the replication pair-consistent group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2a*******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of the site from which the information about the replication pairs and replication pair-consistent group was obtained. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>production: primary site</description></item>
            /// <item><description>backup: secondary site</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the primary site is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the zone in which the primary site is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-f</para>
            /// </summary>
            [NameInMap("SourceZoneId")]
            [Validation(Required=false)]
            public string SourceZoneId { get; set; }

            /// <summary>
            /// <para>The initial destination region (secondary region) of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("StandbyRegion")]
            [Validation(Required=false)]
            public string StandbyRegion { get; set; }

            /// <summary>
            /// <para>The initial destination zone (secondary zone) of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-e</para>
            /// </summary>
            [NameInMap("StandbyZone")]
            [Validation(Required=false)]
            public string StandbyZone { get; set; }

            /// <summary>
            /// <para>The status of the replication pair-consistent group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>invalid: The replication pair-consistent group is invalid, which indicates that abnormal replication pairs are present in the replication pair-consistent group.</description></item>
            /// <item><description>creating: The replication pair-consistent group is being created.</description></item>
            /// <item><description>created: The replication pair-consistent group was created.</description></item>
            /// <item><description>create_failed: The replication pair-consistent group failed to be created.</description></item>
            /// <item><description>manual_syncing: Data was being manually synchronized between the disks in the replication pair-consistent group. When data was being manually synchronized for the first time, the replication pair is in this state.</description></item>
            /// <item><description>syncing: Data was being synchronized between the disks. When data is being asynchronously replicated from the primary disk to the secondary disk again in subsequent operations, the replication pair is in this state.</description></item>
            /// <item><description>normal: The replication pair was working as expected. When the system finishes replicating data from the primary disk to the secondary disk within the current replication cycle, the replication pair enters this state.</description></item>
            /// <item><description>stopping: The replication pair was being stopped.</description></item>
            /// <item><description>stopped: The replication pair was stopped.</description></item>
            /// <item><description>stop_failed: The replication pair failed to be stopped.</description></item>
            /// <item><description>failovering: A failover was being performed.</description></item>
            /// <item><description>failovered: A failover was performed.</description></item>
            /// <item><description>failover_failed: A failover failed to be performed.</description></item>
            /// <item><description>reprotecting: A reverse replication was being performed.</description></item>
            /// <item><description>reprotect_failed: A reverse replication failed to be performed.</description></item>
            /// <item><description>deleting: The replication pair was being deleted.</description></item>
            /// <item><description>delete_failed: The replication pair failed to be deleted.</description></item>
            /// <item><description>deleted: The replication pair was deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the replication pair-consistent group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDiskReplicaGroupsResponseBodyReplicaGroupsTags> Tags { get; set; }
            public class DescribeDiskReplicaGroupsResponseBodyReplicaGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the replication pair-consistent group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the replication pair-consistent group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAA478A0-BEE6-1D42-BEB6-A9CFEAD6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
