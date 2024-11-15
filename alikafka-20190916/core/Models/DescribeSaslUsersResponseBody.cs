// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeSaslUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3B3592-5994-4F65-A61E-E62A77A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Simple Authentication and Security Layer (SASL) users.</para>
        /// </summary>
        [NameInMap("SaslUserList")]
        [Validation(Required=false)]
        public DescribeSaslUsersResponseBodySaslUserList SaslUserList { get; set; }
        public class DescribeSaslUsersResponseBodySaslUserList : TeaModel {
            [NameInMap("SaslUserVO")]
            [Validation(Required=false)]
            public List<DescribeSaslUsersResponseBodySaslUserListSaslUserVO> SaslUserVO { get; set; }
            public class DescribeSaslUsersResponseBodySaslUserListSaslUserVO : TeaModel {
                /// <summary>
                /// <para>The encryption method.</para>
                /// <remarks>
                /// <para> This field is available only for serverless ApsaraMQ for Kafka V3 instances.</para>
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
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The type of the SASL user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>plain</b>: a simple mechanism that uses usernames and passwords to verify user identities. ApsaraMQ for Kafka provides an improved PLAIN mechanism that allows you to dynamically add SASL users without the need to restart an instance.</description></item>
                /// <item><description><b>SCRAM</b>: a mechanism that uses usernames and passwords to verify user identities. Compared with the PLAIN mechanism, this mechanism provides better security protection. ApsaraMQ for Kafka uses the SCRAM-SHA-256 algorithm.</description></item>
                /// <item><description><b>LDAP</b>: This value is available only for the SASL users of ApsaraMQ for Confluent instances.</description></item>
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
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test12***</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
