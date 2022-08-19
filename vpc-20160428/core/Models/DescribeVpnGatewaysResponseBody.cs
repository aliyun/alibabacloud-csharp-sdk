// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewaysResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnGateways")]
        [Validation(Required=false)]
        public DescribeVpnGatewaysResponseBodyVpnGateways VpnGateways { get; set; }
        public class DescribeVpnGatewaysResponseBodyVpnGateways : TeaModel {
            [NameInMap("VpnGateway")]
            [Validation(Required=false)]
            public List<DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGateway> VpnGateway { get; set; }
            public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGateway : TeaModel {
                public bool? AutoPropagate { get; set; }
                public string BusinessStatus { get; set; }
                public string ChargeType { get; set; }
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public bool? EnableBgp { get; set; }
                public long? EndTime { get; set; }
                public string InternetIp { get; set; }
                public string IpsecVpn { get; set; }
                public string Name { get; set; }
                public string NetworkType { get; set; }
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayReservationData ReservationData { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayReservationData : TeaModel {
                    [NameInMap("ReservationEndTime")]
                    [Validation(Required=false)]
                    public string ReservationEndTime { get; set; }

                    [NameInMap("ReservationIpsec")]
                    [Validation(Required=false)]
                    public string ReservationIpsec { get; set; }

                    [NameInMap("ReservationMaxConnections")]
                    [Validation(Required=false)]
                    public int? ReservationMaxConnections { get; set; }

                    [NameInMap("ReservationOrderType")]
                    [Validation(Required=false)]
                    public string ReservationOrderType { get; set; }

                    [NameInMap("ReservationSpec")]
                    [Validation(Required=false)]
                    public string ReservationSpec { get; set; }

                    [NameInMap("ReservationSsl")]
                    [Validation(Required=false)]
                    public string ReservationSsl { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }
                public string Spec { get; set; }
                public long? SslMaxConnections { get; set; }
                public string SslVpn { get; set; }
                public string Status { get; set; }
                public string Tag { get; set; }
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTags Tags { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTagsTag> Tag { get; set; }
                    public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string VSwitchId { get; set; }
                public string VpcId { get; set; }
                public string VpnGatewayId { get; set; }
                public string VpnType { get; set; }
            }
        };

    }

}
