// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListApiKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of API keys.</para>
        /// </summary>
        [NameInMap("apiKeys")]
        [Validation(Required=false)]
        public List<ListApiKeysResponseBodyApiKeys> ApiKeys { get; set; }
        public class ListApiKeysResponseBodyApiKeys : TeaModel {
            /// <summary>
            /// <para>The list of Logstores that the API key is allowed to write to.</para>
            /// </summary>
            [NameInMap("allowedStores")]
            [Validation(Required=false)]
            public List<string> AllowedStores { get; set; }

            /// <summary>
            /// <para>The plaintext of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <apiKey-plaintext>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The name of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-apikey-001</para>
            /// </summary>
            [NameInMap("apiKeyName")]
            [Validation(Required=false)]
            public string ApiKeyName { get; set; }

            /// <summary>
            /// <para>The time when the API key was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788420000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The status of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the API key was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788420000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public int? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of API keys on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The total number of API keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
