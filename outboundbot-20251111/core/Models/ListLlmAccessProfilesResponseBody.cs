// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListLlmAccessProfilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLlmAccessProfilesResponseBodyData Data { get; set; }
        public class ListLlmAccessProfilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of third-party language model access configurations.</para>
            /// </summary>
            [NameInMap("LlmAccessProfiles")]
            [Validation(Required=false)]
            public List<ListLlmAccessProfilesResponseBodyDataLlmAccessProfiles> LlmAccessProfiles { get; set; }
            public class ListLlmAccessProfilesResponseBodyDataLlmAccessProfiles : TeaModel {
                /// <summary>
                /// <para>The ID of the access configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5dcc2dc6-57b4-488e-b6c8-6115cbc2a21e</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779700982000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a8ef16a-c1a6-4c97-acbe-3e53521beb39</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The language model access configuration.</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public ListLlmAccessProfilesResponseBodyDataLlmAccessProfilesProfile Profile { get; set; }
                public class ListLlmAccessProfilesResponseBodyDataLlmAccessProfilesProfile : TeaModel {
                    /// <summary>
                    /// <para>The API key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-api-key</para>
                    /// </summary>
                    [NameInMap("ApiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// <para>The endpoint URL of the model service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>wss://example.com/api/realtime</para>
                    /// </summary>
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <para>The name of the access configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sample configuration</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the access configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Provided</para>
                    /// </summary>
                    [NameInMap("NluAccessType")]
                    [Validation(Required=false)]
                    public string NluAccessType { get; set; }

                    /// <summary>
                    /// <para>The type of the natural language understanding (NLU) engine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PROMPTS</para>
                    /// </summary>
                    [NameInMap("NluEngine")]
                    [Validation(Required=false)]
                    public string NluEngine { get; set; }

                }

                /// <summary>
                /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779700982000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of variable values in the error message.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
