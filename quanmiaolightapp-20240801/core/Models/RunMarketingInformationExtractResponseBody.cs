// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunMarketingInformationExtractResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;TimeZone\&quot;: \&quot;Asia/Shanghai\&quot;, \&quot;DateTime\&quot;: \&quot;2024-03-07T17:00:09+08:00\&quot;}</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        [NameInMap("header")]
        [Validation(Required=false)]
        public RunMarketingInformationExtractResponseBodyHeader Header { get; set; }
        public class RunMarketingInformationExtractResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>result-generated</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("eventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F08C71C0-9399-548C-838B-1DA01DE211B0</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>121dlsga4o7golrl1hojazg0u9lvytjc17ebgzzj2u4zukgh122tfg7wj1e6a1vcowy1ewzinauxriai9atcr6r323mm9ddbr0bg5m61ij8hxnf8664tstlfkfol6m8luc4shs3gums7l46uauyy0xndqmhdjtdon6coyhb4x17bo762bg9e3tb2geufg2</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12826092918145</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2150432017236011824686132ecdbc</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunMarketingInformationExtractResponseBodyPayload Payload { get; set; }
        public class RunMarketingInformationExtractResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunMarketingInformationExtractResponseBodyPayloadOutput Output { get; set; }
            public class RunMarketingInformationExtractResponseBodyPayloadOutput : TeaModel {
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunMarketingInformationExtractResponseBodyPayloadUsage Usage { get; set; }
            public class RunMarketingInformationExtractResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

    }

}
