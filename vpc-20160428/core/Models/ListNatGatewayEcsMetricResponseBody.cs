// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatGatewayEcsMetricResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("MetricDataList")]
        [Validation(Required=false)]
        public List<ListNatGatewayEcsMetricResponseBodyMetricDataList> MetricDataList { get; set; }
        public class ListNatGatewayEcsMetricResponseBodyMetricDataList : TeaModel {
            [NameInMap("ActiveSessionNum")]
            [Validation(Required=false)]
            public long? ActiveSessionNum { get; set; }

            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            [NameInMap("NewSessionRate")]
            [Validation(Required=false)]
            public long? NewSessionRate { get; set; }

            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            [NameInMap("RxBps")]
            [Validation(Required=false)]
            public long? RxBps { get; set; }

            [NameInMap("RxPps")]
            [Validation(Required=false)]
            public long? RxPps { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("TxBps")]
            [Validation(Required=false)]
            public long? TxBps { get; set; }

            [NameInMap("TxPps")]
            [Validation(Required=false)]
            public long? TxPps { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
