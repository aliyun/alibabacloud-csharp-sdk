// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateSaslUserRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
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
        /// <item><description>SCRAM-SHA-512 (default)</description></item>
        /// <item><description>SCRAM-SHA-256</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for ApsaraMQ for Kafka serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SCRAM-SHA-256</para>
        /// </summary>
        [NameInMap("Mechanism")]
        [Validation(Required=false)]
        public string Mechanism { get; set; }

        /// <summary>
        /// <para>The password of the SASL user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12***</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the Simple Authentication and Security Layer (SASL) user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>plain</b>: a simple mechanism that uses usernames and passwords to verify user identities. ApsaraMQ for Kafka provides an improved PLAIN mechanism that allows you to dynamically add SASL users without the need to restart an instance.</description></item>
        /// <item><description><b>SCRAM</b>: a mechanism that uses usernames and passwords to verify user identities. Compared with the PLAIN mechanism, this mechanism provides better security protection. ApsaraMQ for Kafka uses the SCRAM-SHA-256 algorithm.</description></item>
        /// <item><description><b>LDAP</b>: This value is available only for the SASL users of ApsaraMQ for Confluent instances.</description></item>
        /// </list>
        /// <para>Default value: <b>plain</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plain</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The name of the SASL user.</para>
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
