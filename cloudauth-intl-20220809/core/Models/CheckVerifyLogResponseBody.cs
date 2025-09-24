// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckVerifyLogResponseBody : TeaModel {
        /// <summary>
        /// <para>Backend error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckVerifyLogResponseBodyResult Result { get; set; }
        public class CheckVerifyLogResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Extended information</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// <para>Records the last page where the authentication was interrupted.</para>
            /// <list type="bullet">
            /// <item><description>Page not started</description></item>
            /// <item><description>OCR guide page</description></item>
            /// <item><description>OCR camera authorization</description></item>
            /// <item><description>OCR document capture page</description></item>
            /// <item><description>OCR recognition loading</description></item>
            /// <item><description>OCR recognition result editing page</description></item>
            /// <item><description>OCR recognition result editing loading</description></item>
            /// <item><description>Liveness detection guide page</description></item>
            /// <item><description>Liveness detection camera authorization page</description></item>
            /// <item><description>Liveness detection page</description></item>
            /// <item><description>Liveness detection fallback page</description></item>
            /// <item><description>Liveness detection retry</description></item>
            /// <item><description>Liveness detection loading</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OCR拍摄证件页面</para>
            /// </summary>
            [NameInMap("InterruptPage")]
            [Validation(Required=false)]
            public string InterruptPage { get; set; }

            /// <summary>
            /// <para>The page where the authentication process stops. Possible English values:</para>
            /// <para>The following are the values in an unordered list:</para>
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
            /// <para>SDK operation log details</para>
            /// </summary>
            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public List<string> LogInfo { get; set; }

            /// <summary>
            /// <para>SDK Operation Log Details (English Version)</para>
            /// </summary>
            [NameInMap("LogInfoEn")]
            [Validation(Required=false)]
            public List<string> LogInfoEn { get; set; }

            /// <summary>
            /// <para>SDK operation log statistics details</para>
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
            /// <para>Whether the authentication passed.</para>
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
            /// <para>Sub-result code</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>Authentication interruption error codes</para>
            /// <list type="bullet">
            /// <item><description>1000: The user completed the face scanning process, and the suggested authentication result is pass</description></item>
            /// <item><description>1001: The user completed the face scanning process, and the suggested authentication result is fail</description></item>
            /// <item><description>1002: System error</description></item>
            /// <item><description>1003: SDK initialization failed, please check if the client time is correct</description></item>
            /// <item><description>1004: Camera permission error</description></item>
            /// <item><description>1005: Network error</description></item>
            /// <item><description>1006: User exited</description></item>
            /// <item><description>1007: Invalid TransactionId</description></item>
            /// <item><description>1009: Client timestamp error</description></item>
            /// <item><description>1011: Incorrect document type submitted</description></item>
            /// <item><description>1012: Missing or format validation failure of key information on the recognized document</description></item>
            /// <item><description>1013: Poor image quality</description></item>
            /// <item><description>1014: Exceeded the upper limit of errors</description></item>
            /// <item><description>1015: Android system version too low</description></item>
            /// <item><description>1016: Camera permission not obtained</description></item>
            /// <item><description>9999: Suspected authentication process interruption</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("VerifyErrorCode")]
            [Validation(Required=false)]
            public string VerifyErrorCode { get; set; }

            /// <summary>
            /// <para>Authentication status, values:</para>
            /// <list type="bullet">
            /// <item><description>0: finished (authentication completed)</description></item>
            /// <item><description>1: unfinished (authentication interrupted)</description></item>
            /// <item><description>2: notstart (authentication not started)</description></item>
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
