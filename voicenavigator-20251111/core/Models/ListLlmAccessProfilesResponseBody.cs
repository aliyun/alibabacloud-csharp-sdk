// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListLlmAccessProfilesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLlmAccessProfilesResponseBodyData Data { get; set; }
        public class ListLlmAccessProfilesResponseBodyData : TeaModel {
            [NameInMap("LlmAccessProfiles")]
            [Validation(Required=false)]
            public List<ListLlmAccessProfilesResponseBodyDataLlmAccessProfiles> LlmAccessProfiles { get; set; }
            public class ListLlmAccessProfilesResponseBodyDataLlmAccessProfiles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>af81a389-91f0-4157-8d82-720edd02b66b</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1747620752000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8fe2b8b1cdd446318610ccbc70bcfff0</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public ListLlmAccessProfilesResponseBodyDataLlmAccessProfilesProfile Profile { get; set; }
                public class ListLlmAccessProfilesResponseBodyDataLlmAccessProfilesProfile : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>akm-93929110-d7c1-4014-8678-613aacd58fa2</para>
                    /// </summary>
                    [NameInMap("ApiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>api.llm.enpoint.example.com</para>
                    /// </summary>
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NluAccessType")]
                    [Validation(Required=false)]
                    public string NluAccessType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BEEBOT</para>
                    /// </summary>
                    [NameInMap("NluEngine")]
                    [Validation(Required=false)]
                    public string NluEngine { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1768788798</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ED56B723-5802-5C32-865F-6E20B06D2455</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
