// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
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
        /// <para>Details about the replication pairs.</para>
        /// </summary>
        [NameInMap("ReplicaPairs")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaPairsResponseBodyReplicaPairs> ReplicaPairs { get; set; }
        public class DescribeDiskReplicaPairsResponseBodyReplicaPairs : TeaModel {
            /// <summary>
            /// <para>The bandwidth used to asynchronously replicate data from the primary disk to the secondary disk. Unit: Kbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The billing method of the replication pair. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PREPAY: subscription</description></item>
            /// <item><description>POSTPAY: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the replication pair was created. The value of this parameter is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649750977</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the secondary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-asdfjl2342kj2l3k4****</para>
            /// </summary>
            [NameInMap("DestinationDiskId")]
            [Validation(Required=false)]
            public string DestinationDiskId { get; set; }

            /// <summary>
            /// <para>The region ID of the secondary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestinationRegion")]
            [Validation(Required=false)]
            public string DestinationRegion { get; set; }

            /// <summary>
            /// <para>The zone ID of the secondary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("DestinationZoneId")]
            [Validation(Required=false)]
            public string DestinationZoneId { get; set; }

            [NameInMap("EnableRtc")]
            [Validation(Required=false)]
            public bool? EnableRtc { get; set; }

            /// <summary>
            /// <para>The time when the replication pair expires. The value of this parameter is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649750977</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// <para>The time when data was last replicated from the primary disk to the secondary disk in the replication pair. The value of this parameter is a timestamp. Unit: seconds. 86,400 seconds is equivalent to 24 hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649751977</para>
            /// </summary>
            [NameInMap("LastRecoverPoint")]
            [Validation(Required=false)]
            public long? LastRecoverPoint { get; set; }

            /// <summary>
            /// <para>The name of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestReplicaPair</para>
            /// </summary>
            [NameInMap("PairName")]
            [Validation(Required=false)]
            public string PairName { get; set; }

            /// <summary>
            /// <para>The initial source region (primary region) of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("PrimaryRegion")]
            [Validation(Required=false)]
            public string PrimaryRegion { get; set; }

            /// <summary>
            /// <para>The initial source zone (primary zone) of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-a</para>
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// <para>The recovery point objective (RPO) of the replication pair. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("RPO")]
            [Validation(Required=false)]
            public long? RPO { get; set; }

            /// <summary>
            /// <para>The ID of the replication pair-consistent group to which the replication pair belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxxx****</para>
            /// </summary>
            [NameInMap("ReplicaGroupId")]
            [Validation(Required=false)]
            public string ReplicaGroupId { get; set; }

            /// <summary>
            /// <para>The name of the replication pair-consistent group to which the replication pair belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-name****</para>
            /// </summary>
            [NameInMap("ReplicaGroupName")]
            [Validation(Required=false)]
            public string ReplicaGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pair-cn-dsa****</para>
            /// </summary>
            [NameInMap("ReplicaPairId")]
            [Validation(Required=false)]
            public string ReplicaPairId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the replication pair belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmvs*****</para>
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
            /// <para>The ID of the primary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp131n0q38u3a4zi****</para>
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// <para>The region ID of the primary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            /// <summary>
            /// <para>The zone ID of the primary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-a</para>
            /// </summary>
            [NameInMap("SourceZoneId")]
            [Validation(Required=false)]
            public string SourceZoneId { get; set; }

            /// <summary>
            /// <para>The initial destination region (secondary region) of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("StandbyRegion")]
            [Validation(Required=false)]
            public string StandbyRegion { get; set; }

            /// <summary>
            /// <para>The initial destination zone (secondary zone) of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("StandbyZone")]
            [Validation(Required=false)]
            public string StandbyZone { get; set; }

            /// <summary>
            /// <para>The status of the replication pair. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>invalid: The replication pair was invalid. When a replication pair becomes abnormal, it enters this state.</description></item>
            /// <item><description>creating: The replication pair was being created.</description></item>
            /// <item><description>created: The replication pair was created.</description></item>
            /// <item><description>create_failed: The replication pair failed to be created.</description></item>
            /// <item><description>initial_syncing: Data was synchronized from the primary disk to the secondary disk for the first time. After a replication pair is created and activated, the replication pair is in this state the first time data is synchronized from the primary disk to the secondary disk.</description></item>
            /// <item><description>manual_syncing: Data was being manually synchronized from the primary disk to the secondary disk. After data is manually synchronized from the primary disk to the secondary disk, the replication pair returns to the stopped state. The first time data is manually synchronized from the primary disk to the secondary disk, the replication pair is in the manual_syncing state during the synchronization.</description></item>
            /// <item><description>syncing: Data was being synchronized from the primary disk to the secondary disk. When data is being asynchronously replicated from the primary disk to the secondary disk again in subsequent operations, the replication pair is in this state.</description></item>
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
            /// <para>The message that describes the state of the replication pair. This parameter has a value when <c>Status</c> has a value of invalid or <c>create_failed</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrePayOrderExpired: The replication pair has expired.</description></item>
            /// <item><description>PostPayOrderCeaseService: The pay-as-you-go replication pair has been stopped due to an overdue payment.</description></item>
            /// <item><description>DeviceRemoved: The primary or secondary disk has been deleted.</description></item>
            /// <item><description>DeviceKeyChanged: The <c>DeviceKey</c> mapping of the primary or secondary disk has changed.</description></item>
            /// <item><description>DeviceSizeChanged: The <c>DeviceSize</c> value of the primary or secondary disk has changed.</description></item>
            /// <item><description>OperationDenied.QuotaExceed: The maximum number of replication pairs that can be created has been reached.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePayOrderExpired</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The tags of the replication pair.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDiskReplicaPairsResponseBodyReplicaPairsTags> Tags { get; set; }
            public class DescribeDiskReplicaPairsResponseBodyReplicaPairsTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
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
        /// <para>The ID of the request.</para>
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
