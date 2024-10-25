// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandWidthDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EPN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-20200825134537VyK81T</para>
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>If the value of the seconds place is not 00, the start time is automatically set to the next minute.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-16T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-cmcc</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5sg1owx0g4ojy66ab2tez77r2</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>cmcc</para>
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
        /// <para>SpeedUp</para>
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

        /// <summary>
        /// <para>The precision of the monitoring data that you want to obtain. Valid values: 300, 1200, 3600, and 14400. Default value: 300. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>If the value of the seconds place is not 00, the start time is automatically set to the next minute.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
