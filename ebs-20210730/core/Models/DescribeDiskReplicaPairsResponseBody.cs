// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token returned from this call.</para>
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
        /// <para>The replication pairs.</para>
        /// </summary>
        [NameInMap("ReplicaPairs")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaPairsResponseBodyReplicaPairs> ReplicaPairs { get; set; }
        public class DescribeDiskReplicaPairsResponseBodyReplicaPairs : TeaModel {
            /// <summary>
            /// <para>The bandwidth used for asynchronous replication. Unit: Kbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The billing method of the replication pair.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PREPAY: subscription.</para>
            /// </description></item>
            /// <item><description><para>POSTPAY: pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The creation time. This value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <para>The region of the secondary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestinationRegion")]
            [Validation(Required=false)]
            public string DestinationRegion { get; set; }

            /// <summary>
            /// <para>The zone of the secondary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("DestinationZoneId")]
            [Validation(Required=false)]
            public string DestinationZoneId { get; set; }

            /// <summary>
            /// <para>Specifies whether real-time control (RTC) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If the replication pair is in a replication pair-consistent group, the value of this parameter is the same as that of the group.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("EnableRtc")]
            [Validation(Required=false)]
            public bool? EnableRtc { get; set; }

            /// <summary>
            /// <para>The expiration time of the replication pair. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649750977</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// <para>The time when the last asynchronous replication was completed. This value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <para>The initial source region of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("PrimaryRegion")]
            [Validation(Required=false)]
            public string PrimaryRegion { get; set; }

            /// <summary>
            /// <para>The initial source zone of the replication pair.</para>
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
            /// <para>The site type of the replication pair or replication pair-consistent group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>production: the production site.</para>
            /// </description></item>
            /// <item><description><para>backup: the disaster recovery site.</para>
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
            /// <para>The ID of the primary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp131n0q38u3a4zi****</para>
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// <para>The region of the primary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            /// <summary>
            /// <para>The zone of the primary disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-a</para>
            /// </summary>
            [NameInMap("SourceZoneId")]
            [Validation(Required=false)]
            public string SourceZoneId { get; set; }

            /// <summary>
            /// <para>The initial destination region of the replication pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("StandbyRegion")]
            [Validation(Required=false)]
            public string StandbyRegion { get; set; }

            /// <summary>
            /// <para>The initial destination zone of the replication pair.</para>
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
            /// <item><description><para>invalid: The replication pair is invalid. This status indicates that the replication pair is not working correctly.</para>
            /// </description></item>
            /// <item><description><para>creating: The replication pair is being created.</para>
            /// </description></item>
            /// <item><description><para>created: The replication pair is created.</para>
            /// </description></item>
            /// <item><description><para>create_failed: The replication pair failed to be created.</para>
            /// </description></item>
            /// <item><description><para>initial_syncing: The replication pair is in the initial synchronization state. After a replication pair is created and started, it enters this state during the first asynchronous replication of data from the primary disk to the secondary disk.</para>
            /// </description></item>
            /// <item><description><para>manual_syncing: The replication pair is being manually synchronized. After the manual synchronization is complete, the replication pair returns to the stopped state. If it is the first one-time synchronization, the status is also manual_syncing.</para>
            /// </description></item>
            /// <item><description><para>syncing: The replication pair is synchronizing data. The replication pair is in this state when data is asynchronously replicated from the primary disk to the secondary disk for a second or subsequent time.</para>
            /// </description></item>
            /// <item><description><para>normal: The replication pair is in the normal state. The replication pair enters this state when data replication is complete in the current replication cycle.</para>
            /// </description></item>
            /// <item><description><para>stopping: The replication pair is being stopped.</para>
            /// </description></item>
            /// <item><description><para>stopped: The replication pair is stopped.</para>
            /// </description></item>
            /// <item><description><para>stop_failed: The replication pair failed to be stopped.</para>
            /// </description></item>
            /// <item><description><para>failovering: A failover is in progress.</para>
            /// </description></item>
            /// <item><description><para>failovered: The failover is complete.</para>
            /// </description></item>
            /// <item><description><para>failover_failed: The failover failed.</para>
            /// </description></item>
            /// <item><description><para>reprotecting: A reverse replication is in progress.</para>
            /// </description></item>
            /// <item><description><para>reprotect_failed: The reverse replication failed.</para>
            /// </description></item>
            /// <item><description><para>deleting: The replication pair is being deleted.</para>
            /// </description></item>
            /// <item><description><para>delete_failed: The replication pair failed to be deleted.</para>
            /// </description></item>
            /// <item><description><para>deleted: The replication pair is deleted.</para>
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
            /// <para>The status message of the replication pair. This parameter is returned when the Status is <c>invalid</c> or <c>create_failed</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PrePayOrderExpired: The subscription replication pair has expired.</para>
            /// </description></item>
            /// <item><description><para>PostPayOrderCeaseService: The service for the pay-as-you-go replication pair is suspended, usually due to an overdue payment.</para>
            /// </description></item>
            /// <item><description><para>DeviceRemoved: The primary or secondary disk is deleted.</para>
            /// </description></item>
            /// <item><description><para>DeviceKeyChanged: The <c>DeviceKey</c> mapping of the primary or secondary disk has changed.</para>
            /// </description></item>
            /// <item><description><para>DeviceSizeChanged: The <c>DeviceSize</c> of the primary or secondary disk has changed.</para>
            /// </description></item>
            /// <item><description><para>OperationDenied.QuotaExceed: The number of created replication pairs exceeds the quota.</para>
            /// </description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAA478A0-BEE6-1D42-BEB6-A9CFEAD6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
