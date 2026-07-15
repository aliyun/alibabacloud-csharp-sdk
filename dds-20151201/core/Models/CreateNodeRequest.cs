// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateNodeRequest : TeaModel {
        /// <summary>
        /// <para>The account name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Starts with a lowercase letter.</para>
        /// </description></item>
        /// <item><description><para>Consists of lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Is 4 to 16 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Keywords of ApsaraDB for MongoDB cannot be used as the account name.</para>
        /// </description></item>
        /// <item><description><para>The account has read-only permissions.</para>
        /// </description></item>
        /// <item><description><para>You must set the account name and password only when you enable a public endpoint for a shard node for the first time. These parameters are not required on subsequent requests.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ceshi</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password for the account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Must contain characters from at least three of the following categories: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>Special characters include <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// </description></item>
        /// <item><description><para>Is 8 to 32 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>ApsaraDB for MongoDB does not support resetting the account password for shard nodes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123+abc</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: (Default) Enables automatic payment. Ensure that your account has a sufficient balance.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Disables automatic payment. In this case, you must manually pay for the node. To do so, log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Billing</b> &gt; <b>Billing Management</b>. In the left-side navigation pane, choose <b>Subscription Orders</b> &gt; <b>My Orders</b>. On the <b>Product Orders</b> tab, find the order and complete the payment.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Disables automatic payment. In this case, you must manually pay for the node. To do so, log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Billing</b> &gt; <b>Billing Management</b>. In the left-side navigation pane, click <b>Order Management</b>. On the <b>Product Orders</b> page, find the order and complete the payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Additional business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. The token must be unique across requests, contain only ASCII characters, and not exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>default</b> or <b>null</b>: (Default) An available coupon is automatically applied.</para>
        /// </description></item>
        /// <item><description><para><b>youhuiquan_promotion_option_id_for_blank</b>: No coupon is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The ID of the sharded cluster instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp11501cd7b5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance type of the shard or mongos node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.shard.mid</para>
        /// </summary>
        [NameInMap("NodeClass")]
        [Validation(Required=false)]
        public string NodeClass { get; set; }

        /// <summary>
        /// <para>The storage space of the node. Unit: GB.</para>
        /// <para>The valid values of this parameter vary based on the storage type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
        /// <remarks>
        /// <para>This parameter is required when the node type is <b>shard</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("NodeStorage")]
        [Validation(Required=false)]
        public int? NodeStorage { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>shard</b>: A shard node.</para>
        /// </description></item>
        /// <item><description><para><b>mongos</b>: A mongos node.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shard</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes in a shard node.</para>
        /// <para>Valid values: <b>0</b> to <b>5</b>. The default value is <b>0</b>.</para>
        /// <remarks>
        /// <para>This parameter is available only on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public int? ReadonlyReplicas { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SearchDBInstanceClass")]
        [Validation(Required=false)]
        public string SearchDBInstanceClass { get; set; }

        [NameInMap("SearchNodeCount")]
        [Validation(Required=false)]
        public int? SearchNodeCount { get; set; }

        [NameInMap("SearchStorage")]
        [Validation(Required=false)]
        public int? SearchStorage { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable a public endpoint for the shard node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables a public endpoint for the shard node.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: (Default) Does not enable a public endpoint for the shard node.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShardDirect")]
        [Validation(Required=false)]
        public bool? ShardDirect { get; set; }

    }

}
