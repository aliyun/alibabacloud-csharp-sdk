// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAsyncErrorRequestStatByCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;fail&quot;: false,     &quot;data&quot;: [       {         &quot;instanceId&quot;: &quot;rm-2ze8g2am97624****&quot;,         &quot;count&quot;: 1,         &quot;errorCode&quot;: &quot;1062&quot;       },       {         &quot;instanceId&quot;: &quot;rm-2ze8g2am97624****&quot;,         &quot;count&quot;: 2,         &quot;errorCode&quot;: &quot;1064&quot;      }     ],     &quot;resultId&quot;: &quot;async__fcd7c35788e62324622c3b4a03de****&quot;,     &quot;isFinish&quot;: true,     &quot;state&quot;: &quot;SUCCESS&quot;,     &quot;complete&quot;: true,     &quot;timestamp&quot;: 1644560866961   }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsyncErrorRequestStatByCodeResponseBodyData Data { get; set; }
        public class GetAsyncErrorRequestStatByCodeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the asynchronous request was complete.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous request failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("fail")]
            [Validation(Required=false)]
            public bool? Fail { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous request was complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The number of SQL queries corresponding to the error code.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<GetAsyncErrorRequestStatByCodeResponseBodyDataResult> Result { get; set; }
            public class GetAsyncErrorRequestStatByCodeResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The number of SQL queries corresponding to the error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The error code returned if the request failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1062</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze8g2am97624****</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the asynchronous request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async__fcd7c35788e62324622c3b4a03de****</para>
            /// </summary>
            [NameInMap("resultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The state of the asynchronous request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b></description></item>
            /// <item><description><b>SUCCESS</b></description></item>
            /// <item><description><b>FAIL</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the asynchronous request was made. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644560866961</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>840F51F7-9C01-538D-94F6-AE712905****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
