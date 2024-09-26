// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupPriceRequest : TeaModel {
        /// <summary>
        /// <para>The computing power type. A value of economy specifies economic instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>economy</para>
        /// </summary>
        [NameInMap("ComputeCategory")]
        [Validation(Required=false)]
        public string ComputeCategory { get; set; }

        /// <summary>
        /// <para>The number of vCPUs. For information about the vCPU and memory specifications that are supported by Elastic Container Instance, see <a href="https://help.aliyun.com/document_detail/114662.html">vCPU and memory specifications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The storage size of the temporary storage space. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// <para>The instance type of the Elastic Compute Service (ECS) instance that is used to create the elastic container instance. For information about the ECS instance types that are supported by Elastic Container Instance, see <a href="https://help.aliyun.com/document_detail/114664.html">ECS instance types that are supported by Elastic Container Instance</a>.</para>
        /// <remarks>
        /// <para>If you specify this parameter, the specified specifications of vCPUs and memory are ignored. Only the price of the ECS instance type is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The size of the memory. Unit: GiB. For information about the vCPU and memory specifications that are supported by Elastic Container Instance, see <a href="https://help.aliyun.com/document_detail/114662.html">vCPU and memory specifications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/146965.html">DescribeRegions</a> operation to query the most recent region and zone list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The protection period of the preemptible instance. Unit: hours. Default value: 1. The value of 0 indicates no protection period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the preemptible elastic container instance. The value can contain up to three decimal places. If you set SpotStrategy to SpotWithPriceLimit, you must specify SpotPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding policy for the elastic container instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/146965.html">DescribeRegions</a> operation to query the most recent region and zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
