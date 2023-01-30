// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeBackendInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the backend service.
        /// </summary>
        [NameInMap("BackendInfo")]
        [Validation(Required=false)]
        public DescribeBackendInfoResponseBodyBackendInfo BackendInfo { get; set; }
        public class DescribeBackendInfoResponseBodyBackendInfo : TeaModel {
            /// <summary>
            /// The ID of the backend service.
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// The time when the backend service was created.
            /// </summary>
            [NameInMap("BackendModels")]
            [Validation(Required=false)]
            public List<DescribeBackendInfoResponseBodyBackendInfoBackendModels> BackendModels { get; set; }
            public class DescribeBackendInfoResponseBodyBackendInfoBackendModels : TeaModel {
                /// <summary>
                /// The backend configurations.
                /// </summary>
                [NameInMap("BackendConfig")]
                [Validation(Required=false)]
                public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfig BackendConfig { get; set; }
                public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfig : TeaModel {
                    /// <summary>
                    /// The information about the backend service that is EventBridge.
                    /// </summary>
                    [NameInMap("EventBridgeConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEventBridgeConfig EventBridgeConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEventBridgeConfig : TeaModel {
                        /// <summary>
                        /// The region ID of the event bus in EventBridge.
                        /// </summary>
                        [NameInMap("EventBridgeRegionId")]
                        [Validation(Required=false)]
                        public string EventBridgeRegionId { get; set; }

                        /// <summary>
                        /// The name of the event bus.
                        /// </summary>
                        [NameInMap("EventBus")]
                        [Validation(Required=false)]
                        public string EventBus { get; set; }

                        /// <summary>
                        /// The event source.
                        /// </summary>
                        [NameInMap("EventSource")]
                        [Validation(Required=false)]
                        public string EventSource { get; set; }

                        /// <summary>
                        /// The ARN of the RAM role to be assumed by API Gateway to access EventBridge.
                        /// </summary>
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                    }

                    /// <summary>
                    /// The information about the backend service whose type is FC_EVENT or FC_HTTP.
                    /// </summary>
                    [NameInMap("FunctionComputeConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigFunctionComputeConfig : TeaModel {
                        /// <summary>
                        /// The root path of the Function Compute service.
                        /// </summary>
                        [NameInMap("FcBaseUrl")]
                        [Validation(Required=false)]
                        public string FcBaseUrl { get; set; }

                        /// <summary>
                        /// The region ID of the Function Compute service.
                        /// </summary>
                        [NameInMap("FcRegionId")]
                        [Validation(Required=false)]
                        public string FcRegionId { get; set; }

                        /// <summary>
                        /// The type of the Function Compute service.
                        /// </summary>
                        [NameInMap("FcType")]
                        [Validation(Required=false)]
                        public string FcType { get; set; }

                        /// <summary>
                        /// The function name defined in Function Compute.
                        /// </summary>
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        /// <summary>
                        /// The backend service path.
                        /// </summary>
                        [NameInMap("OnlyBusinessPath")]
                        [Validation(Required=false)]
                        public bool? OnlyBusinessPath { get; set; }

                        /// <summary>
                        /// The alias of the function.
                        /// </summary>
                        [NameInMap("Qualifier")]
                        [Validation(Required=false)]
                        public string Qualifier { get; set; }

                        /// <summary>
                        /// The Alibaba Cloud Resource Name (ARN) of the RAM role to be assumed by API Gateway to access Function Compute.
                        /// </summary>
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                        /// <summary>
                        /// The service name defined in Function Compute.
                        /// </summary>
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                    }

                    [NameInMap("MockConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfig MockConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfig : TeaModel {
                        [NameInMap("MockHeaders")]
                        [Validation(Required=false)]
                        public List<DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfigMockHeaders> MockHeaders { get; set; }
                        public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfigMockHeaders : TeaModel {
                            [NameInMap("HeaderName")]
                            [Validation(Required=false)]
                            public string HeaderName { get; set; }

                            [NameInMap("HeaderValue")]
                            [Validation(Required=false)]
                            public string HeaderValue { get; set; }

                        }

                        [NameInMap("MockResult")]
                        [Validation(Required=false)]
                        public string MockResult { get; set; }

                        [NameInMap("MockStatusCode")]
                        [Validation(Required=false)]
                        public string MockStatusCode { get; set; }

                    }

                    /// <summary>
                    /// The information about the backend service whose type is OSS.
                    /// </summary>
                    [NameInMap("OssConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigOssConfig OssConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigOssConfig : TeaModel {
                        /// <summary>
                        /// The name of the OSS bucket.
                        /// </summary>
                        [NameInMap("BucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }

                        /// <summary>
                        /// The region ID of the Object Storage Service (OSS) bucket.
                        /// </summary>
                        [NameInMap("OssRegionId")]
                        [Validation(Required=false)]
                        public string OssRegionId { get; set; }

                    }

                    /// <summary>
                    /// The URL of the backend service.
                    /// </summary>
                    [NameInMap("ServiceAddress")]
                    [Validation(Required=false)]
                    public string ServiceAddress { get; set; }

                    /// <summary>
                    /// The type of the backend service.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The information about the virtual private cloud (VPC). This parameter is available only for backend services whose type is VPC.
                    /// </summary>
                    [NameInMap("VpcConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigVpcConfig VpcConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigVpcConfig : TeaModel {
                        /// <summary>
                        /// The ID of the Elastic Compute Service (ECS) or Server Load Balancer (SLB) instance in the VPC.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The name of the VPC Configuration.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The port number that corresponds to the instance.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }

                        /// <summary>
                        /// The ID of the VPC access authorization.
                        /// </summary>
                        [NameInMap("VpcAccessId")]
                        [Validation(Required=false)]
                        public string VpcAccessId { get; set; }

                        /// <summary>
                        /// The ID of the VPC.
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// http/https
                        /// </summary>
                        [NameInMap("VpcScheme")]
                        [Validation(Required=false)]
                        public string VpcScheme { get; set; }

                        [NameInMap("VpcTargetHostName")]
                        [Validation(Required=false)]
                        public string VpcTargetHostName { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the backend service in the environment.
                /// </summary>
                [NameInMap("BackendModelId")]
                [Validation(Required=false)]
                public string BackendModelId { get; set; }

                /// <summary>
                /// The description of the backend service.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the backend service was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the backend service was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the environment.
                /// </summary>
                [NameInMap("StageModeId")]
                [Validation(Required=false)]
                public string StageModeId { get; set; }

                /// <summary>
                /// The name of the environment.
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

            /// <summary>
            /// The name of the backend service.
            /// </summary>
            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }

            /// <summary>
            /// The type of the backend service.
            /// </summary>
            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            /// <summary>
            /// The time when the backend service was created.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The description of the backend service.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the backend service was modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
