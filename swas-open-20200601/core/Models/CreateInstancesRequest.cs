// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The number of simple application servers that you want to create. Valid values: 1 to 20.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. This parameter is required only when you set <c>AutoRenew</c> to true. Unit: month. Valid values: 1, 3, 6, 12, 24, and 36.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The billing method of the simple application servers. Set the value to PrePaid, which indicates the subscription billing method.</para>
        /// <para>Default value: PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The value of <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The size of the data disk that is attached to the server. Unit: GB. Valid values: 0 to 16380. The value must be an integral multiple of 20.</para>
        /// <list type="bullet">
        /// <item><description>A value of 0 indicates that no data disk is attached.</description></item>
        /// <item><description>If the disk included in the specified plan is a standard SSD, the data disk must be 20 GB or larger in size.</description></item>
        /// </list>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public long? DataDiskSize { get; set; }

        /// <summary>
        /// <para>The image ID. You can call the <a href="https://help.aliyun.com/document_detail/189313.html">ListImages</a> operation to query the available images in the specified region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2c9c365024a44369c9b955a998a****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The subscription period of the servers. Unit: months. Valid values: 1, 3, 6, 12, 24, and 36.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The plan ID. You can call the <a href="https://help.aliyun.com/document_detail/189314.html">ListPlans</a> operation to query all plans provided by Simple Application Server in the specified region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>swas.s1.c1m1s40b3t05</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The region ID of the simple application servers. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
