// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ModifyDiskReplicaPairRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth for async replication, in Kbps.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a value for this parameter from your client. Make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>Specifies whether to enable replication time control (RTC). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: Disables RTC.</para>
        /// </description></item>
        /// <item><description><para>true: Enables RTC.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If a replication pair is part of a replication group, its RTC setting is the same as the setting of the group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRtc")]
        [Validation(Required=false)]
        public bool? EnableRtc { get; set; }

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
        /// <para>The recovery point objective (RPO) of the replication pair-consistent group. Unit: seconds. Currently, only a value of 900 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        /// <summary>
        /// <para>The region ID of the primary or secondary disk in the replication pair. You can call <a href="https://help.aliyun.com/document_detail/354276.html">DescribeRegions</a> to query the regions that support async replication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the replication pair.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pair-cn-dsa****</para>
        /// </summary>
        [NameInMap("ReplicaPairId")]
        [Validation(Required=false)]
        public string ReplicaPairId { get; set; }

    }

}
