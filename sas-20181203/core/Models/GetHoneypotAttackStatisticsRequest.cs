// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotAttackStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>Set the page number from which to start displaying the query results. The starting value is <b>1</b>. The default value is <b>1</b>, indicating that the display starts from the <b>1st</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>End time, in timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1675058931215</para>
        /// </summary>
        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public long? EndTimeStamp { get; set; }

        /// <summary>
        /// <para>Sets the language type for requests and received messages, default is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese </description></item>
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
        /// <para>Specifies the maximum number of data entries displayed per page for paginated queries. The default number of entries displayed per page is 20. If the pagesize parameter is empty, 20 entries will be returned by default. It is recommended that the pagesize value should not be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of risk levels</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        /// <summary>
        /// <para>Attacker\&quot;s IP</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.92.139.**</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        /// <summary>
        /// <para>Start time, in timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681624877761</para>
        /// </summary>
        [NameInMap("StartTimeStamp")]
        [Validation(Required=false)]
        public long? StartTimeStamp { get; set; }

        /// <summary>
        /// <para>The type of attack source statistics. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>TOP_ATTACKED_AGENT</b>: Top 5 most attacked probes. </description></item>
        /// <item><description><b>TOP_ATTACKED_IP</b>: Top 5 most attacked IP addresses.</description></item>
        /// <item><description><b>ATTACK_EVENT_TYPE</b>: Type of intrusion event. </description></item>
        /// <item><description><b>ATTACK_HONEYPOT_TYPE</b>: Type of compromised honeypot.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TOP_ATTACKED_IP</para>
        /// </summary>
        [NameInMap("StatisticsType")]
        [Validation(Required=false)]
        public string StatisticsType { get; set; }

    }

}
