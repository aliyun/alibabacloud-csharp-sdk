// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateNodeBatchRequest : TeaModel {
        /// <summary>
        /// <para>The username of the account. The username must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The username starts with a lowercase letter.</para>
        /// </description></item>
        /// <item><description><para>The username contains lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The username is 4 to 16 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Keywords cannot be used as account usernames.</para>
        /// </description></item>
        /// <item><description><para>The permissions of this account are fixed at read-only.</para>
        /// </description></item>
        /// <item><description><para>The username and password are required to be set only when you apply for an endpoint for the shard node for the first time.</para>
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
        /// <para>The password of the account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The password contains at least three of the following character types: uppercase letters, lowercase letters, digits, and specific special characters.</para>
        /// </description></item>
        /// <item><description><para>These special characters include ! @ # $ % ^ &amp; \* ( ) _ + - =</para>
        /// </description></item>
        /// <item><description><para>The password is 8 to 32 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The account password of the shard node cannot be reset.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PassWord123</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables automatic payment. Make sure that you have sufficient balance within your account.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables automatic payment. In this case, you must manually pay for the instance. You can perform the following operations to pay for the instance: Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Expenses</b> &gt; <b>Orders</b>. On the Orders page, find the order and complete the payment.</para>
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
        /// <para>The business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Default value: null. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>default</b> or <b>null</b>: uses coupons.</para>
        /// </description></item>
        /// <item><description><para><b>youhuiquan_promotion_option_id_for_blank</b>: does not use coupons.</para>
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
        /// <para>The ID of the instance for which you want to add nodes.</para>
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
        /// <item><description><para><b>OpenApi</b>: ApsaraDB for MongoDB API</para>
        /// </description></item>
        /// <item><description><para><b>mongo_buy</b>: ApsaraDB for MongoDB console</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OpenApi</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The specifications of the mongos or shard node that you want to add. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// <remarks>
        /// <para>Up to 32 mongos or shard nodes are supported for each sharded cluster instance.</para>
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
        /// <para>Specifies whether to apply for an endpoint for the shard node. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: applies for an endpoint for the shard node.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not apply for an endpoint for the shard node.</para>
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
