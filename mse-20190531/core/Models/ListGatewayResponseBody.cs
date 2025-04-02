// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayResponseBodyData Data { get; set; }
        public class ListGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The data returned.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayResponseBodyDataResult> Result { get; set; }
            public class ListGatewayResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>Indicates whether Application High Availability Service (AHAS) is activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AhasOn")]
                [Validation(Required=false)]
                public bool? AhasOn { get; set; }

                /// <summary>
                /// <para>The version of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.1.0</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether Application Real-Time Monitoring Service (ARMS) is activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ArmsOn")]
                [Validation(Required=false)]
                public bool? ArmsOn { get; set; }

                /// <summary>
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POSTPAY</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The current version of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0-mse-gw</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether auto scale-out is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Elastic")]
                [Validation(Required=false)]
                public bool? Elastic { get; set; }

                /// <summary>
                /// <para>The ID of the elastic gateway. This parameter is returned if auto scale-out is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse_ingresselastic_public_cn-uqm3d0*****</para>
                /// </summary>
                [NameInMap("ElasticInstanceId")]
                [Validation(Required=false)]
                public string ElasticInstanceId { get; set; }

                /// <summary>
                /// <para>The auto scale-out policy.</para>
                /// </summary>
                [NameInMap("ElasticPolicy")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultElasticPolicy ElasticPolicy { get; set; }
                public class ListGatewayResponseBodyDataResultElasticPolicy : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether auto scale-out is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Elastic")]
                    [Validation(Required=false)]
                    public bool? Elastic { get; set; }

                    /// <summary>
                    /// <para>The type of auto scale-out. Valid value:</para>
                    /// <list type="bullet">
                    /// <item><description>CronHPA: scale-out by time</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CronHPA</para>
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
                    /// <para>The maximum number of instances that are automatically scaled out. This parameter is used for horizontal scale-out.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxReplica")]
                    [Validation(Required=false)]
                    public int? MaxReplica { get; set; }

                    /// <summary>
                    /// <para>The time policy list for auto scale-out.</para>
                    /// </summary>
                    [NameInMap("TimePolicyList")]
                    [Validation(Required=false)]
                    public List<ListGatewayResponseBodyDataResultElasticPolicyTimePolicyList> TimePolicyList { get; set; }
                    public class ListGatewayResponseBodyDataResultElasticPolicyTimePolicyList : TeaModel {
                        /// <summary>
                        /// <para>The expected number of replicas for auto scale-out.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("DesiredReplica")]
                        [Validation(Required=false)]
                        public int? DesiredReplica { get; set; }

                        /// <summary>
                        /// <para>The end time of auto scale-out.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>09:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The start time of auto scale-out.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>07:00</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of replicas that are automatically scaled out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ElasticReplica")]
                [Validation(Required=false)]
                public int? ElasticReplica { get; set; }

                /// <summary>
                /// <para>The type of auto scale-out. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>CronHPA: scale-out by time</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CronHPA</para>
                /// </summary>
                [NameInMap("ElasticType")]
                [Validation(Required=false)]
                public string ElasticType { get; set; }

                /// <summary>
                /// <para>The time when the instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4792060800000</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("GatewayEntry")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultGatewayEntry> GatewayEntry { get; set; }
                public class ListGatewayResponseBodyDataResultGatewayEntry : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>gw-*****5c2cd6144f4bfa1c32289f45ea8.cn-hangzhou.alicloudapi.com</para>
                    /// </summary>
                    [NameInMap("EntryDomain")]
                    [Validation(Required=false)]
                    public string EntryDomain { get; set; }

                    [NameInMap("HttpPorts")]
                    [Validation(Required=false)]
                    public List<int?> HttpPorts { get; set; }

                    [NameInMap("HttpsPorts")]
                    [Validation(Required=false)]
                    public List<int?> HttpsPorts { get; set; }

                    [NameInMap("IpList")]
                    [Validation(Required=false)]
                    public List<string> IpList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PUB_NET</para>
                    /// </summary>
                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                }

                /// <summary>
                /// <para>The gateway type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ingress</para>
                /// </summary>
                [NameInMap("GatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-5017305290e14cebb8ce5cb6a4****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The version of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.9</para>
                /// </summary>
                [NameInMap("GatewayVersion")]
                [Validation(Required=false)]
                public string GatewayVersion { get; set; }

                /// <summary>
                /// <para>The time when the gateway was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-13 19:24:23</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the gateway was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-13 19:24:23</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>153</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The configurations.</para>
                /// </summary>
                [NameInMap("InitConfig")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultInitConfig InitConfig { get; set; }
                public class ListGatewayResponseBodyDataResultInitConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether Web Application Firewall (WAF) is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableWaf")]
                    [Validation(Required=false)]
                    public bool? EnableWaf { get; set; }

                    /// <summary>
                    /// <para>Indicates whether WAF is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SupportWaf")]
                    [Validation(Required=false)]
                    public bool? SupportWaf { get; set; }

                }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse_ingresspost-cn-0jbvrcex****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The details of the Internet-facing SLB instances.</para>
                /// </summary>
                [NameInMap("InternetSlb")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultInternetSlb> InternetSlb { get; set; }
                public class ListGatewayResponseBodyDataResultInternetSlb : TeaModel {
                    /// <summary>
                    /// <para>The mode of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserHost</para>
                    /// </summary>
                    [NameInMap("GatewaySlbMode")]
                    [Validation(Required=false)]
                    public string GatewaySlbMode { get; set; }

                    /// <summary>
                    /// <para>The state of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("GatewaySlbStatus")]
                    [Validation(Required=false)]
                    public string GatewaySlbStatus { get; set; }

                    /// <summary>
                    /// <para>The traffic of the gateway.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("InternetNetworkFlow")]
                    [Validation(Required=false)]
                    public string InternetNetworkFlow { get; set; }

                    /// <summary>
                    /// <para>The ID of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-bp1ut8asdfgucjk****</para>
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// <para>The IP address of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>153.12.XX.XX</para>
                    /// </summary>
                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    /// <summary>
                    /// <para>The port number of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>slb.s2.small</para>
                    /// </summary>
                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public string SlbPort { get; set; }

                    /// <summary>
                    /// <para>The specifications of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>slb.s2.small</para>
                    /// </summary>
                    [NameInMap("SlbSpec")]
                    [Validation(Required=false)]
                    public string SlbSpec { get; set; }

                    /// <summary>
                    /// <para>The description of the state.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Creating</para>
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// <para>The type of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PUB_NET</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The latest version of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0-mse-gw</para>
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
                /// <para>The resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;tagKey&quot;:&quot;tagValue&quot;}</para>
                /// </summary>
                [NameInMap("MseTag")]
                [Validation(Required=false)]
                public string MseTag { get; set; }

                [NameInMap("MseVersion")]
                [Validation(Required=false)]
                public string MseVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance was forcefully upgraded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("MustUpgrade")]
                [Validation(Required=false)]
                public bool? MustUpgrade { get; set; }

                /// <summary>
                /// <para>The gateway name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tesa-test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18278117654342</para>
                /// </summary>
                [NameInMap("PrimaryUser")]
                [Validation(Required=false)]
                public string PrimaryUser { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The number of replicas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Replica")]
                [Validation(Required=false)]
                public int? Replica { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-97hg87vi****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether rollbacks are allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("RollBack")]
                [Validation(Required=false)]
                public bool? RollBack { get; set; }

                /// <summary>
                /// <para>The details of Server Load Balancer (SLB) instances.</para>
                /// </summary>
                [NameInMap("Slb")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultSlb> Slb { get; set; }
                public class ListGatewayResponseBodyDataResultSlb : TeaModel {
                    /// <summary>
                    /// <para>The mode of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserHost</para>
                    /// </summary>
                    [NameInMap("GatewaySlbMode")]
                    [Validation(Required=false)]
                    public string GatewaySlbMode { get; set; }

                    /// <summary>
                    /// <para>The state of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("GatewaySlbStatus")]
                    [Validation(Required=false)]
                    public string GatewaySlbStatus { get; set; }

                    /// <summary>
                    /// <para>The ID of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-bp1ut8asdfgucjk****</para>
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// <para>The IP address of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>153.12.XX.XX</para>
                    /// </summary>
                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    /// <summary>
                    /// <para>The port number of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public string SlbPort { get; set; }

                    /// <summary>
                    /// <para>The specifications of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>slb.s2.small</para>
                    /// </summary>
                    [NameInMap("SlbSpec")]
                    [Validation(Required=false)]
                    public string SlbSpec { get; set; }

                    /// <summary>
                    /// <para>The description of the state.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Creating</para>
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// <para>The network type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PUB_NET</description></item>
                    /// <item><description>PRIVATE_NET</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PUB_NET</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The specifications of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE_GTW_1_2_200_c</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The gateway state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The gateway is being created.</description></item>
                /// <item><description>1: The gateway failed to be created.</description></item>
                /// <item><description>2: The gateway is running.</description></item>
                /// <item><description>3: The gateway is being changed.</description></item>
                /// <item><description>4: The gateway is scaling in.</description></item>
                /// <item><description>6: The gateway is scaling out.</description></item>
                /// <item><description>8: The gateway is being deleted.</description></item>
                /// <item><description>9: The gateway is suspended and is to be released.</description></item>
                /// <item><description>10: The gateway is restarting.</description></item>
                /// <item><description>11: The gateway is being rebuilt.</description></item>
                /// <item><description>12: The gateway is being upgraded.</description></item>
                /// <item><description>13: The gateway failed to be upgraded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The description of the gateway state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Restarting</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>Indicates whether WebAssembly (Wasm) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportWasm")]
                [Validation(Required=false)]
                public bool? SupportWasm { get; set; }

                /// <summary>
                /// <para>The tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The total number of replicas, including the number of replicas that are automatically scaled out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("TotalReplica")]
                [Validation(Required=false)]
                public int? TotalReplica { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance was upgraded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

                [NameInMap("VersionLifecycle")]
                [Validation(Required=false)]
                public string VersionLifecycle { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) to which the gateway belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6heojei217tv14*****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the secondary vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bpbrveck45nf****</para>
                /// </summary>
                [NameInMap("Vswitch2")]
                [Validation(Required=false)]
                public string Vswitch2 { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation. Action: mse:ListGateway, Resource: acs:mse:cn-hangzhou:102123:*</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34300B3-52EC-5049-8C96-914098CF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
