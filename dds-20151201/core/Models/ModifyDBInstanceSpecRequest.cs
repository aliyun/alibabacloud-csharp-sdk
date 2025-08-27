// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): enables automatic payment. Make sure that your Alibaba Cloud account has a sufficient balance.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. You can perform the following operations to pay for the instance: Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Expenses</b> &gt; <b>User Center</b>. In the left-side navigation pane, choose <b>Order Management</b> &gt; <b>Order</b>. On the <b>Orders for Services</b> tab, find the order and pay for the order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The coupon code. Default value: <c>youhuiquan_promotion_option_id_for_blank</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>. You can also call the <a href="https://help.aliyun.com/document_detail/149719.html">DescribeAvailableResource</a> operation to view instance types.</para>
        /// <remarks>
        /// <para>You must specify at least one of the DBInstanceClass and <b>DBInstanceStorage</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds.sn4.xlarge.1</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1ea17b41ab****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. Valid values: 10 to 3000. The value must be a multiple of 10. Unit: GB. The values that can be specified for this parameter are subject to the instance types. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify at least one of the DBInstanceStorage and <b>DBInstanceClass</b> parameters.</para>
        /// </description></item>
        /// <item><description><para>Storage capacity can be scaled down only for pay-as-you-go replica set instances. The new storage capacity you specify must be greater than the used storage capacity.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public string DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The time when the changed configurations take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b> (default): The configurations immediately take effect.</description></item>
        /// <item><description><b>MaintainTime</b>: The configurations take effect during the maintenance window of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The additional parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>async</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>sync</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The type of the configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b></description></item>
        /// <item><description><b>DOWNGRADE</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter can be configured only when the billing method of the instance is subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes. Valid values: <b>0</b> to <b>5</b>.</para>
        /// <para>If your instance has only <b>Classic Network</b> and <b>VPC</b> endpoints, you must apply for a public endpoint or release the classic network endpoint for the instance before you can change the <b>Read-only Nodes</b> value.</para>
        /// <remarks>
        /// <para>You can go to the <b>Database Connections</b> page to view the types of networks that are enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// <para>The number of nodes in the instance.</para>
        /// <list type="bullet">
        /// <item><description>Valid values for replica set instances: <b>3</b>, <b>5</b>, and <b>7</b></description></item>
        /// <item><description>Valid values for standalone instances: <b>1</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is not required for a serverless instance which is only available on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TargetHiddenZoneId")]
        [Validation(Required=false)]
        public string TargetHiddenZoneId { get; set; }

        [NameInMap("TargetSecondaryZoneId")]
        [Validation(Required=false)]
        public string TargetSecondaryZoneId { get; set; }

        [NameInMap("TargetVswitchId")]
        [Validation(Required=false)]
        public string TargetVswitchId { get; set; }

        [NameInMap("TargetZoneId")]
        [Validation(Required=false)]
        public string TargetZoneId { get; set; }

    }

}
