// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDiskReplicaPairRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth for asynchronous data replication between disks. The unit is Kbps. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>10240</para>
        /// </description></item>
        /// <item><description><para>20480</para>
        /// </description></item>
        /// <item><description><para>51200</para>
        /// </description></item>
        /// <item><description><para>102400</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 10240.
        /// When ChargeType is set to POSTPAY, you cannot specify this parameter. The system uses a value of 0, which means that the bandwidth is dynamically allocated based on data writes.</para>
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
        /// <item><description><para>PREPAY: subscription.</para>
        /// </description></item>
        /// <item><description><para>POSTPAY: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: POSTPAY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a value from your client to make sure that the value is unique among different requests. The ClientToken parameter can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the replication pair. The description must be 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the destination disk (secondary disk).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-sa1f82p58p1tdw9g****</para>
        /// </summary>
        [NameInMap("DestinationDiskId")]
        [Validation(Required=false)]
        public string DestinationDiskId { get; set; }

        /// <summary>
        /// <para>The region ID of the destination disk (secondary disk). You can call the <a href="https://help.aliyun.com/document_detail/354276.html">DescribeRegions</a> operation to query the regions that support asynchronous replication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        /// <summary>
        /// <para>The zone ID of the destination disk (secondary disk).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("DestinationZoneId")]
        [Validation(Required=false)]
        public string DestinationZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the source disk (primary disk).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-iq80sgp4d0xbk24q****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable replication time control (RTC). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: Disables RTC.</para>
        /// </description></item>
        /// <item><description><para>true: Enables RTC.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If the replication pair is added to a replication group, the setting of this parameter is the same as that of the replication group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRtc")]
        [Validation(Required=false)]
        public bool? EnableRtc { get; set; }

        /// <summary>
        /// <para>The name of the replication pair. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestReplicaPair</para>
        /// </summary>
        [NameInMap("PairName")]
        [Validation(Required=false)]
        public string PairName { get; set; }

        /// <summary>
        /// <para>The subscription duration of the replication pair. This parameter is required when <c>ChargeType</c> is set to PREPAY. The unit of the duration is specified by <c>PeriodUnit</c>. Valid values: 1, 2, 3, 6, 12, 24, 36, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The recovery point objective (RPO) of the replication pair. The unit is seconds. Currently, only 900 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        /// <summary>
        /// <para>The region ID of the replication pair.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the replication pair belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmvs****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The zone ID of the source disk (primary disk).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-f</para>
        /// </summary>
        [NameInMap("SourceZoneId")]
        [Validation(Required=false)]
        public string SourceZoneId { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskReplicaPairRequestTag> Tag { get; set; }
        public class CreateDiskReplicaPairRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
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
