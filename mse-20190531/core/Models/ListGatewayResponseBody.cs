// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayResponseBodyData Data { get; set; }
        public class ListGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The data entries returned.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayResponseBodyDataResult> Result { get; set; }
            public class ListGatewayResponseBodyDataResult : TeaModel {
                /// <summary>
                /// Indicates whether Application High Availability Service (AHAS) is activated.
                /// </summary>
                [NameInMap("AhasOn")]
                [Validation(Required=false)]
                public bool? AhasOn { get; set; }

                /// <summary>
                /// The version of the application.
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// Indicates whether Application Real-Time Monitoring Service (ARMS) is activated.
                /// </summary>
                [NameInMap("ArmsOn")]
                [Validation(Required=false)]
                public bool? ArmsOn { get; set; }

                /// <summary>
                /// The billing method.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The current version of the gateway.
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                /// <summary>
                /// The time when the subscription gateway expires.
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// The type of the gateway.
                /// </summary>
                [NameInMap("GatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                /// <summary>
                /// The unique ID of the gateway.
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// The version of the gateway.
                /// </summary>
                [NameInMap("GatewayVersion")]
                [Validation(Required=false)]
                public string GatewayVersion { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The modification time.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the gateway.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The configurations.
                /// </summary>
                [NameInMap("InitConfig")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultInitConfig InitConfig { get; set; }
                public class ListGatewayResponseBodyDataResultInitConfig : TeaModel {
                    /// <summary>
                    /// Indicates whether Web Application Firewall (WAF) is enabled.
                    /// </summary>
                    [NameInMap("EnableWaf")]
                    [Validation(Required=false)]
                    public bool? EnableWaf { get; set; }

                    /// <summary>
                    /// Indicates whether WAF is supported.
                    /// </summary>
                    [NameInMap("SupportWaf")]
                    [Validation(Required=false)]
                    public bool? SupportWaf { get; set; }

                }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The details of the Internet-facing SLB instances.
                /// </summary>
                [NameInMap("InternetSlb")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultInternetSlb> InternetSlb { get; set; }
                public class ListGatewayResponseBodyDataResultInternetSlb : TeaModel {
                    /// <summary>
                    /// The mode of the SLB instance.
                    /// </summary>
                    [NameInMap("GatewaySlbMode")]
                    [Validation(Required=false)]
                    public string GatewaySlbMode { get; set; }

                    /// <summary>
                    /// The status of the SLB instance.
                    /// </summary>
                    [NameInMap("GatewaySlbStatus")]
                    [Validation(Required=false)]
                    public string GatewaySlbStatus { get; set; }

                    /// <summary>
                    /// The traffic of the gateway.
                    /// </summary>
                    [NameInMap("InternetNetworkFlow")]
                    [Validation(Required=false)]
                    public string InternetNetworkFlow { get; set; }

                    /// <summary>
                    /// The ID of the SLB instance.
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// The IP address of the SLB instance.
                    /// </summary>
                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    /// <summary>
                    /// The port number of the SLB instance.
                    /// </summary>
                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public string SlbPort { get; set; }

                    /// <summary>
                    /// The specifications of the SLB instance.
                    /// </summary>
                    [NameInMap("SlbSpec")]
                    [Validation(Required=false)]
                    public string SlbSpec { get; set; }

                    /// <summary>
                    /// The description of the status.
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// The type.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The latest version of the gateway.
                /// </summary>
                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                /// <summary>
                /// The tag of the instance.
                /// </summary>
                [NameInMap("MseTag")]
                [Validation(Required=false)]
                public string MseTag { get; set; }

                /// <summary>
                /// Indicates whether the gateway can be forcefully updated.
                /// </summary>
                [NameInMap("MustUpgrade")]
                [Validation(Required=false)]
                public bool? MustUpgrade { get; set; }

                /// <summary>
                /// The name of the gateway.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The information about the user.
                /// </summary>
                [NameInMap("PrimaryUser")]
                [Validation(Required=false)]
                public string PrimaryUser { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The number of replicas.
                /// </summary>
                [NameInMap("Replica")]
                [Validation(Required=false)]
                public int? Replica { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether rollbacks are allowed.
                /// </summary>
                [NameInMap("RollBack")]
                [Validation(Required=false)]
                public bool? RollBack { get; set; }

                /// <summary>
                /// The details of the Server Load Balancer (SLB) instances.
                /// </summary>
                [NameInMap("Slb")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultSlb> Slb { get; set; }
                public class ListGatewayResponseBodyDataResultSlb : TeaModel {
                    /// <summary>
                    /// The mode of the SLB instance.
                    /// </summary>
                    [NameInMap("GatewaySlbMode")]
                    [Validation(Required=false)]
                    public string GatewaySlbMode { get; set; }

                    /// <summary>
                    /// The status of the SLB instance.
                    /// </summary>
                    [NameInMap("GatewaySlbStatus")]
                    [Validation(Required=false)]
                    public string GatewaySlbStatus { get; set; }

                    /// <summary>
                    /// The ID of the SLB instance.
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// The IP address of the SLB instance.
                    /// </summary>
                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    /// <summary>
                    /// The port number of the SLB instance.
                    /// </summary>
                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public string SlbPort { get; set; }

                    /// <summary>
                    /// The specifications of the SLB instance.
                    /// </summary>
                    [NameInMap("SlbSpec")]
                    [Validation(Required=false)]
                    public string SlbSpec { get; set; }

                    /// <summary>
                    /// The description of the status.
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// The type.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The specifications of the gateway.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The gateway status.
                /// 
                /// *   0: The gateway is being created.
                /// *   1: The gateway fails to be created.
                /// *   2: The gateway is running.
                /// *   3: The gateway is changing.
                /// *   4: The gateway is scaling down.
                /// *   6: The gateway is scaling up.
                /// *   8: The gateway is being deleted.
                /// *   9: The gateway is suspended and to be released.
                /// *   10: The gateway is restarting.
                /// *   11: The gateway is being rebuilt.
                /// *   12: The gateway is updating.
                /// *   13: The gateway fails to be updated.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The description of the status.
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// Indicates whether WebAssembly (Wasm) is supported.
                /// </summary>
                [NameInMap("SupportWasm")]
                [Validation(Required=false)]
                public bool? SupportWasm { get; set; }

                /// <summary>
                /// The tag.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// Indicates whether the gateway can be updated.
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

                /// <summary>
                /// The ID of the secondary vSwitch.
                /// </summary>
                [NameInMap("Vswitch2")]
                [Validation(Required=false)]
                public string Vswitch2 { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
