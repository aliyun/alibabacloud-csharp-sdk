// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or the error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: Redirection.</description></item>
        /// <item><description><b>4xx</b>: The request failed.</description></item>
        /// <item><description><b>5xx</b>: Server error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The application information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneGroupResponseBodyData Data { get; set; }
        public class CreateOrUpdateSwimmingLaneGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2074</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

        }

        /// <summary>
        /// <para>The status code. Value values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the request failed, <b>ErrorCode</b> is returned. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The error message returned because the request is normal and <b>success</b> is returned.</description></item>
        /// <item><description>If the request is abnormal, the specific exception error code is returned.</description></item>
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
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the lane group is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Created successfully.</description></item>
        /// <item><description><b>false</b>: The ConfigMap failed to be created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. This parameter is used to query the exact call information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
