// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetErrorRequestSampleResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[         {             &quot;sqlId&quot;: &quot;2cd4432556c3dab9d825ba363637****&quot;,             &quot;database&quot;: &quot;dbgateway&quot;,             &quot;originHost&quot;: &quot;172.16.1****&quot;,             &quot;tables&quot;: [                 &quot;meter_****&quot;             ],             &quot;instanceId&quot;: &quot;rm-2ze8g2am97624****&quot;,             &quot;errorCode&quot;: &quot;1062&quot;,             &quot;user&quot;: &quot;dbgat****&quot;,             &quot;sql&quot;: &quot;insert into meter_****\n        ( \n        <b><b>\n     )\n        values (now(), now(), \&quot;bbbc8624-5e19-455a-9714-8466f688</b></b>\&quot;, \&quot;2022-02-10 14:00:00\&quot;, \&quot;{\&quot;endTime\&quot;:\&quot;2022-02-10 14:00:00\&quot;,\&quot;endTimestamp\&quot;:1644472800,\&quot;startTime\&quot;:\&quot;2022-02-10 13:00:00\&quot;,\&quot;startTimestamp\&quot;:1644469200}\&quot;, null, null)&quot;,             &quot;timestamp&quot;: 1644476100435         }]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetErrorRequestSampleResponseBodyData> Data { get; set; }
        public class GetErrorRequestSampleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbgateway</para>
            /// </summary>
            [NameInMap("database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The error code that is returned.</para>
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

            /// <summary>
            /// <para>The IP address of the client that executes the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.1****</para>
            /// </summary>
            [NameInMap("originHost")]
            [Validation(Required=false)]
            public string OriginHost { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>insert into meter_****</para>
            /// </summary>
            [NameInMap("sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The SQL query ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2cd4432556c3dab9d825ba363637****</para>
            /// </summary>
            [NameInMap("sqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// <para>The table information.</para>
            /// </summary>
            [NameInMap("tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

            /// <summary>
            /// <para>The time when the SQL query was executed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644476100435</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The username of the account that is used to log on to the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbgat****</para>
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

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
        /// <para>7172BECE-588A-5961-8126-C216E16B****</para>
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
