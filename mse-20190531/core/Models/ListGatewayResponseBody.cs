// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayResponseBodyData Data { get; set; }
        public class ListGatewayResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayResponseBodyDataResult> Result { get; set; }
            public class ListGatewayResponseBodyDataResult : TeaModel {
                [NameInMap("AhasOn")]
                [Validation(Required=false)]
                public bool? AhasOn { get; set; }

                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                [NameInMap("ArmsOn")]
                [Validation(Required=false)]
                public bool? ArmsOn { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("GatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("GatewayVersion")]
                [Validation(Required=false)]
                public string GatewayVersion { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InitConfig")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultInitConfig InitConfig { get; set; }
                public class ListGatewayResponseBodyDataResultInitConfig : TeaModel {
                    [NameInMap("EnableWaf")]
                    [Validation(Required=false)]
                    public bool? EnableWaf { get; set; }

                    [NameInMap("SupportWaf")]
                    [Validation(Required=false)]
                    public bool? SupportWaf { get; set; }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InternetSlb")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultInternetSlb> InternetSlb { get; set; }
                public class ListGatewayResponseBodyDataResultInternetSlb : TeaModel {
                    [NameInMap("GatewaySlbMode")]
                    [Validation(Required=false)]
                    public string GatewaySlbMode { get; set; }

                    [NameInMap("GatewaySlbStatus")]
                    [Validation(Required=false)]
                    public string GatewaySlbStatus { get; set; }

                    [NameInMap("InternetNetworkFlow")]
                    [Validation(Required=false)]
                    public string InternetNetworkFlow { get; set; }

                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public string SlbPort { get; set; }

                    [NameInMap("SlbSpec")]
                    [Validation(Required=false)]
                    public string SlbSpec { get; set; }

                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                [NameInMap("MustUpgrade")]
                [Validation(Required=false)]
                public bool? MustUpgrade { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PrimaryUser")]
                [Validation(Required=false)]
                public string PrimaryUser { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Replica")]
                [Validation(Required=false)]
                public int? Replica { get; set; }

                [NameInMap("RollBack")]
                [Validation(Required=false)]
                public bool? RollBack { get; set; }

                [NameInMap("Slb")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultSlb> Slb { get; set; }
                public class ListGatewayResponseBodyDataResultSlb : TeaModel {
                    [NameInMap("GatewaySlbMode")]
                    [Validation(Required=false)]
                    public string GatewaySlbMode { get; set; }

                    [NameInMap("GatewaySlbStatus")]
                    [Validation(Required=false)]
                    public string GatewaySlbStatus { get; set; }

                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public string SlbPort { get; set; }

                    [NameInMap("SlbSpec")]
                    [Validation(Required=false)]
                    public string SlbSpec { get; set; }

                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                [NameInMap("SupportWasm")]
                [Validation(Required=false)]
                public bool? SupportWasm { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

                [NameInMap("Vswitch2")]
                [Validation(Required=false)]
                public string Vswitch2 { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
