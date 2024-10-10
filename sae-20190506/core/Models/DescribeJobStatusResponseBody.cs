// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobStatusResponseBodyData Data { get; set; }
        public class DescribeJobStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of running instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public long? Active { get; set; }

            /// <summary>
            /// <para>The time when the job was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657522839</para>
            /// </summary>
            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public long? CompletionTime { get; set; }

            /// <summary>
            /// <para>The number of instances that failed to run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public long? Failed { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>event-b798157b-40a2-4388-b578-71fb897103**-**</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The returned message. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>If the call is successful, <b>success</b> is returned.</description></item>
            /// <item><description>If the call fails, an error code is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657522800</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The job is not executed.</description></item>
            /// <item><description><b>1</b>: The job was executed.</description></item>
            /// <item><description><b>2</b>: The job failed to be executed.</description></item>
            /// <item><description><b>3</b>: The job is being executed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The number of instances that are successfully run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public long? Succeeded { get; set; }

        }

        /// <summary>
        /// <para>The error code returned. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>ErrorCode</b> is not returned if the request succeeds.</description></item>
        /// <item><description><b>ErrorCode</b> is returned if the request fails. For more information, see the &quot;<b>Error codes</b>&quot; section in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the call fails, an error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53F15A18-8079-5992-810C-0211A5AE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
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

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b1639af16575057857241351e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
