// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class PrecheckYikeAIAppJobResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned if the precheck fails. This parameter contains only the parameters that failed the check.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<PrecheckYikeAIAppJobResponseBodyResult> Result { get; set; }
        public class PrecheckYikeAIAppJobResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The cause of the parameter validation error.</para>
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
        /// <para>The precheck result. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>Success: The precheck was successful.</para>
        /// </description></item>
        /// <item><description><para>Failed: The precheck failed.</para>
        /// </description></item>
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
