// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The gateway information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayResponseBodyData Data { get; set; }
        public class GetGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values: subscription and pay-as-you-go.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Specifies whether auto-scaling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Elastic")]
            [Validation(Required=false)]
            public bool? Elastic { get; set; }

            /// <summary>
            /// <para>The auto-scaling policy.</para>
            /// </summary>
            [NameInMap("ElasticPolicy")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataElasticPolicy ElasticPolicy { get; set; }
            public class GetGatewayResponseBodyDataElasticPolicy : TeaModel {
                /// <summary>
                /// <para>The auto-scaling type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CronHPA: Time-based scaling.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CronHPA</para>
                /// </summary>
                [NameInMap("ElasticType")]
                [Validation(Required=false)]
                public string ElasticType { get; set; }

                /// <summary>
                /// <para>The maximum number of instances for auto-scaling, which is used for horizontal scaling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MaxReplica")]
                [Validation(Required=false)]
                public int? MaxReplica { get; set; }

                /// <summary>
                /// <para>The time-based scaling policy.</para>
                /// </summary>
                [NameInMap("TimePolicyList")]
                [Validation(Required=false)]
                public List<GetGatewayResponseBodyDataElasticPolicyTimePolicyList> TimePolicyList { get; set; }
                public class GetGatewayResponseBodyDataElasticPolicyTimePolicyList : TeaModel {
                    /// <summary>
                    /// <para>The expected number of replicas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("DesiredReplica")]
                    [Validation(Required=false)]
                    public int? DesiredReplica { get; set; }

                    /// <summary>
                    /// <para>The end time in the HH:mm format (24-hour clock).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time in the HH:mm format (24-hour clock).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16:00</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("ElasticReplica")]
            [Validation(Required=false)]
            public int? ElasticReplica { get; set; }

            /// <summary>
            /// <para>The auto-scaling type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CronHPA: Time-based scaling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CronHPA</para>
            /// </summary>
            [NameInMap("ElasticType")]
            [Validation(Required=false)]
            public string ElasticType { get; set; }

            /// <summary>
            /// <para>The expiration time of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The unique ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-7ea3da97b96543e19f6c597cd4a9****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The time when the gateway was created. The time is in GMT and represents the local time of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07T10:07:57.000+0000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the instance was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07T10:07:57.000+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-st21ri2****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The log configuration.</para>
            /// </summary>
            [NameInMap("LogConfigDetails")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataLogConfigDetails LogConfigDetails { get; set; }
            public class GetGatewayResponseBodyDataLogConfigDetails : TeaModel {
                /// <summary>
                /// <para>Specifies whether log delivery is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LogEnabled")]
                [Validation(Required=false)]
                public bool? LogEnabled { get; set; }

                /// <summary>
                /// <para>The Logstore name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse_access_log</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k8s-log-c173117256e934a96b7fefdf2ef8a8057</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <para>The resource tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;TagKey&quot;:&quot;TagValue&quot;}</para>
            /// </summary>
            [NameInMap("MseTag")]
            [Validation(Required=false)]
            public string MseTag { get; set; }

            /// <summary>
            /// <para>The gateway name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the primary user who created the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231254</para>
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
            /// <para>The number of gateway replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm34x43l*****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp11ufzqn6mmb8dtzz82</para>
            /// </summary>
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            /// <summary>
            /// <para>The gateway specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MSE_GTW_16_32_200_c</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The result status of the data integration synchronization node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Creating.</description></item>
            /// <item><description>1: Creation failed.</description></item>
            /// <item><description>2: Running.</description></item>
            /// <item><description>3: Modifying.</description></item>
            /// <item><description>4: Scaling in.</description></item>
            /// <item><description>6: Scaling out.</description></item>
            /// <item><description>8: delete.</description></item>
            /// <item><description>10: Restarting.</description></item>
            /// <item><description>11: Rebuilding.</description></item>
            /// <item><description>12: Upgrading.</description></item>
            /// <item><description>13: Upgrade failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>The total number of replicas, including auto-scaling replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalReplica")]
            [Validation(Required=false)]
            public int? TotalReplica { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1328cm01m6uel42b5zb</para>
            /// </summary>
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public string Vpc { get; set; }

            /// <summary>
            /// <para>The vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp18zeqxx6mpuq843z4n5</para>
            /// </summary>
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

            /// <summary>
            /// <para>The secondary vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1j6ivhav15ve7q54kq2</para>
            /// </summary>
            [NameInMap("Vswitch2")]
            [Validation(Required=false)]
            public string Vswitch2 { get; set; }

            /// <summary>
            /// <para>The XTrace details.</para>
            /// </summary>
            [NameInMap("XtraceDetails")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataXtraceDetails XtraceDetails { get; set; }
            public class GetGatewayResponseBodyDataXtraceDetails : TeaModel {
                /// <summary>
                /// <para>The XTrace sampling rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public int? Sample { get; set; }

                /// <summary>
                /// <para>Specifies whether XTrace sampling is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TraceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

            }

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
        /// <para>The message that indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C96CDF8-9E6C-5AB6-B83C-8F87A10117E6</para>
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
