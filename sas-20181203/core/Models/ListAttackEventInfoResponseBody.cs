// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackEventInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of attack events.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAttackEventInfoResponseBodyList> List { get; set; }
        public class ListAttackEventInfoResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The attack type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>9: SQL Server brute-force attacks</description></item>
            /// <item><description>5: SSH brute-force attacks</description></item>
            /// <item><description>6: RDP brute-force attacks</description></item>
            /// <item><description>101: Java Struts2 attack blocked</description></item>
            /// <item><description>102: Redis attack blocked</description></item>
            /// <item><description>103: China Chopper (AntSword) WebShell communication</description></item>
            /// <item><description>104: China Chopper WebShell communication</description></item>
            /// <item><description>133: XISE WebShell communication</description></item>
            /// <item><description>161: WebShell upload</description></item>
            /// <item><description>209: PHP WebShell upload</description></item>
            /// <item><description>210: JSP WebShell upload</description></item>
            /// <item><description>211: ASP WebShell upload</description></item>
            /// <item><description>215: Special extension WebShell upload</description></item>
            /// <item><description>ai_webshell: WebShell upload intelligent defense</description></item>
            /// <item><description>java_common_rce: Java common RCE vulnerability blocked</description></item>
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
            /// <para>The mapped name of the attack type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>9: SQL Server brute-force attacks</description></item>
            /// <item><description>5: SSH brute-force attacks</description></item>
            /// <item><description>6: RDP brute-force attacks</description></item>
            /// <item><description>101: Java Struts2 attack blocked</description></item>
            /// <item><description>102: Redis attack blocked</description></item>
            /// <item><description>103: China Chopper (AntSword) WebShell communication</description></item>
            /// <item><description>104: China Chopper WebShell communication</description></item>
            /// <item><description>133: XISE WebShell communication</description></item>
            /// <item><description>161: WebShell upload</description></item>
            /// <item><description>209: PHP WebShell upload</description></item>
            /// <item><description>210: JSP WebShell upload</description></item>
            /// <item><description>211: ASP WebShell upload</description></item>
            /// <item><description>215: Special extension WebShell upload</description></item>
            /// <item><description>ai_webshell: WebShell upload intelligent defense</description></item>
            /// <item><description>java_common_rce: Java common RCE vulnerability blocked</description></item>
            /// <item><description>alinet_webrce: Adaptive web attack defense</description></item>
            /// <item><description>other: Other</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL Server brute-force attacks</para>
            /// </summary>
            [NameInMap("AttackTypeName")]
            [Validation(Required=false)]
            public string AttackTypeName { get; set; }

            /// <summary>
            /// <para>The number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The Attack Target Ports of the Attack Target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            /// <summary>
            /// <para>The time when the attack event first occurred, in timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752731615000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The time when the attack event first occurred, in string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-17 13:53:35</para>
            /// </summary>
            [NameInMap("FirstTimeStr")]
            [Validation(Required=false)]
            public string FirstTimeStr { get; set; }

            /// <summary>
            /// <para>The ID of the attack event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18825544674********</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance name of the attacked asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-0****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the attacked asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.37.86.**</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the attacked asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.0.**</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The time when the attack event most recently occurred.</para>
            /// <para>This field is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752731618000</para>
            /// </summary>
            [NameInMap("LatestTime")]
            [Validation(Required=false)]
            public long? LatestTime { get; set; }

            /// <summary>
            /// <para>The time when the attack event most recently occurred, in string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-17 13:53:38</para>
            /// </summary>
            [NameInMap("LatestTimeStr")]
            [Validation(Required=false)]
            public string LatestTimeStr { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the attack payload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a57b0d657369e4201eed8d47a4dc****</para>
            /// </summary>
            [NameInMap("PayloadMd5")]
            [Validation(Required=false)]
            public string PayloadMd5 { get; set; }

            /// <summary>
            /// <para>The Attack Source IP Addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>140.205.11.**</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <para>The attack status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>block: Blocked (defended).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the attacked asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The returned message of the request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAttackEventInfoResponseBodyPageInfo PageInfo { get; set; }
        public class ListAttackEventInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries to return on each page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52870893-48A7-5A9E-9E05-6253E5B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
