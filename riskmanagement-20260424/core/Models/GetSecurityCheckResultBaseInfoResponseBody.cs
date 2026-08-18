// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetSecurityCheckResultBaseInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para> 200: The request was successful. Other codes (such as 500 or 400): An error occurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSecurityCheckResultBaseInfoResponseBodyData Data { get; set; }
        public class GetSecurityCheckResultBaseInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration item check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigCompleted")]
            [Validation(Required=false)]
            public string ConfigCompleted { get; set; }

            /// <summary>
            /// <para>The number of pending security alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PendingSecurityAlertCount")]
            [Validation(Required=false)]
            public int? PendingSecurityAlertCount { get; set; }

            /// <summary>
            /// <para>The number of pending vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PendingVulnerabilityCount")]
            [Validation(Required=false)]
            public int? PendingVulnerabilityCount { get; set; }

            /// <summary>
            /// <para>The percentage of the health check task progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>739705BB-B0EF-554B-B3A8-383F4F93E067</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current API call itself was successful. This does not indicate the success of subsequent business operations.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
