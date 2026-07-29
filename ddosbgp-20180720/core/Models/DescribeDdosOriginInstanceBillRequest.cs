// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosOriginInstanceBillRequest : TeaModel {
        /// <summary>
        /// <para>The end timestamp of the query. Unit: milliseconds. The time span cannot exceed 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1711382399410</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to display billing details. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Displays billing information.</description></item>
        /// <item><description><b>false</b>: Displays only global instance information without billing details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsShowList")]
        [Validation(Required=false)]
        public bool? IsShowList { get; set; }

        /// <summary>
        /// <para>The start timestamp of the query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1711209600410</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The bill type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>flow_cn</b>: clean traffic bill for EIPs with Anti-DDoS (Enhanced) enabled in the Chinese mainland.</description></item>
        /// <item><description><b>flow_ov</b>: clean traffic bill for EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland.</description></item>
        /// <item><description><b>standard_assets_flow_cn</b>: clean traffic bill for Regular Alibaba Cloud services in the Chinese mainland.</description></item>
        /// <item><description><b>standard_assets_flow_ov</b>: clean traffic bill for Regular Alibaba Cloud services outside the Chinese mainland.</description></item>
        /// <item><description><b>function</b>: feature activation bill.</description></item>
        /// <item><description><b>ip_count</b>: protected IP address count bill.</description></item>
        /// <item><description><b>monthly_summary</b>: monthly summary bill.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>function</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
