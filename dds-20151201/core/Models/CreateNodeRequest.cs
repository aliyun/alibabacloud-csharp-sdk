// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateNodeRequest : TeaModel {
        /// <summary>
        /// <para>The username. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The username must start with a lowercase letter.</description></item>
        /// <item><description>The username can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>The username must be 4 to 16 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ApsaraDB for MongoDB does not support using keywords as usernames.</description></item>
        /// <item><description>The permissions of the account are fixed to read-only.</description></item>
        /// <item><description>When you apply for a direct connection endpoint for the shard node for the first time, you must set the username and password. You do not need to set them again for subsequent applications.</description></item>
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
        /// <para>The password of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Special characters include !@#$%^&amp;*()_+-=.</description></item>
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>ApsaraDB for MongoDB does not support resetting the password of the account for the shard node.</para>
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
        /// <item><description><b>true</b>: enables automatic payment. This is the default value. Make sure that your account has sufficient balance.
        /// &lt;props=&quot;china&quot;&gt;- <b>false</b>: disables automatic payment. You can log on to the ApsaraDB for MongoDB console, choose <b>Expenses</b> &gt; <b>Expenses and Costs</b> in the upper-right corner, choose <b>Subscription Orders</b> &gt; <b>My Orders</b> in the left-side navigation pane, and then pay for the order on the <b>Orders</b> tab.
        /// &lt;props=&quot;intl&quot;&gt;- <b>false</b>: disables automatic payment. You can log on to the ApsaraDB for MongoDB console, choose <b>Expenses</b> &gt; <b>Expenses and Costs</b> in the upper-right corner, click <b>Order Management</b> in the left-side navigation pane, and then pay for the order on the <b>Orders</b> page.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the billing method is subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The additional parameter that contains business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
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
        /// <item><description><b>default</b> or <b>null</b>: uses a coupon. This is the default value.</description></item>
        /// <item><description><b>youhuiquan_promotion_option_id_for_blank</b>: does not use a coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance ID of the sharded cluster instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp11501cd7b5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance type of the shard node or mongos node. For more information about instance types, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.shard.mid</para>
        /// </summary>
        [NameInMap("NodeClass")]
        [Validation(Required=false)]
        public string NodeClass { get; set; }

        /// <summary>
        /// <para>The disk space of the node. Unit: GB.</para>
        /// <para>The valid values vary based on the storage type. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
        /// <remarks>
        /// <para>This parameter is required when the node type is <b>Shard</b>.</para>
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
        /// <item><description><b>shard</b>: shard node.</description></item>
        /// <item><description><b>mongos</b>: mongos node.</description></item>
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
        /// <para>The number of read-only nodes in the shard node.</para>
        /// <para>Valid values: <b>0</b> to <b>5</b>. Default value: <b>0</b>.</para>
        /// <remarks>
        /// <para>This parameter is supported only on the Alibaba Cloud China site.</para>
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
        /// <para>Specifies whether to apply for a direct connection endpoint for the shard node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: applies for a direct connection endpoint for the shard node.</description></item>
        /// <item><description><b>false</b>: does not apply for a direct connection endpoint for the shard node. This is the default value.</description></item>
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
