// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetInternetTupleShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of member accounts.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<long?> AccountIds { get; set; }

        /// <summary>
        /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// The local IP address.
        /// </summary>
        [NameInMap("CloudIp")]
        [Validation(Required=false)]
        public string CloudIp { get; set; }

        /// <summary>
        /// The local IP addresses for filtering.
        /// </summary>
        [NameInMap("CloudIpList")]
        [Validation(Required=false)]
        public string CloudIpListShrink { get; set; }

        /// <summary>
        /// The local Internet service provider (ISP).
        /// 
        /// >  In most cases, the value is Alibaba or Alibaba Cloud.
        /// </summary>
        [NameInMap("CloudIsp")]
        [Validation(Required=false)]
        public string CloudIsp { get; set; }

        /// <summary>
        /// The local port.
        /// 
        /// >  This parameter is required only if you set GroupBy to CloudPort.
        /// </summary>
        [NameInMap("CloudPort")]
        [Validation(Required=false)]
        public string CloudPort { get; set; }

        /// <summary>
        /// The direction of the Internet traffic that you want to query. Valid values:
        /// 
        /// *   **in**: inbound
        /// *   **out**: outbound
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The instance IDs for filtering.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceListShrink { get; set; }

        /// <summary>
        /// The metric for data ranking. Default value: **ByteCount**. This value indicates that Internet traffic data is ranked by traffic volume.
        /// 
        /// Valid values:
        /// 
        /// *   Rtt
        /// *   ByteCount
        /// *   PacketCount
        /// *   RetransmitRate
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The remote city.
        /// 
        /// >  This parameter is required only if you set **TupleType** to **2** or **5**.
        /// </summary>
        [NameInMap("OtherCity")]
        [Validation(Required=false)]
        public string OtherCity { get; set; }

        /// <summary>
        /// The remote country.
        /// 
        /// >  This parameter is required only if you set **TupleType** to **2** or **5**.
        /// </summary>
        [NameInMap("OtherCountry")]
        [Validation(Required=false)]
        public string OtherCountry { get; set; }

        /// <summary>
        /// The remote IP address.
        /// 
        /// > This parameter is required only when you set **TupleType** to **2** or **5**.
        /// </summary>
        [NameInMap("OtherIp")]
        [Validation(Required=false)]
        public string OtherIp { get; set; }

        /// <summary>
        /// The remote ISP.
        /// 
        /// > This parameter is required if you want to view the information about the remote ISP.
        /// </summary>
        [NameInMap("OtherIsp")]
        [Validation(Required=false)]
        public string OtherIsp { get; set; }

        /// <summary>
        /// The remote port.
        /// 
        /// > This parameter is required only when you set **TupleType** to **5**.
        /// </summary>
        [NameInMap("OtherPort")]
        [Validation(Required=false)]
        public string OtherPort { get; set; }

        /// <summary>
        /// The protocol number.
        /// 
        /// > All protocols are supported. This parameter is required only when you set **TupleType** to **5**.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The ID of the region for which you want to query the Internet traffic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The order in which instances are ranked by Internet traffic. Valid values:
        /// 
        /// *   **desc**: the descending order
        /// *   **asc**: the ascending order
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// Specifies top-N traffic data to display. Default value: **10**. This value specifies to display top-10 traffic data by default. Max value: **100**.
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// The type of the tuple. Valid values:
        /// 
        /// *   **1**: 1-tuple
        /// *   **2**: 2-tuple
        /// *   **5**: 5-tuple
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TupleType")]
        [Validation(Required=false)]
        public int? TupleType { get; set; }

        /// <summary>
        /// Specifies whether to enable the multi-account management feature. Default value: **false**. This value specifies that the multi-account management feature is disabled.
        /// 
        /// >  By default, the multi-account management feature is not available. If you want to use this feature, contact your account manager to apply for permissions.
        /// </summary>
        [NameInMap("UseMultiAccount")]
        [Validation(Required=false)]
        public bool? UseMultiAccount { get; set; }

    }

}
