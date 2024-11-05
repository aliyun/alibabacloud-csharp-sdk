// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateNodeRequest : TeaModel {
        /// <summary>
        /// <para>The username of the account. The username must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The username starts with a lowercase letter.</description></item>
        /// <item><description>The username can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>The username must be 4 to 16 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Keywords cannot be used as accounts.</para>
        /// </description></item>
        /// <item><description><para>This account is granted the read-only permissions.</para>
        /// </description></item>
        /// <item><description><para>The username and password need to be set if you apply for an endpoint for the shard node for the first time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ceshi</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The password contains at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>These special characters include ! @ # $ % ^ &amp; \* ( ) _ + - =</description></item>
        /// <item><description>The password is 8 to 32 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para> ApsaraDB for MongoDB does not allow you to reset the password of an account.</para>
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
        /// <item><description><b>true</b> (default): enables automatic payment. Make sure that you have sufficient balance within your account.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. You can perform the following operations to pay for the instance: Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Expenses</b> &gt; Orders. On the <b>Orders</b> page, find the order that you want to pay for and complete the payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required only when the billing method of the instance is subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The business information. This is an additional parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The coupon code. Default value: <b>youhuiquan_promotion_option_id_for_blank</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
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
        /// <para>The instance type of the shard or mongos node. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.shard.mid</para>
        /// </summary>
        [NameInMap("NodeClass")]
        [Validation(Required=false)]
        public string NodeClass { get; set; }

        /// <summary>
        /// <para>The disk capacity of the node. Unit: GB.</para>
        /// <para>Valid values: <b>10</b> to <b>2000</b>. The value must be a multiple of 10.</para>
        /// <remarks>
        /// <para> This parameter is required only when the NodeType parameter is set to <b>shard</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NodeStorage")]
        [Validation(Required=false)]
        public int? NodeStorage { get; set; }

        /// <summary>
        /// <para>The type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>shard</b>: shard node</description></item>
        /// <item><description><b>mongos</b>: mongos node</description></item>
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
        /// <para>Valid values: <b>0</b>, 1, 2, 3, 4, and <b>5</b>. Default value: <b>0</b>.</para>
        /// <remarks>
        /// <para> This parameter is available only for ApsaraDB for MongoDB instances that are purchased on the China site (aliyun.com).</para>
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

        /// <summary>
        /// <para>Specifies whether to apply for an endpoint for the shard node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: applies for an endpoint for the shard node.</description></item>
        /// <item><description><b>false</b> (default): does not apply for an endpoint for the shard node.</description></item>
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
