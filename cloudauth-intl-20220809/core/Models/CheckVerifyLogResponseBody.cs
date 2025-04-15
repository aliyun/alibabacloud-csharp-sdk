// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckVerifyLogResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckVerifyLogResponseBodyResult Result { get; set; }
        public class CheckVerifyLogResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("InterruptPage")]
            [Validation(Required=false)]
            public string InterruptPage { get; set; }

            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public List<string> LogInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///           &quot;faceOverTimes&quot;: 0,
            ///           &quot;hasFaceOverTimes&quot;: false,
            ///           &quot;hasFacePermissionRefuse&quot;: false,
            ///           &quot;hasOcrEdit&quot;: true,
            ///           &quot;hasOcrEditOverTimes&quot;: false,
            ///           &quot;hasOcrOverTimes&quot;: true,
            ///           &quot;hasOcrPermissionRefuse&quot;: false,
            ///           &quot;ocrEditOverTimes&quot;: 0,
            ///           &quot;ocrEditTimes&quot;: 1,
            ///           &quot;ocrOverTimes&quot;: 1,
            ///           &quot;pageStayTimeInfo&quot;: {
            ///             &quot;LOADING&quot;: &quot;1615&quot;,
            ///             &quot;OCR_SCAN&quot;: &quot;37446&quot;,
            ///             &quot;OCR_RESULT&quot;: &quot;1338&quot;,
            ///             &quot;FACE&quot;: &quot;8707&quot;
            ///           }
            ///         }</para>
            /// </summary>
            [NameInMap("LogStatisticsInfo")]
            [Validation(Required=false)]
            public string LogStatisticsInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("VerifyErrorCode")]
            [Validation(Required=false)]
            public string VerifyErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VerifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }

        }

    }

}
