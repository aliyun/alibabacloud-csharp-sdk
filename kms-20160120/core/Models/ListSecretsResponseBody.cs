// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of returned secrets.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The list of secrets.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the secret was updated.
        /// </summary>
        [NameInMap("SecretList")]
        [Validation(Required=false)]
        public ListSecretsResponseBodySecretList SecretList { get; set; }
        public class ListSecretsResponseBodySecretList : TeaModel {
            [NameInMap("Secret")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodySecretListSecret> Secret { get; set; }
            public class ListSecretsResponseBodySecretListSecret : TeaModel {
                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The resource tags of the secret.
                /// 
                /// This parameter is not returned if you set the FetchTags parameter to false or do not specify the FetchTags parameter.
                /// </summary>
                [NameInMap("PlannedDeleteTime")]
                [Validation(Required=false)]
                public string PlannedDeleteTime { get; set; }

                /// <summary>
                /// The type of the secret. Valid values:
                /// 
                /// *   Generic: indicates a generic secret.
                /// *   Rds: indicates a managed ApsaraDB RDS secret.
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

                /// <summary>
                /// The time when the secret was created.
                /// </summary>
                [NameInMap("SecretType")]
                [Validation(Required=false)]
                public string SecretType { get; set; }

                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListSecretsResponseBodySecretListSecretTags Tags { get; set; }
                public class ListSecretsResponseBodySecretListSecretTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListSecretsResponseBodySecretListSecretTagsTag> Tag { get; set; }
                    public class ListSecretsResponseBodySecretListSecretTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The time when the secret is scheduled to be deleted.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The secret name.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
