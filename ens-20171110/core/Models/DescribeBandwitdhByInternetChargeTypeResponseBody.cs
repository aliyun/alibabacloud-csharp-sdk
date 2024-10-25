// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeBandwitdhByInternetChargeTypeResponseBody : TeaModel {
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
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08027633-8501-5A36-B90D-F7C38B5EC75D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The timestamp. The time follows the ISO 8601 standard. The time is displayed in UTC. Example: 2016-10-20T04:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-12T05:45:00Z</para>
        /// </summary>
        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

    }

}
