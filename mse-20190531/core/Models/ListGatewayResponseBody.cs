// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned metadata.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayResponseBodyData Data { get; set; }
        public class ListGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayResponseBodyDataResult> Result { get; set; }
            public class ListGatewayResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>Indicates whether AHAS is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AhasOn")]
                [Validation(Required=false)]
                public bool? AhasOn { get; set; }

                /// <summary>
                /// <para>The application version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.1.0</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether ARMS is enabled.</para>
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
                /// <para>The current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0-mse-gw</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether auto-scaling is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Elastic")]
                [Validation(Required=false)]
                public bool? Elastic { get; set; }

                /// <summary>
                /// <para>The gateway elastic instance ID. This parameter is returned when auto-scaling is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse_ingresselastic_public_cn-uqm3d0*****</para>
                /// </summary>
                [NameInMap("ElasticInstanceId")]
                [Validation(Required=false)]
                public string ElasticInstanceId { get; set; }

                /// <summary>
                /// <para>The auto-scaling policy.</para>
                /// </summary>
                [NameInMap("ElasticPolicy")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultElasticPolicy ElasticPolicy { get; set; }
                public class ListGatewayResponseBodyDataResultElasticPolicy : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether auto-scaling is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Elastic")]
                    [Validation(Required=false)]
                    public bool? Elastic { get; set; }

                    /// <summary>
                    /// <para>The auto-scaling type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CronHPA: time-based scaling</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CronHPA</para>
                    /// </summary>
                    [NameInMap("ElasticType")]
                    [Validation(Required=false)]
                    public string ElasticType { get; set; }

                    /// <summary>
                    /// <para>The allowed time periods for scaling in.</para>
                    /// </summary>
                    [NameInMap("EnableScaleTimePolicyList")]
                    [Validation(Required=false)]
                    public List<ListGatewayResponseBodyDataResultElasticPolicyEnableScaleTimePolicyList> EnableScaleTimePolicyList { get; set; }
                    public class ListGatewayResponseBodyDataResultElasticPolicyEnableScaleTimePolicyList : TeaModel {
                        /// <summary>
                        /// <para>The end time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>09:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The start time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>07:00</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies the load-based elastic scaling watermark settings for the gateway. true indicates that the warning watermark is enabled, and false indicates that the safe watermark is enabled.</para>
                    /// </summary>
                    [NameInMap("LoadWarningThreshold")]
                    [Validation(Required=false)]
                    public bool? LoadWarningThreshold { get; set; }

                    /// <summary>
                    /// <para>The maximum number of instances for auto-scaling, used for horizontal scaling.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxReplica")]
                    [Validation(Required=false)]
                    public int? MaxReplica { get; set; }

                    /// <summary>
                    /// <para>The list of time-based auto-scaling policies.</para>
                    /// </summary>
                    [NameInMap("TimePolicyList")]
                    [Validation(Required=false)]
                    public List<ListGatewayResponseBodyDataResultElasticPolicyTimePolicyList> TimePolicyList { get; set; }
                    public class ListGatewayResponseBodyDataResultElasticPolicyTimePolicyList : TeaModel {
                        /// <summary>
                        /// <para>The expected number of replicas for auto-scaling.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("DesiredReplica")]
                        [Validation(Required=false)]
                        public int? DesiredReplica { get; set; }

                        /// <summary>
                        /// <para>The end time for auto-scaling.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>09:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The start time for auto-scaling.</para>
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
                /// <para>The number of auto-scaling replicas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ElasticReplica")]
                [Validation(Required=false)]
                public int? ElasticReplica { get; set; }

                /// <summary>
                /// <para>The auto-scaling type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CronHPA: time-based scaling</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CronHPA</para>
                /// </summary>
                [NameInMap("ElasticType")]
                [Validation(Required=false)]
                public string ElasticType { get; set; }

                /// <summary>
                /// <para>The expiration date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4792060800000</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>The gateway entry address. This parameter is applicable to standard Professional Edition instances.</para>
                /// </summary>
                [NameInMap("GatewayEntry")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultGatewayEntry> GatewayEntry { get; set; }
                public class ListGatewayResponseBodyDataResultGatewayEntry : TeaModel {
                    /// <summary>
                    /// <para>The entry domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gw-*****5c2cd6144f4bfa1c32289f45ea8.cn-hangzhou.alicloudapi.com</para>
                    /// </summary>
                    [NameInMap("EntryDomain")]
                    [Validation(Required=false)]
                    public string EntryDomain { get; set; }

                    /// <summary>
                    /// <para>The list of HTTP listener ports.</para>
                    /// </summary>
                    [NameInMap("HttpPorts")]
                    [Validation(Required=false)]
                    public List<int?> HttpPorts { get; set; }

                    /// <summary>
                    /// <para>The list of HTTPS listener ports.</para>
                    /// </summary>
                    [NameInMap("HttpsPorts")]
                    [Validation(Required=false)]
                    public List<int?> HttpsPorts { get; set; }

                    /// <summary>
                    /// <para>The list of entry IP addresses.</para>
                    /// </summary>
                    [NameInMap("IpList")]
                    [Validation(Required=false)]
                    public List<string> IpList { get; set; }

                    /// <summary>
                    /// <para>The IPv6 address.</para>
                    /// </summary>
                    [NameInMap("Ipv6List")]
                    [Validation(Required=false)]
                    public List<string> Ipv6List { get; set; }

                    /// <summary>
                    /// <para>The entry network type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PRIVATE_NET: private network</description></item>
                    /// <item><description>PUB_NET: public network</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PUB_NET</para>
                    /// </summary>
                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                    /// <summary>
                    /// <para>The readiness status of the gateway entry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

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
                /// <para>The gateway version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.9</para>
                /// </summary>
                [NameInMap("GatewayVersion")]
                [Validation(Required=false)]
                public string GatewayVersion { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-13 19:24:23</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
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
                /// <para>The configuration information.</para>
                /// </summary>
                [NameInMap("InitConfig")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultInitConfig InitConfig { get; set; }
                public class ListGatewayResponseBodyDataResultInitConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether WAF is enabled.</para>
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
                /// <para>The Internet SLB.</para>
                /// </summary>
                [NameInMap("InternetSlb")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultInternetSlb> InternetSlb { get; set; }
                public class ListGatewayResponseBodyDataResultInternetSlb : TeaModel {
                    /// <summary>
                    /// <para>The gateway SLB mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserHost</para>
                    /// </summary>
                    [NameInMap("GatewaySlbMode")]
                    [Validation(Required=false)]
                    public string GatewaySlbMode { get; set; }

                    /// <summary>
                    /// <para>The gateway SLB status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("GatewaySlbStatus")]
                    [Validation(Required=false)]
                    public string GatewaySlbStatus { get; set; }

                    /// <summary>
                    /// <para>The gateway traffic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("InternetNetworkFlow")]
                    [Validation(Required=false)]
                    public string InternetNetworkFlow { get; set; }

                    /// <summary>
                    /// <para>The SLB ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-bp1ut8asdfgucjk****</para>
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// <para>The SLB IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>153.12.XX.XX</para>
                    /// </summary>
                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    /// <summary>
                    /// <para>The SLB port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>slb.s2.small</para>
                    /// </summary>
                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public string SlbPort { get; set; }

                    /// <summary>
                    /// <para>The SLB specification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>slb.s2.small</para>
                    /// </summary>
                    [NameInMap("SlbSpec")]
                    [Validation(Required=false)]
                    public string SlbSpec { get; set; }

                    /// <summary>
                    /// <para>The status description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Creating</para>
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// <para>The type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PUB_NET</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The latest version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0-mse-gw</para>
                /// </summary>
                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                /// <summary>
                /// <para>The O&amp;M time window.</para>
                /// </summary>
                [NameInMap("MaintenancePeriod")]
                [Validation(Required=false)]
                public ListGatewayResponseBodyDataResultMaintenancePeriod MaintenancePeriod { get; set; }
                public class ListGatewayResponseBodyDataResultMaintenancePeriod : TeaModel {
                    /// <summary>
                    /// <para>The end time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>06:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>02:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
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

                /// <summary>
                /// <para>The cluster version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse_pro</para>
                /// </summary>
                [NameInMap("MseVersion")]
                [Validation(Required=false)]
                public string MseVersion { get; set; }

                /// <summary>
                /// <para>The forced upgrade.</para>
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
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The backup.</para>
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
                /// <para>Indicates whether rollback is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("RollBack")]
                [Validation(Required=false)]
                public bool? RollBack { get; set; }

                /// <summary>
                /// <para>The SLB list.</para>
                /// </summary>
                [NameInMap("Slb")]
                [Validation(Required=false)]
                public List<ListGatewayResponseBodyDataResultSlb> Slb { get; set; }
                public class ListGatewayResponseBodyDataResultSlb : TeaModel {
                    /// <summary>
                    /// <para>The gateway SLB mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserHost</para>
                    /// </summary>
                    [NameInMap("GatewaySlbMode")]
                    [Validation(Required=false)]
                    public string GatewaySlbMode { get; set; }

                    /// <summary>
                    /// <para>The gateway SLB status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("GatewaySlbStatus")]
                    [Validation(Required=false)]
                    public string GatewaySlbStatus { get; set; }

                    /// <summary>
                    /// <para>The SLB ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-bp1ut8asdfgucjk****</para>
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// <para>The SLB IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>153.12.XX.XX</para>
                    /// </summary>
                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    /// <summary>
                    /// <para>The SLB port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public string SlbPort { get; set; }

                    /// <summary>
                    /// <para>The SLB specification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>slb.s2.small</para>
                    /// </summary>
                    [NameInMap("SlbSpec")]
                    [Validation(Required=false)]
                    public string SlbSpec { get; set; }

                    /// <summary>
                    /// <para>The status description.</para>
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
                    /// <item><description>PUB_NET: public network</description></item>
                    /// <item><description>PRIVATE_NET: private network</description></item>
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
                /// <para>The specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE_GTW_1_2_200_c</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The gateway status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: creating</description></item>
                /// <item><description>1: creation failed</description></item>
                /// <item><description>2: running</description></item>
                /// <item><description>3: modifying</description></item>
                /// <item><description>4: scaling in</description></item>
                /// <item><description>6: scaling out</description></item>
                /// <item><description>8: deleting</description></item>
                /// <item><description>9: stopped and pending release</description></item>
                /// <item><description>10: restarting</description></item>
                /// <item><description>11: rebuilding</description></item>
                /// <item><description>12: upgrading</description></item>
                /// <item><description>13: upgrade failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Restarting</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>Indicates whether WASM is supported.</para>
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
                /// <para>The total number of replicas, including the number of auto-scaling replicas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("TotalReplica")]
                [Validation(Required=false)]
                public int? TotalReplica { get; set; }

                /// <summary>
                /// <para>The upgrade.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

                /// <summary>
                /// <para>The version lifecycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STABLE</para>
                /// </summary>
                [NameInMap("VersionLifecycle")]
                [Validation(Required=false)]
                public string VersionLifecycle { get; set; }

                /// <summary>
                /// <para>The VPC ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6heojei217tv14*****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The second vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bpbrveck45nf****</para>
                /// </summary>
                [NameInMap("Vswitch2")]
                [Validation(Required=false)]
                public string Vswitch2 { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation. Action: mse:ListGateway, Resource: acs:mse:cn-hangzhou:102123:*</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34300B3-52EC-5049-8C96-914098CF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
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
