// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandwitdhByInternetChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>If the value of the seconds place is not 00, the start time is automatically set to the next minute.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-06T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-changsha-unicom</para>
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
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The networking mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SpeedUp</b>: intelligent acceleration network (Internet)</description></item>
        /// <item><description><b>Connection</b>: internal network</description></item>
        /// <item><description><b>SpeedUpAndConnection</b>: intelligent acceleration network and internal network</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Connection</para>
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>If the value of the seconds place is not 00, the start time is automatically set to the next minute.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-02T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
