// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DeleteSaslUserRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_pre-cn-v0h1cng0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SCRAM-SHA-512 (selected by default)</para>
        /// </description></item>
        /// <item><description><para>SCRAM-SHA-256</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is only supported for Serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SCRAM-SHA-256</para>
        /// </summary>
        [NameInMap("Mechanism")]
        [Validation(Required=false)]
        public string Mechanism { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>plain</b>: A simple username and password verification mechanism. MSMQ optimizes the PLAIN mechanism to support adding SASL users dynamically without restarting the instance.</para>
        /// </description></item>
        /// <item><description><para><b>scram</b>: A username and password verification mechanism with higher security than PLAIN. MSMQ uses SCRAM-SHA-256.</para>
        /// </description></item>
        /// <item><description><para><b>LDAP</b>: Only applicable for deleting Confluent instance users.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>plain</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scram</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Username.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test***</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
