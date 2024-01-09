// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class DescribeSitePairStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PrimarySiteGatewayInfo")]
        [Validation(Required=false)]
        public DescribeSitePairStatisticsResponseBodyPrimarySiteGatewayInfo PrimarySiteGatewayInfo { get; set; }
        public class DescribeSitePairStatisticsResponseBodyPrimarySiteGatewayInfo : TeaModel {
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("HeartbeatedTime")]
            [Validation(Required=false)]
            public long? HeartbeatedTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("PrimarySiteServers")]
        [Validation(Required=false)]
        public DescribeSitePairStatisticsResponseBodyPrimarySiteServers PrimarySiteServers { get; set; }
        public class DescribeSitePairStatisticsResponseBodyPrimarySiteServers : TeaModel {
            [NameInMap("server")]
            [Validation(Required=false)]
            public List<DescribeSitePairStatisticsResponseBodyPrimarySiteServersServer> Server { get; set; }
            public class DescribeSitePairStatisticsResponseBodyPrimarySiteServersServer : TeaModel {
                [NameInMap("AgentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                [NameInMap("ConnectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecondarySiteGatewayInfo")]
        [Validation(Required=false)]
        public DescribeSitePairStatisticsResponseBodySecondarySiteGatewayInfo SecondarySiteGatewayInfo { get; set; }
        public class DescribeSitePairStatisticsResponseBodySecondarySiteGatewayInfo : TeaModel {
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("HeartbeatedTime")]
            [Validation(Required=false)]
            public long? HeartbeatedTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("SecondarySiteServers")]
        [Validation(Required=false)]
        public DescribeSitePairStatisticsResponseBodySecondarySiteServers SecondarySiteServers { get; set; }
        public class DescribeSitePairStatisticsResponseBodySecondarySiteServers : TeaModel {
            [NameInMap("server")]
            [Validation(Required=false)]
            public List<DescribeSitePairStatisticsResponseBodySecondarySiteServersServer> Server { get; set; }
            public class DescribeSitePairStatisticsResponseBodySecondarySiteServersServer : TeaModel {
                [NameInMap("AgentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                [NameInMap("ConnectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
