// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeBandwitdhByInternetChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>If the value of the seconds place is not 00, the start time is automatically set to the next minute.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-18T09:39:54Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-cbn-2</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The Internet service provider (ISP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cmcc: China Mobile</description></item>
        /// <item><description>telecom: China Telecom</description></item>
        /// <item><description>unicom: China Unicom</description></item>
        /// <item><description>multiCarrier: multi-line ISP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>If the value of the seconds place is not 00, the start time is automatically set to the next minute.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-15T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
