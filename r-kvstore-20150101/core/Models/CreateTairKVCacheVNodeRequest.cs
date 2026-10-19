// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateTairKVCacheVNodeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Set the value to <b>true</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b> (default): disables auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal epoch. Unit: months. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>6</b>, and <b>12</b>.</para>
        /// <remarks>
        /// <para>This parameter is required when the <b>AutoRenew</b> parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a voucher. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses a voucher.</description></item>
        /// <item><description><b>false</b> (default): does not use a voucher.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The extended information, such as the campaign ID and business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription. If you set this parameter to PrePaid, you must also specify the <b>Period</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must ensure that the token is unique among different requests. The token is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of compute units. Currently, only one compute unit is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ComputeUnitNum")]
        [Validation(Required=false)]
        public int? ComputeUnitNum { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the instance creation request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the instance. The system checks the request parameters, request format, service limits, and available resources. If the request fails the dry run, the system returns an error. If the request passes the dry run, the system returns the <c>DryRunOperation</c> error code.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the dry run, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("ElasticTimeRange")]
        [Validation(Required=false)]
        public string ElasticTimeRange { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kvcache.cu.g4b.2</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the new instance. The name must be 2 to 80 characters in length and start with a letter or a Chinese character. It cannot contain spaces or the following special characters: <c>@/:=”&lt;&gt;{[]}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vnodetest</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: months. Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>.</para>
        /// <remarks>
        /// <para>This parameter is required when the <b>ChargeType</b> parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID. Specifies the region where you want to create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the destination resource group.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can invoke the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation or go to the console to obtain the resource group ID list. For related operations, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</description></item>
        /// <item><description>Before you change the resource group to which the instance belongs, you can invoke the <a href="https://help.aliyun.com/document_detail/158866.html">ListResources</a> operation to view the current resource group of the instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The tag information of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTairKVCacheVNodeRequestTag> Tag { get; set; }
        public class CreateTairKVCacheVNodeRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. A tag key and a tag value form a tag key-value pair.</para>
            /// <remarks>
            /// <para>You can specify up to 5 tag key-value pairs at a time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>value1_test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <remarks>
            /// <para><b>N</b> specifies the sequence number of the tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>key1_test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fixed</para>
        /// </summary>
        [NameInMap("VNodeType")]
        [Validation(Required=false)]
        public string VNodeType { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the instance. The vSwitch must belong to the VPC associated with the specified VCluster virtual cluster. You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation of the VPC API to query the vSwitch ID.</para>
        /// <remarks>
        /// <para>The zone of the vSwitch must be the same as the zone of the instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The instance ID of the VCluster virtual cluster where the VNode resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tk-2ze4bba3c8fe****</para>
        /// </summary>
        [NameInMap("VkName")]
        [Validation(Required=false)]
        public string VkName { get; set; }

        /// <summary>
        /// <para>The zone ID. Specifies the zone where you want to create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
