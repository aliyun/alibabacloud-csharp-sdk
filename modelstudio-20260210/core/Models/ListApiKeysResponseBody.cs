// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListApiKeysResponseBody : TeaModel {
        [NameInMap("apiKeys")]
        [Validation(Required=false)]
        public List<ListApiKeysResponseBodyApiKeys> ApiKeys { get; set; }
        public class ListApiKeysResponseBodyApiKeys : TeaModel {
            /// <summary>
            /// <para>API Key ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2965964</para>
            /// </summary>
            [NameInMap("apiKeyId")]
            [Validation(Required=false)]
            public long? ApiKeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-ws-djI.8O7d*****2aICctnid4u4</para>
            /// </summary>
            [NameInMap("apiKeyValue")]
            [Validation(Required=false)]
            public string ApiKeyValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1378030599924858</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("disabled")]
            [Validation(Required=false)]
            public int? Disabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1774338222000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ws-950f9aca7e76c816</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lwytFRtLdNk=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4C14AE6-E987-5C2F-9230-9960AB48F4F2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
