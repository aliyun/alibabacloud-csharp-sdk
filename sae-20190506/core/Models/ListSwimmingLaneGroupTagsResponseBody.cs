// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListSwimmingLaneGroupTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client error occurred.</para>
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSwimmingLaneGroupTagsResponseBodyData> Data { get; set; }
        public class ListSwimmingLaneGroupTagsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;tag\&quot;:\&quot;g1\&quot;,\&quot;priority\&quot;:100,\&quot;type\&quot;:\&quot;tag\&quot;,\&quot;desc\&quot;:\&quot;sys-label\&quot;}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <para>The swimming lane tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g1</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request succeeds.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error message is returned.</para>
        /// </description></item>
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
        /// <para>30375C38-F4ED-4135-A0AE-5C75DC7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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
        /// <para>The trace ID that is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622920113732501e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
