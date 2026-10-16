// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateClientSecretResponseBody : TeaModel {
        /// <summary>
        /// <para>The client secret information.</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public CreateClientSecretResponseBodyClientSecret ClientSecret { get; set; }
        public class CreateClientSecretResponseBodyClientSecret : TeaModel {
            /// <summary>
            /// <para>The ID of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The name of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-web-app</para>
            /// </summary>
            [NameInMap("ClientName")]
            [Validation(Required=false)]
            public string ClientName { get; set; }

            /// <summary>
            /// <para>The client key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secret_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientSecretId")]
            [Validation(Required=false)]
            public string ClientSecretId { get; set; }

            /// <summary>
            /// <para>The plaintext client secret. This value is returned only once upon creation and cannot be retrieved later. Store it securely.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientSecretValue")]
            [Validation(Required=false)]
            public string ClientSecretValue { get; set; }

            /// <summary>
            /// <para>The time when the client secret was created, in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-userpool</para>
            /// </summary>
            [NameInMap("UserPoolName")]
            [Validation(Required=false)]
            public string UserPoolName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
