// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackEventInfoRequest : TeaModel {
        /// <summary>
        /// <para>Attacked asset. You can fill in the machine instance name, public IP, or private IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_**</para>
        /// </summary>
        [NameInMap("AttackInstance")]
        [Validation(Required=false)]
        public string AttackInstance { get; set; }

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
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <para>Page number to display in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Target port of the attack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9085</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public string DstPort { get; set; }

        /// <summary>
        /// <para>Timestamp of the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753152532550</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Set the language type for request and response messages. Default is <b>zh</b>. Values:</para>
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
        /// <para>Maximum number of records per page in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Source IP of the attack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>185.237.96.***</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        /// <summary>
        /// <para>Timestamp of the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1752547732549</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
