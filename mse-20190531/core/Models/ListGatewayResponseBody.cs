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
        /// The data returned.
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
            /// The data returned.
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
                /// Indicates whether auto scale-out is enabled.
                /// </summary>
                [NameInMap("Elastic")]
                [Validation(Required=false)]
                public bool? Elastic { get; set; }

                /// <summary>
                /// The ID of the elastic gateway. This parameter is returned if auto scale-out is used.
                /// </summary>
                [NameInMap("ElasticInstanceId")]
                [Validation(Required=false)]
                public string ElasticInstanceId { get; set; }

                /// <summary>
                /// The auto scale-out policy.
                /// </summary>
                [NameInMap("ElasticPolicy")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultElasticPolicy ElasticPolicy { get; set; }
                public class ListGatewayResponseBodyDataResultElasticPolicy : TeaModel {
                    /// <summary>
                    /// Indicates whether auto scale-out is enabled.
                    /// </summary>
                    [NameInMap("Elastic")]
                    [Validation(Required=false)]
                    public bool? Elastic { get; set; }

                    /// <summary>
                    /// The type of auto scale-out. Valid value:
                    /// 
                    /// *   CronHPA: scale-out by time
                    /// </summary>
                    [NameInMap("ElasticType")]
                    [Validation(Required=false)]
                    public string ElasticType { get; set; }

                    [NameInMap("EnableScaleTimePolicyList")]
                    [Validation(Required=false)]
                    public List<ListGatewayResponseBodyDataResultElasticPolicyEnableScaleTimePolicyList> EnableScaleTimePolicyList { get; set; }
                    public class ListGatewayResponseBodyDataResultElasticPolicyEnableScaleTimePolicyList : TeaModel {
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    [NameInMap("LoadWarningThreshold")]
                    [Validation(Required=false)]
                    public bool? LoadWarningThreshold { get; set; }

                    /// <summary>
                    /// The maximum number of instances that are automatically scaled out. This parameter is used for horizontal scale-out.
                    /// </summary>
                    [NameInMap("MaxReplica")]
                    [Validation(Required=false)]
                    public int? MaxReplica { get; set; }

                    /// <summary>
                    /// The time policy list for auto scale-out.
                    /// </summary>
                    [NameInMap("TimePolicyList")]
                    [Validation(Required=false)]
                    public List<ListGatewayResponseBodyDataResultElasticPolicyTimePolicyList> TimePolicyList { get; set; }
                    public class ListGatewayResponseBodyDataResultElasticPolicyTimePolicyList : TeaModel {
                        /// <summary>
                        /// The expected number of replicas for auto scale-out.
                        /// </summary>
                        [NameInMap("DesiredReplica")]
                        [Validation(Required=false)]
                        public int? DesiredReplica { get; set; }

                        /// <summary>
                        /// The end time of auto scale-out.
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// The start time of auto scale-out.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// The number of replicas that are automatically scaled out.
                /// </summary>
                [NameInMap("ElasticReplica")]
                [Validation(Required=false)]
                public int? ElasticReplica { get; set; }

                /// <summary>
                /// The type of auto scale-out. Valid value:
                /// 
                /// *   CronHPA: scale-out by time
                /// </summary>
                [NameInMap("ElasticType")]
                [Validation(Required=false)]
                public string ElasticType { get; set; }

                /// <summary>
                /// The time when the instance expires.
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// The gateway type.
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
                /// The time when the gateway was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the gateway was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The gateway ID.
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
                /// The instance ID.
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
                    /// The state of the SLB instance.
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
                    /// The description of the state.
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// The type of the SLB instance.
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

                [NameInMap("MaintenancePeriod")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultMaintenancePeriod MaintenancePeriod { get; set; }
                public class ListGatewayResponseBodyDataResultMaintenancePeriod : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                /// <summary>
                /// The resource tag.
                /// </summary>
                [NameInMap("MseTag")]
                [Validation(Required=false)]
                public string MseTag { get; set; }

                [NameInMap("MseVersion")]
                [Validation(Required=false)]
                public string MseVersion { get; set; }

                /// <summary>
                /// Indicates whether the instance was forcefully upgraded.
                /// </summary>
                [NameInMap("MustUpgrade")]
                [Validation(Required=false)]
                public bool? MustUpgrade { get; set; }

                /// <summary>
                /// The gateway name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The user information.
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
                /// The resource group ID.
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
                /// The details of Server Load Balancer (SLB) instances.
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
                    /// The state of the SLB instance.
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
                    /// The description of the state.
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// The network type. Valid values:
                    /// 
                    /// *   PUB_NET
                    /// *   PRIVATE_NET
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
                /// The gateway state. Valid values:
                /// 
                /// *   0: The gateway is being created.
                /// *   1: The gateway failed to be created.
                /// *   2: The gateway is running.
                /// *   3: The gateway is being changed.
                /// *   4: The gateway is scaling in.
                /// *   6: The gateway is scaling out.
                /// *   8: The gateway is being deleted.
                /// *   9: The gateway is suspended and is to be released.
                /// *   10: The gateway is restarting.
                /// *   11: The gateway is being rebuilt.
                /// *   12: The gateway is being upgraded.
                /// *   13: The gateway failed to be upgraded.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The description of the gateway state.
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
                /// The total number of replicas, including the number of replicas that are automatically scaled out.
                /// </summary>
                [NameInMap("TotalReplica")]
                [Validation(Required=false)]
                public int? TotalReplica { get; set; }

                /// <summary>
                /// Indicates whether the instance was upgraded.
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) to which the gateway belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

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
