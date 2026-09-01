// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackEventInfoRequest : TeaModel {
        /// <summary>
        /// <para>The attacked asset. You can specify the instance name, public IP address, or private IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_**</para>
        /// </summary>
        [NameInMap("AttackInstance")]
        [Validation(Required=false)]
        public string AttackInstance { get; set; }

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
        /// <item><description>java_common_rce: Java common remote code execution (RCE) vulnerability blocked</description></item>
        /// <item><description>alinet_webrce: Adaptive web attack defense</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <para>The number of the page to return in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The Attack Target Ports of the Attack Target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9085</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public string DstPort { get; set; }

        /// <summary>
        /// <para>The timestamp of the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753152532550</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

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
        /// <para>The Attack Source IP Addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>185.237.96.***</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        /// <summary>
        /// <para>The timestamp of the start time.</para>
        /// <para>This field is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1752547732549</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
