// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token returned in this call.</para>
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
            /// <para>The bandwidth. Unit: Kbit/s. This parameter is not yet available. The return value is preset by the system.</para>
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
            /// <para>The region ID of the disaster recovery site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// <para>The zone ID of the disaster recovery site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-e</para>
            /// </summary>
            [NameInMap("DestinationZoneId")]
            [Validation(Required=false)]
            public string DestinationZoneId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable replication time control (RTC). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false: Disables RTC.</para>
            /// </description></item>
            /// <item><description><para>true: Enables RTC.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If you set this parameter to true, RTC is enabled for the replication pair-consistent group and all asynchronous replication pairs that are added to the group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableRtc")]
            [Validation(Required=false)]
            public bool? EnableRtc { get; set; }

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
            /// <para>The time when the last asynchronous replication was completed for the replication pair-consistent group. This parameter is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637835114</para>
            /// </summary>
            [NameInMap("LastRecoverPoint")]
            [Validation(Required=false)]
            public long? LastRecoverPoint { get; set; }

            /// <summary>
            /// <para>The list of replication pair IDs in the replication pair-consistent group.</para>
            /// </summary>
            [NameInMap("PairIds")]
            [Validation(Required=false)]
            public List<byte[]> PairIds { get; set; }

            /// <summary>
            /// <para>The number of replication pairs in the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PairNumber")]
            [Validation(Required=false)]
            public long? PairNumber { get; set; }

            /// <summary>
            /// <para>The initial source region of the replication group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("PrimaryRegion")]
            [Validation(Required=false)]
            public string PrimaryRegion { get; set; }

            /// <summary>
            /// <para>The initial source zone of the replication group.</para>
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
            /// <para>The ID of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-myreplica****</para>
            /// </summary>
            [NameInMap("ReplicaGroupId")]
            [Validation(Required=false)]
            public string ReplicaGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the replication group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2a*******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The site of the replication pair and the replication pair-consistent group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>production: The production site.</para>
            /// </description></item>
            /// <item><description><para>backup: The disaster recovery site.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <para>The region ID of the production site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            /// <summary>
            /// <para>The zone ID of the production site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-f</para>
            /// </summary>
            [NameInMap("SourceZoneId")]
            [Validation(Required=false)]
            public string SourceZoneId { get; set; }

            /// <summary>
            /// <para>The initial destination region of the replication group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("StandbyRegion")]
            [Validation(Required=false)]
            public string StandbyRegion { get; set; }

            /// <summary>
            /// <para>The initial destination zone of the replication group.</para>
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
            /// <item><description><para>invalid: The replication pair-consistent group is invalid. This status indicates that a replication pair in the group is abnormal.</para>
            /// </description></item>
            /// <item><description><para>creating: The replication pair-consistent group is being created.</para>
            /// </description></item>
            /// <item><description><para>created: The replication pair-consistent group is created.</para>
            /// </description></item>
            /// <item><description><para>create_failed: The replication pair-consistent group failed to be created.</para>
            /// </description></item>
            /// <item><description><para>manual_syncing: The replication pair-consistent group is performing a one-time synchronization. The group is also in this state during the first one-time synchronization.</para>
            /// </description></item>
            /// <item><description><para>syncing: The replication pair-consistent group is synchronizing data. The group is in this state when data is asynchronously replicated from the primary disk to the secondary disk for a subsequent time.</para>
            /// </description></item>
            /// <item><description><para>normal: Normal. When data replication is complete in the current asynchronous replication cycle, the group is in this state.</para>
            /// </description></item>
            /// <item><description><para>stopping: The replication pair-consistent group is being stopped.</para>
            /// </description></item>
            /// <item><description><para>stopped: The replication pair-consistent group is stopped.</para>
            /// </description></item>
            /// <item><description><para>stop_failed: The replication pair-consistent group failed to be stopped.</para>
            /// </description></item>
            /// <item><description><para>failovering: A failover is being performed.</para>
            /// </description></item>
            /// <item><description><para>failovered: The failover is complete.</para>
            /// </description></item>
            /// <item><description><para>failover_failed: The failover failed.</para>
            /// </description></item>
            /// <item><description><para>reprotecting: A reverse replication is being performed.</para>
            /// </description></item>
            /// <item><description><para>reprotect_failed: The reverse replication failed.</para>
            /// </description></item>
            /// <item><description><para>deleting: The replication pair-consistent group is being deleted.</para>
            /// </description></item>
            /// <item><description><para>delete_failed: The replication pair-consistent group failed to be deleted.</para>
            /// </description></item>
            /// <item><description><para>deleted: The replication pair-consistent group is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the replication group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDiskReplicaGroupsResponseBodyReplicaGroupsTags> Tags { get; set; }
            public class DescribeDiskReplicaGroupsResponseBodyReplicaGroupsTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag of the replication group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag of the replication group.</para>
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
