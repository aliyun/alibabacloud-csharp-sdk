// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSecretsResponseBody : TeaModel {
        /// <summary>
        /// The number of access credentials.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried access credentials.
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public ListSecretsResponseBodySecrets Secrets { get; set; }
        public class ListSecretsResponseBodySecrets : TeaModel {
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodySecretsSecrets> Secrets { get; set; }
            public class ListSecretsResponseBodySecretsSecrets : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The description of the access credential.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the access credential for the created Data API account. Format: `acs:gpdb:{{region}}:{{accountId}}:secret/{{secretName}}-{{32 digits random string}`.
                /// </summary>
                [NameInMap("SecretArn")]
                [Validation(Required=false)]
                public string SecretArn { get; set; }

                /// <summary>
                /// The name of the access credential.
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

                /// <summary>
                /// The name of the database account.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// The status of the operation. Valid values:
        /// 
        /// *   **success**
        /// *   **fail**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
