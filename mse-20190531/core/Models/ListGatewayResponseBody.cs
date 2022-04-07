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
                public bool? AhasOn { get; set; }
                public bool? ArmsOn { get; set; }
                public string ChargeType { get; set; }
                public string CurrentVersion { get; set; }
                public string EndDate { get; set; }
                public string GatewayType { get; set; }
                public string GatewayUniqueId { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public ListGatewayResponseBodyDataResultInitConfig InitConfig { get; set; }
                public class ListGatewayResponseBodyDataResultInitConfig : TeaModel {
                    [NameInMap("EnableWaf")]
                    [Validation(Required=false)]
                    public bool? EnableWaf { get; set; }

                    [NameInMap("SupportWaf")]
                    [Validation(Required=false)]
                    public bool? SupportWaf { get; set; }

                }
                public string InstanceId { get; set; }
                public List<ListGatewayResponseBodyDataResultInternetSlb> InternetSlb { get; set; }
                public class ListGatewayResponseBodyDataResultInternetSlb : TeaModel {
                    public string GatewaySlbMode { get; set; }
                    public string GatewaySlbStatus { get; set; }
                    public string InternetNetworkFlow { get; set; }
                    public string SlbId { get; set; }
                    public string SlbIp { get; set; }
                    public string SlbPort { get; set; }
                    public string SlbSpec { get; set; }
                    public string StatusDesc { get; set; }
                    public string Type { get; set; }
                }
                public string LatestVersion { get; set; }
                public bool? MustUpgrade { get; set; }
                public string Name { get; set; }
                public string PrimaryUser { get; set; }
                public string Region { get; set; }
                public int? Replica { get; set; }
                public List<ListGatewayResponseBodyDataResultSlb> Slb { get; set; }
                public class ListGatewayResponseBodyDataResultSlb : TeaModel {
                    public string GatewaySlbMode { get; set; }
                    public string GatewaySlbStatus { get; set; }
                    public string SlbId { get; set; }
                    public string SlbIp { get; set; }
                    public string SlbPort { get; set; }
                    public string SlbSpec { get; set; }
                    public string StatusDesc { get; set; }
                    public string Type { get; set; }
                }
                public string Spec { get; set; }
                public int? Status { get; set; }
                public string StatusDesc { get; set; }
                public string Tag { get; set; }
                public bool? Upgrade { get; set; }
                public string Vswitch2 { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
