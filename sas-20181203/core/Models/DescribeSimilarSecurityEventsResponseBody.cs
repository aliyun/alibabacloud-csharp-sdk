// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSimilarSecurityEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSimilarSecurityEventsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSimilarSecurityEventsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F4217C8-763F-51EF-84D4-5535E072B2D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the alert events that are triggered by the same rule or of the same alert type.</para>
        /// </summary>
        [NameInMap("SecurityEventsResponse")]
        [Validation(Required=false)]
        public List<DescribeSimilarSecurityEventsResponseBodySecurityEventsResponse> SecurityEventsResponse { get; set; }
        public class DescribeSimilarSecurityEventsResponseBodySecurityEventsResponse : TeaModel {
            /// <summary>
            /// <para>The name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Trojan</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The type of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Suspicious Process</description></item>
            /// <item><description>Webshell</description></item>
            /// <item><description>Unusual Logon</description></item>
            /// <item><description>Malicious Software</description></item>
            /// <item><description>Sensitive File Tampering</description></item>
            /// <item><description>Unusual Network Connection</description></item>
            /// <item><description>Other</description></item>
            /// <item><description>Suspicious Account</description></item>
            /// <item><description>Cloud threat detection</description></item>
            /// <item><description>Precision defense</description></item>
            /// <item><description>Application Whitelist</description></item>
            /// <item><description>Persistence</description></item>
            /// <item><description>Web Application Threat Detection</description></item>
            /// <item><description>Malicious scripts</description></item>
            /// <item><description>Malicious Network Activity</description></item>
            /// <item><description>K8s Abnormal Behavior</description></item>
            /// <item><description>Website backdoor (local engine)</description></item>
            /// <item><description>Exploit</description></item>
            /// <item><description>Image Scan</description></item>
            /// <item><description>Trusted exception</description></item>
            /// </list>
            /// <para>For more information about alert types, see <a href="https://help.aliyun.com/document_detail/68388.html">Overview</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Malicious Software</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the alert event was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648544361480</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the alert event was first detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648457961000</para>
            /// </summary>
            [NameInMap("OccurrenceTime")]
            [Validation(Required=false)]
            public long? OccurrenceTime { get; set; }

            /// <summary>
            /// <para>The ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>158661</para>
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            /// <summary>
            /// <para>The UUID of the server that was affected by the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qweeqq-13232-daweq-w****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
