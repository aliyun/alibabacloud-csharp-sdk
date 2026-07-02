// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class EnableAdditionalBandwidthRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables auto-payment. This is the default. Ensure that your account has a sufficient balance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables auto-payment. You must manually complete the payment.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><para><b>true</b>: Enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables auto-renewal. This is the default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period, in months. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, <b>5</b>, <b>6</b>, <b>7</b>, <b>8</b>, <b>9</b>, <b>12</b>, <b>24</b>, <b>36</b>, and <b>60</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required only when <b>AutoRenew</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>After you set this parameter, you cannot query its value by calling API operations. To check this setting, go to the console. In the top navigation bar, choose <b>Billing</b> &gt; <b>Renewal Management</b>. Then, in the <b>Instance ID</b> field, enter the instance ID followed by the <c>-bw</c> suffix (for example, r-bp1zxszhcgatnx\<em>\</em>\<em>\</em>-bw).</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        [NameInMap("BandWidthBurst")]
        [Validation(Required=false)]
        public bool? BandWidthBurst { get; set; }

        /// <summary>
        /// <para>The amount of bandwidth to add, in MB/s. The value must be an integer greater than or equal to <b>0</b>. The maximum value is six times the default bandwidth of the instance type or a single data shard, with an upper limit of 192 MB/s. For example, if the default bandwidth of an instance is 10 MB/s, the valid values for this parameter are <b>0</b> to <b>60</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/473782.html">DescribeRoleZoneInfo</a> operation and check the value of the <b>DefaultBandWidth</b> parameter in the response to get the default maximum bandwidth. For more information about instance types, see <a href="https://help.aliyun.com/document_detail/26350.html">Instance types</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specified multiple data shard IDs for the <b>NodeId</b> parameter, the bandwidth values that you specify for this parameter must correspond to the order of the data shard IDs. Separate multiple bandwidth values with commas (,).</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The billing method for the additional bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PrePaid</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>PostPaid</b>: pay-as-you-go. This is the only supported billing method.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data shard. You can call the <a href="https://help.aliyun.com/document_detail/473786.html">DescribeLogicInstanceTopology</a> operation to query data shard IDs. Separate multiple data shard IDs with commas (,). You can also set this parameter to <b>All</b> to specify all data shards.</para>
        /// <remarks>
        /// <para>This parameter is required only when the instance uses the <a href="https://help.aliyun.com/document_detail/52228.html">cluster architecture</a> or the <a href="https://help.aliyun.com/document_detail/62870.html">read/write splitting architecture</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The subscription duration, in days. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>7</b>, <b>14</b>, <b>30</b>, <b>60</b>, <b>90</b>, <b>180</b>, <b>365</b>, <b>730</b>, <b>1095</b>, and <b>1825</b>.</para>
        /// <remarks>
        /// <para>To continue using the purchased bandwidth, you must call the <a href="https://help.aliyun.com/document_detail/473804.html">RenewAdditionalBandwidth</a> operation to renew the bandwidth before it expires.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("OrderTimeLength")]
        [Validation(Required=false)]
        public string OrderTimeLength { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// <para>The source of the call. This parameter is used for internal maintenance. Do not specify it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

    }

}
