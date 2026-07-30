// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripBusinessInstanceQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module。</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TripBusinessInstanceQueryResponseBodyModule Module { get; set; }
        public class TripBusinessInstanceQueryResponseBodyModule : TeaModel {
            [NameInMap("business_data")]
            [Validation(Required=false)]
            public string BusinessData { get; set; }

            [NameInMap("business_form_data")]
            [Validation(Required=false)]
            public string BusinessFormData { get; set; }

            /// <summary>
            /// <para>The creator of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The creation time (timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1525104000</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time (timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1525104000</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RUNNING: Pending approval.</description></item>
            /// <item><description>SUCCESS: Approved.</description></item>
            /// <item><description>REJECT: Rejected.</description></item>
            /// <item><description>TERMINATED: Revoked.</description></item>
            /// <item><description>MODIFY_RUNNING: Modification pending approval.</description></item>
            /// <item><description>MODIFY_AGREE: Modification approved.</description></item>
            /// <item><description>MODIFY_REJECT: Modification rejected.</description></item>
            /// <item><description>MODIFY_TERMINATED: Modification revoked.</description></item>
            /// <item><description>TERMINATED_RUNNING: Revocation pending approval.</description></item>
            /// <item><description>TERMINATED_AGREE: Revocation approved.</description></item>
            /// <item><description>TERMINATED_REJECT: Revocation rejected.</description></item>
            /// <item><description>TERMINATED_TERMINATED: Revocation canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc44416869853114684533da3c2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
