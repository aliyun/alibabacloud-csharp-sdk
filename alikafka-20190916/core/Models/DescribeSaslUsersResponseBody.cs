// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeSaslUsersResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The Simple Authentication and Security Layer (SASL) users.
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
                /// The encryption method.
                /// 
                /// >  This field is available only for serverless ApsaraMQ for Kafka V3 instances.
                /// </summary>
                [NameInMap("Mechanism")]
                [Validation(Required=false)]
                public string Mechanism { get; set; }

                /// <summary>
                /// The password.
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// The type of the SASL user. Valid values:
                /// 
                /// *   **plain**: a simple mechanism that uses usernames and passwords to verify user identities. ApsaraMQ for Kafka provides an improved PLAIN mechanism that allows you to dynamically add SASL users without the need to restart an instance.
                /// *   **SCRAM**: a mechanism that uses usernames and passwords to verify user identities. Compared with the PLAIN mechanism, this mechanism provides better security protection. ApsaraMQ for Kafka uses the SCRAM-SHA-256 algorithm.
                /// *   **LDAP**: This value is available only for the SASL users of ApsaraMQ for Confluent instances.
                /// 
                /// Default value: **plain**.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
