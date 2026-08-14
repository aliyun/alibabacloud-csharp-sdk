// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. This is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF11D6F6-E35A-41C3-9B20-6FC8A901FE65</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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

                [NameInMap("DisasterRecoveryInternetIp")]
                [Validation(Required=false)]
                public string DisasterRecoveryInternetIp { get; set; }

                [NameInMap("DisasterRecoveryVSwitchId")]
                [Validation(Required=false)]
                public string DisasterRecoveryVSwitchId { get; set; }

                [NameInMap("EnableBgp")]
                [Validation(Required=false)]
                public bool? EnableBgp { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("EniInstanceIds")]
                [Validation(Required=false)]
                public DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayEniInstanceIds EniInstanceIds { get; set; }
                public class DescribeVpnGatewaysResponseBodyVpnGatewaysVpnGatewayEniInstanceIds : TeaModel {
                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public List<string> EniInstanceId { get; set; }

                }

                [NameInMap("GatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

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

                [NameInMap("ReservationData")]
                [Validation(Required=false)]
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

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("SslMaxConnections")]
                [Validation(Required=false)]
                public long? SslMaxConnections { get; set; }

                [NameInMap("SslVpn")]
                [Validation(Required=false)]
                public string SslVpn { get; set; }

                [NameInMap("SslVpnInternetIp")]
                [Validation(Required=false)]
                public string SslVpnInternetIp { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

    }

}
