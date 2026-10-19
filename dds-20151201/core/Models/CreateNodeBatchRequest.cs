// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateNodeBatchRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a lowercase letter.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>The name must be 4 to 16 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ApsaraDB for MongoDB does not support using keywords as account names.</description></item>
        /// <item><description>The permissions of the account are fixed to read-only.</description></item>
        /// <item><description>When you apply for a direct connection endpoint for a shard node for the first time, you must set the account name and password. You do not need to set them again for subsequent applications.</description></item>
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
        /// <para>ApsaraDB for MongoDB does not support resetting the password of the account for a shard node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PassWord123</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: (Default) Automatic payment is enabled. Make sure that your account has sufficient balance.</description></item>
        /// <item><description><b>false</b>: Manual payment is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/85052.html">Manually renew a subscription instance</a>.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and can be up to 64 ASCII characters in length. The value cannot contain non-ASCII characters.</para>
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
        /// <item><description><b>default</b> or <b>null</b>: (Default) A coupon is used.</description></item>
        /// <item><description><b>youhuiquan_promotion_option_id_for_blank</b>: No coupon is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp18b0934e70****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The source of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OpenApi</b>: OpenAPI.</description></item>
        /// <item><description><b>mongo_buy</b>: The console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OpenApi</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The specifications of the Mongos or shard nodes to be added. For more information about the specifications, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance specifications</a>.</para>
        /// <remarks>
        /// <para>By default, a sharded cluster instance supports up to 32 Mongos nodes and 32 shard nodes.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Shards&quot;:[{&quot;DBInstanceClass&quot;:&quot;mdb.shard.4x.large.d&quot;,&quot;Storage&quot;:20}]}</para>
        /// </summary>
        [NameInMap("NodesInfo")]
        [Validation(Required=false)]
        public string NodesInfo { get; set; }

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

        /// <summary>
        /// <para>Specifies whether to apply for a direct connection endpoint for the shard node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Applies for a direct connection endpoint for the shard node.</description></item>
        /// <item><description><b>false</b>: (Default) Does not apply for a direct connection endpoint for the shard node.</description></item>
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
