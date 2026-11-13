// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListAiModelSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. A value of Ok indicates success, and a specific business error code indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned by the model source operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListAiModelSourcesResponseBodyData Data { get; set; }
        public class ListAiModelSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of model sources returned on the current page.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListAiModelSourcesResponseBodyDataItems> Items { get; set; }
            public class ListAiModelSourcesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The display name of the model source or model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Model Studio model source</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the AI gateway instance to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-d00000000000000000000</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The number of models.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("modelCount")]
                [Validation(Required=false)]
                public long? ModelCount { get; set; }

                /// <summary>
                /// <para>The model source ID. Use the modelSourceId returned by CreateAiModelSource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ms-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelSourceId")]
                [Validation(Required=false)]
                public string ModelSourceId { get; set; }

                /// <summary>
                /// <para>The stable identifier of the model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen</para>
                /// </summary>
                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// <para>The ID of the actual AI service bound to the model source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The time of the last business update, in RFC 3339 format and the UTC time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-12T00:00:00Z</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The current version of the object, which is used for conditional validation during updates or deletions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of records returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token returned from the previous page. Do not specify this parameter when you query the first page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ==</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of records that match the current query conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message, which describes the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is generated by the system to trace the current call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
