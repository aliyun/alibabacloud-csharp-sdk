// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketApiKeyConfig : TeaModel {
        /// <summary>
        /// <para>An array of objects, each containing a valid API key and its associated mode.</para>
        /// </summary>
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public List<HiMarketApiKeyConfigCredentials> Credentials { get; set; }
        public class HiMarketApiKeyConfigCredentials : TeaModel {
            /// <summary>
            /// <para>The value of the API key.</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The operational mode for the key, such as <c>test</c> or <c>production</c>.</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        /// <summary>
        /// <para>The name of the parameter that holds the API key. For example, if <c>source</c> is <c>HEADER</c>, this is the request header name, such as <c>X-API-Key</c>.</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The location of the API key in the request. Valid values are <c>HEADER</c> and <c>QUERY</c>.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
