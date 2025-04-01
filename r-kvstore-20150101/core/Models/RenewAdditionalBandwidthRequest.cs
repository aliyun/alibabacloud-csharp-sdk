// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RenewAdditionalBandwidthRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. If automatic payment is disabled, you must perform the following steps to complete the payment in the Tair (Redis OSS-compatible) console: In the top navigation bar, choose <b>Expenses</b> &gt; <b>Renewal Management</b>. In the left-side navigation pane, click <b>Orders</b>. On the <b>Orders</b> page, find the order and complete the payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The ID of the coupon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to query the ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The validity period of the bandwidth that you purchase. Unit: days. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>7</b>, <b>14</b>, <b>30</b>, <b>60</b>, <b>90</b>, <b>180</b>, <b>365</b>, <b>730</b>, <b>1095</b>, and <b>1825</b>.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The source of the operation. This parameter is used only for internal maintenance. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

    }

}
