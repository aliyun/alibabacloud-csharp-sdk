// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateSaslUserRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_pre-cn-v0h1cng0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SCRAM-SHA-512 (default)</para>
        /// </description></item>
        /// <item><description><para>SCRAM-SHA-256</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for Serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SCRAM-SHA-256</para>
        /// </summary>
        [NameInMap("Mechanism")]
        [Validation(Required=false)]
        public string Mechanism { get; set; }

        /// <summary>
        /// <para>The password.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12***</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The SASL mechanism. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>plain: a simple username and password authentication mechanism. Message Queue for Apache Kafka optimizes the PLAIN mechanism to support the dynamic creation of SASL users without the need to restart the instance.</para>
        /// </description></item>
        /// <item><description><para>scram: a username and password authentication mechanism that provides higher security than the PLAIN mechanism. Message Queue for Apache Kafka uses Salted Challenge Response Authentication Mechanism (SCRAM)-SHA-256.</para>
        /// </description></item>
        /// <item><description><para>LDAP: This value is applicable only when you create users for Confluent instances.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: plain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plain</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The username.</para>
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
