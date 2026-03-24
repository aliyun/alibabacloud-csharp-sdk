// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackEventInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code, <b>200</b> indicates success, any other value indicates failure. The caller can use this field to determine the reason for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code, 200 indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>List of attack events.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAttackEventInfoResponseBodyList> List { get; set; }
        public class ListAttackEventInfoResponseBodyList : TeaModel {
            /// <summary>
            /// <para>Attack type. Values:</para>
            /// <list type="bullet">
            /// <item><description>9: SQL Server brute force attack</description></item>
            /// <item><description>5: SSH brute force attack</description></item>
            /// <item><description>6: RDP brute force attack</description></item>
            /// <item><description>101: Java Struts2 attack interception</description></item>
            /// <item><description>102: Redis attack interception</description></item>
            /// <item><description>103: Chinese AntSword WebShell communication</description></item>
            /// <item><description>104: Chinese Chopper WebShell communication</description></item>
            /// <item><description>133: XISE WebShell communication</description></item>
            /// <item><description>161: WebShell upload</description></item>
            /// <item><description>209: PHP WebShell upload</description></item>
            /// <item><description>210: JSP WebShell upload</description></item>
            /// <item><description>211: ASP WebShell upload</description></item>
            /// <item><description>215: Special suffix WebShell upload</description></item>
            /// <item><description>ai_webshell: Intelligent defense for WebShell upload</description></item>
            /// <item><description>java_common_rce: Java common RCE vulnerability interception</description></item>
            /// <item><description>alinet_webrce: Adaptive web attack defense</description></item>
            /// <item><description>other: Other</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public string AttackType { get; set; }

            /// <summary>
            /// <para>Mapped name of the attack type. Values:</para>
            /// <list type="bullet">
            /// <item><description>9: SQL Server brute force</description></item>
            /// <item><description>5: SSH brute force</description></item>
            /// <item><description>6: RDP brute force</description></item>
            /// <item><description>101: Java Struts2 attack interception</description></item>
            /// <item><description>102: Redis attack interception</description></item>
            /// <item><description>103: Chinese AntSword WebShell communication</description></item>
            /// <item><description>104: Chinese Chopper WebShell communication</description></item>
            /// <item><description>133: XISE WebShell communication</description></item>
            /// <item><description>161: WebShell upload</description></item>
            /// <item><description>209: PHP WebShell upload</description></item>
            /// <item><description>210: JSP WebShell upload</description></item>
            /// <item><description>211: ASP WebShell upload</description></item>
            /// <item><description>215: Special suffix WebShell upload</description></item>
            /// <item><description>ai_webshell: Intelligent defense for WebShell upload</description></item>
            /// <item><description>java_common_rce: Java common RCE vulnerability interception</description></item>
            /// <item><description>alinet_webrce: Adaptive web attack defense</description></item>
            /// <item><description>other: Other</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL Server暴力破解</para>
            /// </summary>
            [NameInMap("AttackTypeName")]
            [Validation(Required=false)]
            public string AttackTypeName { get; set; }

            /// <summary>
            /// <para>Number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>Target port of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            /// <summary>
            /// <para>First occurrence time of the attack event, in timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752731615000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>String representation of the first occurrence time of the attack event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-17 13:53:35</para>
            /// </summary>
            [NameInMap("FirstTimeStr")]
            [Validation(Required=false)]
            public string FirstTimeStr { get; set; }

            /// <summary>
            /// <para>ID of the attack event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18825544674********</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Instance name of the attacked asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-0****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Public IP of the attacked asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.37.86.**</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>Private IP of the attacked asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.0.**</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>Timestamp of the most recent occurrence of the attack event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752731618000</para>
            /// </summary>
            [NameInMap("LatestTime")]
            [Validation(Required=false)]
            public long? LatestTime { get; set; }

            /// <summary>
            /// <para>String representation of the most recent occurrence time of the attack event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-17 13:53:38</para>
            /// </summary>
            [NameInMap("LatestTimeStr")]
            [Validation(Required=false)]
            public string LatestTimeStr { get; set; }

            /// <summary>
            /// <para>MD5 string of the attack payload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a57b0d657369e4201eed8d47a4dc****</para>
            /// </summary>
            [NameInMap("PayloadMd5")]
            [Validation(Required=false)]
            public string PayloadMd5 { get; set; }

            /// <summary>
            /// <para>Source IP of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>140.205.11.**</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <para>Attack status. Values:</para>
            /// <list type="bullet">
            /// <item><description>block: Blocked (defended)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>UUID of the attacked asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>Return message of the request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAttackEventInfoResponseBodyPageInfo PageInfo { get; set; }
        public class ListAttackEventInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>Number of items displayed on the current page in pagination queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>Page number in pagination queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Maximum number of items per page in pagination queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, a unique identifier generated by Alibaba Cloud for the request, which can be used to troubleshoot and pinpoint issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52870893-48A7-5A9E-9E05-6253E5B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Success</description></item>
        /// <item><description><b>false</b>: Failure</description></item>
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
