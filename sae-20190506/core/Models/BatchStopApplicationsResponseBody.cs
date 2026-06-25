// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BatchStopApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The call was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The call failed.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ID of the change order.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchStopApplicationsResponseBodyData Data { get; set; }
        public class BatchStopApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// <list type="bullet">
            /// <item><description><para>If the request is successful, this parameter is not returned.\<em>\</em>\<em>\</em></para>
            /// </description></item>
            /// <item><description><para>This parameter is returned only if the request failed.\<em>\</em>\<em>\</em> For more information, see the &quot;<b>Error codes</b>&quot; section in this topic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4a815998-b468-4bea-b7d8-59f52a44****</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><para>The ErrorCode parameter is not returned if the request succeeds.</para>
        /// </description></item>
        /// <item><description><para>If the call fails, the ErrorCode parameter is returned. For more information, see the &quot;Error codes&quot; section of this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It can be used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b> is returned when the request succeeds.</para>
        /// </description></item>
        /// <item><description><para>An error code is returned when the request fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7BD8F4C7-D84C-4D46-9885-8212997E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application is created. Valid values</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc3b6e215637275918588187d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
