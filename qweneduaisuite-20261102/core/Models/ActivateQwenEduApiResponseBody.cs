// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class ActivateQwenEduApiResponseBody : TeaModel {
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
        /// <para>The activation result. This parameter is null when an error occurs.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ActivateQwenEduApiResponseBodyData Data { get; set; }
        public class ActivateQwenEduApiResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The failure description.</para>
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
        /// <para>The POP request ID. This parameter is not returned when signature or identity verification fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C5E3F0A-2B0E-4F7B-9C55-0E1A6A0E2F11</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
