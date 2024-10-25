// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandwitdhByInternetChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("BandwidthValue")]
        [Validation(Required=false)]
        public long? BandwidthValue { get; set; }

        /// <summary>
        /// <para>The metering method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BandwidthByDay: Pay by daily peak bandwidth</description></item>
        /// <item><description>95BandwidthByMonth: Pay by monthly 95th percentile bandwidth</description></item>
        /// <item><description>PayByBandwidth4thMonth: Pay by monthly fourth peak bandwidth</description></item>
        /// <item><description>PayByBandwidth: Pay by fixed bandwidth</description></item>
        /// </list>
        /// <para>You can specify only one metering method for network usage and cannot overwrite the existing metering method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthByDay</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>216BCED0-E055-5DDB-8E06-4084A62A4A44</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The timestamp when the monitoring data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-12T05:45:00Z</para>
        /// </summary>
        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

    }

}
