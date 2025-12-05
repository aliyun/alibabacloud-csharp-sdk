// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsDebugSampleLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code. If the operation is successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4001</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. If the operation is successful, this parameter is not returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E16480-15C1-555A-922F-B736A005E52D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sampling logs.</para>
        /// </summary>
        [NameInMap("SamplingLogs")]
        [Validation(Required=false)]
        public List<GetPtsDebugSampleLogsResponseBodySamplingLogs> SamplingLogs { get; set; }
        public class GetPtsDebugSampleLogsResponseBodySamplingLogs : TeaModel {
            /// <summary>
            /// <para>The ID of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65354719</para>
            /// </summary>
            [NameInMap("ChainId")]
            [Validation(Required=false)]
            public string ChainId { get; set; }

            /// <summary>
            /// <para>The name of the session.</para>
            /// </summary>
            [NameInMap("ChainName")]
            [Validation(Required=false)]
            public string ChainName { get; set; }

            /// <summary>
            /// <para>The assertion check result.</para>
            /// </summary>
            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public string CheckResult { get; set; }

            /// <summary>
            /// <para>The parameter export configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;skuId\&quot;:\&quot;{R:json@$.page.list[0].skuId}\&quot;}</para>
            /// </summary>
            [NameInMap("ExportConfig")]
            [Validation(Required=false)]
            public string ExportConfig { get; set; }

            /// <summary>
            /// <para>The exported parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;skuId&quot;:&quot;1&quot;}</para>
            /// </summary>
            [NameInMap("ExportContent")]
            [Validation(Required=false)]
            public string ExportContent { get; set; }

            /// <summary>
            /// <para>The body of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;loginacct&quot;:&quot;acce&quot;}</para>
            /// </summary>
            [NameInMap("HttpRequestBody")]
            [Validation(Required=false)]
            public string HttpRequestBody { get; set; }

            /// <summary>
            /// <para>The request headers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;v2&quot;,&quot;sensitive&quot;:false,&quot;value&quot;:&quot;1&quot;},{&quot;name&quot;:&quot;x-pts-test&quot;,&quot;sensitive&quot;:false,&quot;value&quot;:&quot;2&quot;}]</para>
            /// </summary>
            [NameInMap("HttpRequestHeaders")]
            [Validation(Required=false)]
            public string HttpRequestHeaders { get; set; }

            /// <summary>
            /// <para>The request method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("HttpRequestMethod")]
            [Validation(Required=false)]
            public string HttpRequestMethod { get; set; }

            /// <summary>
            /// <para>The endpoint that specifies where the request is directed.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">http://www.example.com</a></para>
            /// </summary>
            [NameInMap("HttpRequestUrl")]
            [Validation(Required=false)]
            public string HttpRequestUrl { get; set; }

            /// <summary>
            /// <para>The response body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;timestamp&quot;:1679903049155,&quot;status&quot;:404,&quot;error&quot;:&quot;Not Found&quot;,&quot;message&quot;:&quot;No message available&quot;,&quot;path&quot;:&quot;/&quot;}</para>
            /// </summary>
            [NameInMap("HttpResponseBody")]
            [Validation(Required=false)]
            public string HttpResponseBody { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("HttpResponseFailMsg")]
            [Validation(Required=false)]
            public string HttpResponseFailMsg { get; set; }

            /// <summary>
            /// <para>The response headers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;valuePos&quot;:18,&quot;name&quot;:&quot;transfer-encoding&quot;,&quot;buffer&quot;:{&quot;empty&quot;:false,&quot;full&quot;:false},&quot;sensitive&quot;:false,&quot;value&quot;:&quot;chunked&quot;},{&quot;valuePos&quot;:13,&quot;name&quot;:&quot;Content-Type&quot;,&quot;buffer&quot;:{&quot;empty&quot;:false,&quot;full&quot;:false},&quot;sensitive&quot;:false,&quot;value&quot;:&quot;application/json;charset=UTF-8&quot;},{&quot;valuePos&quot;:5,&quot;name&quot;:&quot;Date&quot;,&quot;buffer&quot;:{&quot;empty&quot;:false,&quot;full&quot;:false},&quot;sensitive&quot;:false,&quot;value&quot;:&quot;Mon, 27 Mar 2023 07:44:08 GMT&quot;}]</para>
            /// </summary>
            [NameInMap("HttpResponseHeaders")]
            [Validation(Required=false)]
            public string HttpResponseHeaders { get; set; }

            /// <summary>
            /// <para>The HTTP status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("HttpResponseStatus")]
            [Validation(Required=false)]
            public string HttpResponseStatus { get; set; }

            /// <summary>
            /// <para>The time when the request was sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("HttpStartTime")]
            [Validation(Required=false)]
            public long? HttpStartTime { get; set; }

            /// <summary>
            /// <para>The HTTP timing information in a waterfall format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;traceId&quot;:&quot;0:1:10a94f66pts-2069351-allsparktask&quot;,&quot;requests&quot;:[{&quot;lease&quot;:{&quot;conn&quot;:{&quot;duration&quot;:-1,&quot;finish&quot;:-1,&quot;operation&quot;:&quot;conn&quot;,&quot;start&quot;:-1},&quot;dns&quot;:{&quot;duration&quot;:-1,&quot;finish&quot;:-1,&quot;operation&quot;:&quot;dns&quot;,&quot;start&quot;:-1},&quot;duration&quot;:-1,&quot;finish&quot;:-1,&quot;operation&quot;:&quot;lease&quot;,&quot;start&quot;:32277914755},&quot;recv&quot;:{&quot;duration&quot;:225975,&quot;finish&quot;:32283700284,&quot;message&quot;:&quot;&quot;,&quot;operation&quot;:&quot;recv&quot;,&quot;start&quot;:32283474309},&quot;sent&quot;:{&quot;duration&quot;:594179,&quot;finish&quot;:32278776504,&quot;message&quot;:&quot;&quot;,&quot;operation&quot;:&quot;sent&quot;,&quot;start&quot;:32278182325},&quot;tag&quot;:&quot;GET <a href="http://tomcodemall.com:30080/api/product/skuinfo/list?key=2&vv=4&t4=%EF%BB%BF101%22%7D%5D,%22message%22:%22%22%7D">http://tomcodemall.com:30080/api/product/skuinfo/list?key=2&amp;vv=4&amp;t4=%EF%BB%BF101&quot;}],&quot;message&quot;:&quot;&quot;}</a></para>
            /// </summary>
            [NameInMap("HttpTiming")]
            [Validation(Required=false)]
            public string HttpTiming { get; set; }

            /// <summary>
            /// <para>The imported parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ImportContent")]
            [Validation(Required=false)]
            public string ImportContent { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1345531</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The response time. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>230</para>
            /// </summary>
            [NameInMap("Rt")]
            [Validation(Required=false)]
            public string Rt { get; set; }

            /// <summary>
            /// <para>The timestamp. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650253024471</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
