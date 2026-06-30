// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class PrecheckYikeAIAppJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The parameters that failed the pre-check. This parameter is returned only when the pre-check fails.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<PrecheckYikeAIAppJobResponseBodyResult> Result { get; set; }
        public class PrecheckYikeAIAppJobResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The cause of the parameter check failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImageCheckFailed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The application parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LoadImage.1.TargetImage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// <para>The pre-check result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success: The pre-check is successful.</description></item>
        /// <item><description>Failed: The pre-check failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
