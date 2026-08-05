// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ApiKeyIdentityConfig : TeaModel {
        /// <summary>
        /// <para>The API key source configuration.</para>
        /// </summary>
        [NameInMap("apikeySource")]
        [Validation(Required=false)]
        public ApiKeyIdentityConfigApikeySource ApikeySource { get; set; }
        public class ApiKeyIdentityConfigApikeySource : TeaModel {
            /// <summary>
            /// <para>The API key source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The API key value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The complete set of API key credential sources. The set contains one to three items. Multiple sources are applicable only to the AI gateway Header mode. Query String and non-AI gateway scenarios allow only a single source. If submitted together with apikeySource, the latter must be consistent with the compatible projection.</para>
        /// </summary>
        [NameInMap("apikeySources")]
        [Validation(Required=false)]
        public List<ApiKeyIdentityConfigApikeySources> ApikeySources { get; set; }
        public class ApiKeyIdentityConfigApikeySources : TeaModel {
            /// <summary>
            /// <para>The credential source type.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The field name of the HTTP header or query string.</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of credentials.</para>
        /// </summary>
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public List<ApiKeyIdentityConfigCredentials> Credentials { get; set; }
        public class ApiKeyIdentityConfigCredentials : TeaModel {
            /// <summary>
            /// <para>The API key configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("apikey")]
            [Validation(Required=false)]
            public string Apikey { get; set; }

            /// <summary>
            /// <para>The generation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("generateMode")]
            [Validation(Required=false)]
            public string GenerateMode { get; set; }

        }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apikey</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
