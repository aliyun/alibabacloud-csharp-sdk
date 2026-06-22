// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventsRequest : TeaModel {
        /// <summary>
        /// <para>The list of probe IDs.</para>
        /// </summary>
        [NameInMap("AgentIdList")]
        [Validation(Required=false)]
        public List<string> AgentIdList { get; set; }

        /// <summary>
        /// <para>The ID of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1259925</para>
        /// </summary>
        [NameInMap("AlarmEventId")]
        [Validation(Required=false)]
        public long? AlarmEventId { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>y</b>: Handled.</description></item>
        /// <item><description><b>n</b>: Unhandled.</description></item>
        /// <item><description><b>a</b>: All.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>y</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The list of honeypot IDs.</para>
        /// </summary>
        [NameInMap("HoneypotIdList")]
        [Validation(Required=false)]
        public List<string> HoneypotIdList { get; set; }

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
        /// <para>The maximum number of entries per page in a paging query. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the attacker portrait.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd48604a-1694-4f03-ade0-ec6994c3*****</para>
        /// </summary>
        [NameInMap("PortraitId")]
        [Validation(Required=false)]
        public string PortraitId { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F9CE167-58D5-5DA6-AA3B-923EED02****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of risk levels.</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        /// <summary>
        /// <para>The source IP address of the attack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>185.237.96.***</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

    }

}
