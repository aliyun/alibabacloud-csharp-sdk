// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorConfigResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
