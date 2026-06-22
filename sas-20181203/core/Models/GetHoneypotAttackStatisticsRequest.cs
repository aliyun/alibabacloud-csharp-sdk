// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotAttackStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return. Minimum value: <b>1</b>. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time in timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1675058931215</para>
        /// </summary>
        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public long? EndTimeStamp { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paged query. Default value: 20. If you leave this parameter empty, 20 entries are returned by default. &gt; Specify a value for the paging parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of risk levels.</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        /// <summary>
        /// <para>The IP address of the attack source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.92.139.**</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        /// <summary>
        /// <para>The start time in timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681624877761</para>
        /// </summary>
        [NameInMap("StartTimeStamp")]
        [Validation(Required=false)]
        public long? StartTimeStamp { get; set; }

        /// <summary>
        /// <para>The type of attack source statistics information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TOP_ATTACKED_AGENT</b>: the top 5 probes by number of attacks.</description></item>
        /// <item><description><b>TOP_ATTACKED_IP</b>: the top 5 IP addresses by number of attacks.</description></item>
        /// <item><description><b>ATTACK_EVENT_TYPE</b>: the intrusion event type.</description></item>
        /// <item><description><b>ATTACK_HONEYPOT_TYPE</b>: the type of the compromised honeypot.</description></item>
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
