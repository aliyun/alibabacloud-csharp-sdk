// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAlarmEventsRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The status of the alert event. Default value: <b>a</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>a</b>: all states</description></item>
        /// <item><description><b>y</b>: handled</description></item>
        /// <item><description><b>n</b>: unhandled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The destination IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.XX.XX</para>
        /// </summary>
        [NameInMap("DstIp")]
        [Validation(Required=false)]
        public string DstIp { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100. If you leave this parameter empty, 100 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty. We recommend that you set the value to a value no greater than 100.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The risk levels.</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.132.XX.XX</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

    }

}
