// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBgpBpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the device. If you specify this parameter, the data of the device is returned. Otherwise, the data of all devices is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>devicename</para>
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// <para>The port of the device. If you specify this parameter, the data of the port is returned. Otherwise, the data of all ports is returned. This parameter takes effect only when the <b>DeviceName</b> parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DevicePort")]
        [Validation(Required=false)]
        public string DevicePort { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-11-30T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The data collection interval. Unit: seconds. Valid values: 300 and 3600. Default value: 300. The default value of 300 seconds is equal to 5 minutes. The value of this parameter varies based on the time range from the specified start time to the specified end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The ISPs. If you need to specify multiple ISPs, separate them with commas (,). If you specify multiple ISPs, the data for the ISPs is aggregated. If you do not specify this parameter, the operation returns the data for all the ISPs.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cu: China Unicom</description></item>
        /// <item><description>cmi: China Mobile</description></item>
        /// <item><description>ct: China Telecom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cu</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>The minimum data collection interval is an hour.</para>
        /// <para>If you do not set this parameter, data collected in the last 24 hours is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-11-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
