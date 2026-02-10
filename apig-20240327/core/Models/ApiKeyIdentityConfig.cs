// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ApiKeyIdentityConfig : TeaModel {
        /// <summary>
        /// <para>The source configuration of the API key.</para>
        /// </summary>
        [NameInMap("apikeySource")]
        [Validation(Required=false)]
        public ApiKeyIdentityConfigApikeySource ApikeySource { get; set; }
        public class ApiKeyIdentityConfigApikeySource : TeaModel {
            /// <summary>
            /// <para>The source of the API key.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Header</description></item>
            /// <item><description>QueryString</description></item>
            /// <item><description>Default</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The value of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of certificates.</para>
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
            /// <para>The production mode.</para>
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
