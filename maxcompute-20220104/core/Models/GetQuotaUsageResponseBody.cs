// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQuotaUsageResponseBodyData Data { get; set; }
        public class GetQuotaUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The metric results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;timestamps&quot;: [1668046140000, 1668065220000], //milliseconds</para>
            /// <para>    &quot;project1#upload#request&quot;: [10, 20],
            ///     &quot;project1#download#request&quot;: [20, 30],</para>
            /// <para>    &quot;project1#upload#throughput&quot;: [50, 50],
            ///     &quot;project1#download#throughput&quot;: [60, 70],</para>
            /// <para>    &quot;pro2#errorNum&quot;: [5, 10]</para>
            /// </summary>
            [NameInMap("metrics")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metrics { get; set; }

            /// <summary>
            /// <para>The information about the chart.</para>
            /// </summary>
            [NameInMap("plot")]
            [Validation(Required=false)]
            public List<GetQuotaUsageResponseBodyDataPlot> Plot { get; set; }
            public class GetQuotaUsageResponseBodyDataPlot : TeaModel {
                /// <summary>
                /// <para>The title of the chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Project request concurrency</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The type of the chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>request</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The data metric field.</para>
                /// </summary>
                [NameInMap("yAxis")]
                [Validation(Required=false)]
                public List<string> YAxis { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This object does not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: informational response. The request is received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: success. The request is successfully received, understood, and accepted by the server.</para>
        /// </description></item>
        /// <item><description><para>3xx: redirection. The request is redirected, and further actions are required to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: client error. The request contains invalid request parameters and syntaxes, or specific request conditions cannot be met.</para>
        /// </description></item>
        /// <item><description><para>5xx: server error. The server cannot meet requirements due to other reasons.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b87b7a416652014358483492eea0b</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
