// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretList")]
        [Validation(Required=false)]
        public ListSecretsResponseBodySecretList SecretList { get; set; }
        public class ListSecretsResponseBodySecretList : TeaModel {
            [NameInMap("Secret")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodySecretListSecret> Secret { get; set; }
            public class ListSecretsResponseBodySecretListSecret : TeaModel {
                public string UpdateTime { get; set; }
                public string CreateTime { get; set; }
                public string SecretName { get; set; }
                public ListSecretsResponseBodySecretListSecretTags Tags { get; set; }
                public class ListSecretsResponseBodySecretListSecretTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListSecretsResponseBodySecretListSecretTagsTag> Tag { get; set; }
                    public class ListSecretsResponseBodySecretListSecretTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
                public string SecretType { get; set; }
                public string PlannedDeleteTime { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
