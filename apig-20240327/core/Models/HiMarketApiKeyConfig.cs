// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketApiKeyConfig : TeaModel {
        /// <summary>
        /// <para>The list of credentials.</para>
        /// </summary>
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public List<HiMarketApiKeyConfigCredentials> Credentials { get; set; }
        public class HiMarketApiKeyConfigCredentials : TeaModel {
            /// <summary>
            /// <para>The API key value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-api-key-123</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The generation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        /// <summary>
        /// <para>The name of the location from which the API key is extracted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apikey</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The source type of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Header</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
