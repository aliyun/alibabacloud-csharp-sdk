// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterApiKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>API Keys。</para>
        /// </summary>
        [NameInMap("ApiKeys")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterApiKeysResponseBodyApiKeys> ApiKeys { get; set; }
        public class DescribeAIDBClusterApiKeysResponseBodyApiKeys : TeaModel {
            /// <summary>
            /// <para>The API key of the model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scxxx-xxx-x-xxWW</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-09T03:19:19Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my api key</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>ApiKey ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>573</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The status of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F2007D3-7E74-4ECB-89A8-BF130D******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
