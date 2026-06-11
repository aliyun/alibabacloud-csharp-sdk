// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListContextStoreAPIKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. To retrieve the next page of results, include this value in the <c>nextToken</c> parameter of your next request. If this parameter is not returned, there are no more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xCs4wJD41qEejNkappMSJ1OL2Ky2GeKLqmBLJrC61WrgUOj9F-31jHbo5Kgqzifv</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of API keys.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<ListContextStoreAPIKeysResponseBodyResults> Results { get; set; }
        public class ListContextStoreAPIKeysResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The complete API key value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-3ac8d45d741e4f31b81aa6ee984ce9fd</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The name of the context store.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-context-Store</para>
            /// </summary>
            [NameInMap("contextStoreName")]
            [Validation(Required=false)]
            public string ContextStoreName { get; set; }

            /// <summary>
            /// <para>The time when the API key was created, represented as a Unix timestamp.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1778205145</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The display name of the API key. This name helps you identify the purpose of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Production Service Key</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-workspace</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The total count of entries that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>454</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
