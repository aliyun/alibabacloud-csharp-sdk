// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosOriginInstanceBillRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp. Unit: milliseconds. The time span between StartTime and EndTime cannot exceed 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1711382399410</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the bill details. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsShowList")]
        [Validation(Required=false)]
        public bool? IsShowList { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a timestamp. Unit: milliseconds.</para>
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
        /// <item><description><b>flow_cn</b>: the bill for the clean bandwidth of elastic IP addresses (EIPs) with Anti-DDoS (Enhanced) enabled in the Chinese mainland</description></item>
        /// <item><description><b>flow_ov</b>: the bill for the clean bandwidth of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland</description></item>
        /// <item><description><b>standard_assets_flow_cn</b>: the bill for the clean bandwidth of regular Alibaba Cloud services in the Chinese mainland</description></item>
        /// <item><description><b>standard_assets_flow_ov</b>: the bill for the clean bandwidth of regular Alibaba Cloud services outside the Chinese mainland</description></item>
        /// <item><description><b>function</b>: the bill for the basic fee</description></item>
        /// <item><description><b>ip_count</b>: the bill for protected IP addresses</description></item>
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
