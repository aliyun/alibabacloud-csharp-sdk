// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of returned secrets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of secrets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a6287a0-ff34-4780-a790-fdfca900557f</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the secret was updated.</para>
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
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-17T07:59:05Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("OwingService")]
                [Validation(Required=false)]
                public string OwingService { get; set; }

                /// <summary>
                /// <para>The resource tags of the secret.</para>
                /// <para>This parameter is not returned if you set the FetchTags parameter to false or do not specify the FetchTags parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-17T07:59:05Z</para>
                /// </summary>
                [NameInMap("PlannedDeleteTime")]
                [Validation(Required=false)]
                public string PlannedDeleteTime { get; set; }

                /// <summary>
                /// <para>The type of the secret. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Generic: indicates a generic secret.</description></item>
                /// <item><description>Rds: indicates a managed ApsaraDB RDS secret.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>secret001</para>
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

                /// <summary>
                /// <para>The time when the secret was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Generic</para>
                /// </summary>
                [NameInMap("SecretType")]
                [Validation(Required=false)]
                public string SecretType { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListSecretsResponseBodySecretListSecretTags Tags { get; set; }
                public class ListSecretsResponseBodySecretListSecretTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListSecretsResponseBodySecretListSecretTagsTag> Tag { get; set; }
                    public class ListSecretsResponseBodySecretListSecretTagsTag : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>key1</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>val1</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the secret is scheduled to be deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-17T07:59:05Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The secret name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
