// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewayResponseBody : TeaModel {
        [NameInMap("AutoPropagate")]
        [Validation(Required=false)]
        public bool? AutoPropagate { get; set; }

        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableBgp")]
        [Validation(Required=false)]
        public bool? EnableBgp { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        [NameInMap("IpsecVpn")]
        [Validation(Required=false)]
        public string IpsecVpn { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReservationData")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyReservationData ReservationData { get; set; }
        public class DescribeVpnGatewayResponseBodyReservationData : TeaModel {
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

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("SslMaxConnections")]
        [Validation(Required=false)]
        public long? SslMaxConnections { get; set; }

        [NameInMap("SslVpn")]
        [Validation(Required=false)]
        public string SslVpn { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVpnGatewayResponseBodyTags Tags { get; set; }
        public class DescribeVpnGatewayResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVpnGatewayResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVpnGatewayResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        [NameInMap("VpnType")]
        [Validation(Required=false)]
        public string VpnType { get; set; }

    }

}
