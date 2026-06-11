// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiNetworkConfigSearchEngine : TeaModel {
        /// <summary>
        /// <para>Required. The API key to authenticate requests to the search engine service.</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The search content mode, which determines how the service interprets the query and returns results.</para>
        /// </summary>
        [NameInMap("contentMode")]
        [Validation(Required=false)]
        public string ContentMode { get; set; }

        /// <summary>
        /// <para>The number of search results to return. If this parameter is omitted, the service uses a default value.</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The endpoint URL for the search engine service.</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The industry context for tailoring search results to a specific domain.</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>Optional. A key-value map for service-specific parameters not covered by the standard configuration.</para>
        /// </summary>
        [NameInMap("optionArgs")]
        [Validation(Required=false)]
        public Dictionary<string, string> OptionArgs { get; set; }

        /// <summary>
        /// <para>The starting offset for the search results, used for pagination. For example, a value of 10 skips the first 10 results. The default is 0.</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        /// <summary>
        /// <para>The time range for filtering results by their creation or modification date.</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

        /// <summary>
        /// <para>The request timeout in milliseconds. If a request exceeds this time, the service terminates it.</para>
        /// </summary>
        [NameInMap("timeoutMillisecond")]
        [Validation(Required=false)]
        public int? TimeoutMillisecond { get; set; }

        /// <summary>
        /// <para>Specifies the search engine service to use.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
