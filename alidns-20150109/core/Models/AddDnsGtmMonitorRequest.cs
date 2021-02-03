// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmMonitorRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("AddrPoolId")]
        [Validation(Required=true)]
        public string AddrPoolId { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=true)]
        public string ProtocolType { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=true)]
        public int? Interval { get; set; }

        [NameInMap("EvaluationCount")]
        [Validation(Required=true)]
        public int? EvaluationCount { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=true)]
        public int? Timeout { get; set; }

        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=true)]
        public string MonitorExtendInfo { get; set; }

        [NameInMap("IspCityNode")]
        [Validation(Required=true)]
        public List<AddDnsGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class AddDnsGtmMonitorRequestIspCityNode : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

    }

}
