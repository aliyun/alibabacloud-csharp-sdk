// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The request body for creating a credential.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateCredentialRequestBody Body { get; set; }
        public class CreateCredentialRequestBody : TeaModel {
            /// <summary>
            /// <para>The credential content. The value is a JSON string. When credentialType is set to apiKey, the JSON string can contain only the apiKey field, and the value cannot be empty. After being written, the content can only be queried in masked form.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiKey&quot;:&quot;sk-example-value&quot;}</para>
            /// </summary>
            [NameInMap("credentialMetadata")]
            [Validation(Required=false)]
            public string CredentialMetadata { get; set; }

            /// <summary>
            /// <para>The credential type. Currently, only apiKey is supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiKey</para>
            /// </summary>
            [NameInMap("credentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// <para>The credential description. The description can be up to 256 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API Key used for calling model services in the production environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The credential name. The name must be unique within the workspace and can contain only letters, digits, periods, underscores, and hyphens. The name must be 3 to 128 characters in length and cannot use runtime reserved names.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-api-key</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not supported</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
