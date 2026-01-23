// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSecuritySecretKeyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecuritySecretKeyInfo")]
        [Validation(Required=false)]
        public GetSecuritySecretKeyResponseBodySecuritySecretKeyInfo SecuritySecretKeyInfo { get; set; }
        public class GetSecuritySecretKeyResponseBodySecuritySecretKeyInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AES</para>
            /// </summary>
            [NameInMap("AlgorithmType")]
            [Validation(Required=false)]
            public string AlgorithmType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AES</para>
            /// </summary>
            [NameInMap("AlgorithmTypeAlias")]
            [Validation(Required=false)]
            public string AlgorithmTypeAlias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnableOpenapiQuery")]
            [Validation(Required=false)]
            public bool? EnableOpenapiQuery { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SYSTEM_GENERATION</para>
            /// </summary>
            [NameInMap("GenerationType")]
            [Validation(Required=false)]
            public string GenerationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsOwnerManageOnly")]
            [Validation(Required=false)]
            public bool? IsOwnerManageOnly { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("SecretKeyList")]
            [Validation(Required=false)]
            public List<string> SecretKeyList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SubKeyCount")]
            [Validation(Required=false)]
            public long? SubKeyCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HASH</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
