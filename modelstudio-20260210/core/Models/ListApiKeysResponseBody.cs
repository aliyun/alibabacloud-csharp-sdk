// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
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
            /// <para>API Key ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2965964</para>
            /// </summary>
            [NameInMap("apiKeyId")]
            [Validation(Required=false)]
            public long? ApiKeyId { get; set; }

            /// <summary>
            /// <para>The value of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-ws-djI.8O7d*****2aICctnid4u4</para>
            /// </summary>
            [NameInMap("apiKeyValue")]
            [Validation(Required=false)]
            public string ApiKeyValue { get; set; }

            /// <summary>
            /// <para>The permission settings.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public ListApiKeysResponseBodyApiKeysAuth Auth { get; set; }
            public class ListApiKeysResponseBodyApiKeysAuth : TeaModel {
                /// <summary>
                /// <para>The IP access whitelist.</para>
                /// </summary>
                [NameInMap("accessIps")]
                [Validation(Required=false)]
                public List<string> AccessIps { get; set; }

                /// <summary>
                /// <para>The model access scope.</para>
                /// </summary>
                [NameInMap("modelAccessScope")]
                [Validation(Required=false)]
                public ListApiKeysResponseBodyApiKeysAuthModelAccessScope ModelAccessScope { get; set; }
                public class ListApiKeysResponseBodyApiKeysAuthModelAccessScope : TeaModel {
                    /// <summary>
                    /// <para>The list of accessible models.</para>
                    /// </summary>
                    [NameInMap("accessibleModels")]
                    [Validation(Required=false)]
                    public List<string> AccessibleModels { get; set; }

                    /// <summary>
                    /// <para>Indicates whether access to all models with inference permissions in the workspace is allowed.</para>
                    /// </summary>
                    [NameInMap("allowAllModels")]
                    [Validation(Required=false)]
                    public bool? AllowAllModels { get; set; }

                }

                /// <summary>
                /// <para>All: all permissions. Custom: custom permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1378030599924858</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the API key is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Active.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("disabled")]
            [Validation(Required=false)]
            public int? Disabled { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774338222000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-950f9aca7e76c816</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token used to retrieve more results. This parameter is not required for the first query. For subsequent queries, use the token obtained from the previous response.</para>
        /// 
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
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
