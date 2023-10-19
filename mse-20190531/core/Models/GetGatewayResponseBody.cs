// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. A value of 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the gateway.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayResponseBodyData Data { get; set; }
        public class GetGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// The billing method, such as subscription or pay-as-you-go.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// Indicates whether auto scale-out is enabled.
            /// </summary>
            [NameInMap("Elastic")]
            [Validation(Required=false)]
            public bool? Elastic { get; set; }

            /// <summary>
            /// The auto scale-out policy.
            /// </summary>
            [NameInMap("ElasticPolicy")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataElasticPolicy ElasticPolicy { get; set; }
            public class GetGatewayResponseBodyDataElasticPolicy : TeaModel {
                /// <summary>
                /// The type of auto scale-out. Valid value:
                /// 
                /// *   CronHPA: scale-out by time
                /// </summary>
                [NameInMap("ElasticType")]
                [Validation(Required=false)]
                public string ElasticType { get; set; }

                /// <summary>
                /// The maximum number of instances that are automatically scaled out. This parameter is used for horizontal scale-out.
                /// </summary>
                [NameInMap("MaxReplica")]
                [Validation(Required=false)]
                public int? MaxReplica { get; set; }

                /// <summary>
                /// The policy of scale-out by time.
                /// </summary>
                [NameInMap("TimePolicyList")]
                [Validation(Required=false)]
                public List<GetGatewayResponseBodyDataElasticPolicyTimePolicyList> TimePolicyList { get; set; }
                public class GetGatewayResponseBodyDataElasticPolicyTimePolicyList : TeaModel {
                    /// <summary>
                    /// The number of expected replicas.
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
            /// The time when the gateway expires.
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// The unique ID of the gateway.
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// The time when the gateway was created. The time is displayed in GMT. The time is the local time of the region in which the gateway resides.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the gateway was last modified.
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
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The log configuration.
            /// </summary>
            [NameInMap("LogConfigDetails")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataLogConfigDetails LogConfigDetails { get; set; }
            public class GetGatewayResponseBodyDataLogConfigDetails : TeaModel {
                /// <summary>
                /// Indicates whether Log Service is activated.
                /// </summary>
                [NameInMap("LogEnabled")]
                [Validation(Required=false)]
                public bool? LogEnabled { get; set; }

                /// <summary>
                /// The name of the Logstore.
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// The name of the project.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// The tag of the resource.
            /// </summary>
            [NameInMap("MseTag")]
            [Validation(Required=false)]
            public string MseTag { get; set; }

            /// <summary>
            /// The name of the gateway.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID of the user who created the gateway.
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
            /// The number of gateway replicas.
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
            /// The ID of the security group.
            /// </summary>
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            /// <summary>
            /// The specifications of the gateway.
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// The status of the gateway. Valid values: 0: The gateway is being created. 1: The gateway fails to be created. 2: The gateway is running. 3: The gateway is changing. 4: The gateway is scaling down. 6: The gateway is scaling up. 8: The gateway is being deleted. 10: The gateway is restarting. 11: The gateway is being rebuilt. 12: The gateway is updating. 13: The gateway fails to be updated.
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
            /// The total number of replicas, including the number of replicas that are automatically scaled out.
            /// </summary>
            [NameInMap("TotalReplica")]
            [Validation(Required=false)]
            public int? TotalReplica { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public string Vpc { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

            /// <summary>
            /// The ID of the secondary vSwitch.
            /// </summary>
            [NameInMap("Vswitch2")]
            [Validation(Required=false)]
            public string Vswitch2 { get; set; }

            /// <summary>
            /// The details of Tracing Analysis.
            /// </summary>
            [NameInMap("XtraceDetails")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataXtraceDetails XtraceDetails { get; set; }
            public class GetGatewayResponseBodyDataXtraceDetails : TeaModel {
                /// <summary>
                /// The sampling rate of Tracing Analysis.
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public int? Sample { get; set; }

                /// <summary>
                /// Indicates whether sampling by using Tracing Analysis is enabled.
                /// </summary>
                [NameInMap("TraceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

            }

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
