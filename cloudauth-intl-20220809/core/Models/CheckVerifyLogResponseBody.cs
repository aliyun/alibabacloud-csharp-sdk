// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckVerifyLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
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

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckVerifyLogResponseBodyResult Result { get; set; }
        public class CheckVerifyLogResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The extended information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// <para>The last page where the authentication was interrupted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>The page is not started.</description></item>
            /// <item><description>The OCR guide page.</description></item>
            /// <item><description>The OCR camera authorization page.</description></item>
            /// <item><description>The OCR document capture page.</description></item>
            /// <item><description>The OCR recognition loading page.</description></item>
            /// <item><description>The OCR recognition result editing page.</description></item>
            /// <item><description>The OCR recognition result editing loading page.</description></item>
            /// <item><description>The liveness detection guide page.</description></item>
            /// <item><description>The liveness detection camera authorization page.</description></item>
            /// <item><description>The liveness detection page.</description></item>
            /// <item><description>The liveness detection fallback page.</description></item>
            /// <item><description>The liveness detection retry page.</description></item>
            /// <item><description>The liveness detection loading page.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OCR document capture page</para>
            /// </summary>
            [NameInMap("InterruptPage")]
            [Validation(Required=false)]
            public string InterruptPage { get; set; }

            /// <summary>
            /// <para>The last page where the authentication was interrupted, in English. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LOADING</para>
            /// </description></item>
            /// <item><description><para>GUIDE</para>
            /// </description></item>
            /// <item><description><para>FACE</para>
            /// </description></item>
            /// <item><description><para>OCR_SCAN</para>
            /// </description></item>
            /// <item><description><para>OCR_RESULT</para>
            /// </description></item>
            /// <item><description><para>NFC_INPUT</para>
            /// </description></item>
            /// <item><description><para>NFC_READ</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LOADING</para>
            /// </summary>
            [NameInMap("InterruptPageEn")]
            [Validation(Required=false)]
            public string InterruptPageEn { get; set; }

            /// <summary>
            /// <para>The details of the SDK runtime logs.</para>
            /// </summary>
            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public List<string> LogInfo { get; set; }

            /// <summary>
            /// <para>The details of the SDK runtime trace logs in English. The format of this field is the same as that of <b>LogInfo</b>.</para>
            /// </summary>
            [NameInMap("LogInfoEn")]
            [Validation(Required=false)]
            public List<string> LogInfoEn { get; set; }

            /// <summary>
            /// <para>The statistical details of the SDK runtime logs.</para>
            /// 
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
            /// <para>Indicates whether the authentication is passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Passed.</description></item>
            /// <item><description>N: Not passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>The sub-result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The error code for authentication interruption. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1000: The user completed the face scanning process, and the recommended authentication result is passed.</description></item>
            /// <item><description>1001: The user completed the face scanning process, and the recommended authentication result is not passed.</description></item>
            /// <item><description>1002: A system error occurred.</description></item>
            /// <item><description>1003: SDK initialization failed. Check whether the client time is correct.</description></item>
            /// <item><description>1004: A camera permission error occurred.</description></item>
            /// <item><description>1005: A network error occurred.</description></item>
            /// <item><description>1006: The user exited.</description></item>
            /// <item><description>1007: The TransactionId is invalid.</description></item>
            /// <item><description>1009: The client timestamp is incorrect.</description></item>
            /// <item><description>1011: The submitted document type is incorrect.</description></item>
            /// <item><description>1012: The recognized key information of the document is missing or the format verification failed.</description></item>
            /// <item><description>1013: The image quality is poor.</description></item>
            /// <item><description>1014: The number of errors exceeded the upper limit.</description></item>
            /// <item><description>1015: The Android system version is too low.</description></item>
            /// <item><description>1016: Camera permissions are not obtained.</description></item>
            /// <item><description>9999: The authentication process is suspected to be interrupted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("VerifyErrorCode")]
            [Validation(Required=false)]
            public string VerifyErrorCode { get; set; }

            /// <summary>
            /// <para>The authentication status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: finished. The authentication is completed.</description></item>
            /// <item><description>1: unfinished. The authentication is interrupted.</description></item>
            /// <item><description>2: notstart. The authentication is not started.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VerifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }

        }

    }

}
