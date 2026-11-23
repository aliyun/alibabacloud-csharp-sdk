// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class GetQwenEduApiActivationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status or POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The activation result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQwenEduApiActivationStatusResponseBodyData Data { get; set; }
        public class GetQwenEduApiActivationStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The <b>failure code</b>. For more information, see 3.4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATION_FAILED</para>
            /// </summary>
            [NameInMap("failCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            /// <summary>
            /// <para>The <b>failure description</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service activation failed. Try again later</para>
            /// </summary>
            [NameInMap("failMessage")]
            [Validation(Required=false)]
            public string FailMessage { get; set; }

            /// <summary>
            /// <para>The activation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: Activated.</description></item>
            /// <item><description>ACTIVATING: Activating.</description></item>
            /// <item><description>FAILED: Activation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The <b>POP request ID</b>. This field is not returned if signature verification or identity authentication fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C5E3F0A-2B0E-4F7B-9C55-0E1A6A0E2F11</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
