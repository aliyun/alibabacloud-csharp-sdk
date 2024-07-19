// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSecretsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public ListSecretsResponseBodySecrets Secrets { get; set; }
        public class ListSecretsResponseBodySecrets : TeaModel {
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodySecretsSecrets> Secrets { get; set; }
            public class ListSecretsResponseBodySecretsSecrets : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SecretArn")]
                [Validation(Required=false)]
                public string SecretArn { get; set; }

                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
