// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListImportableKMSSecretsForHostResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4ieSWJCwxvW3dk3wF.BqkrZmP72nWu5zJ5NWydMqyEs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public List<ListImportableKMSSecretsForHostResponseBodySecrets> Secrets { get; set; }
        public class ListImportableKMSSecretsForHostResponseBodySecrets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("SecretName")]
            [Validation(Required=false)]
            public string SecretName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("SecretType")]
            [Validation(Required=false)]
            public string SecretType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

    }

}
