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
            /// The configurations of the backend service in the environment.
            /// </summary>
            [NameInMap("BackendModels")]
            [Validation(Required=false)]
            public List<DescribeBackendInfoResponseBodyBackendInfoBackendModels> BackendModels { get; set; }
            public class DescribeBackendInfoResponseBodyBackendInfoBackendModels : TeaModel {
                /// <summary>
                /// The backend service configurations.
                /// </summary>
                [NameInMap("BackendConfig")]
                [Validation(Required=false)]
                public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfig BackendConfig { get; set; }
                public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfig : TeaModel {
                    /// <summary>
                    /// The information about the backend service whose type is Service Discovery.
                    /// </summary>
                    [NameInMap("DiscoveryConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfig DiscoveryConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfig : TeaModel {
                        /// <summary>
                        /// The Nacos configurations.
                        /// </summary>
                        [NameInMap("NacosConfig")]
                        [Validation(Required=false)]
                        public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfigNacosConfig NacosConfig { get; set; }
                        public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfigNacosConfig : TeaModel {
                            /// <summary>
                            /// The AccessKey of the RAM user that has the resource management permissions on Microservices Engine (MSE).
                            /// </summary>
                            [NameInMap("AccessKey")]
                            [Validation(Required=false)]
                            public string AccessKey { get; set; }

                            /// <summary>
                            /// The authentication method.
                            /// </summary>
                            [NameInMap("AuthType")]
                            [Validation(Required=false)]
                            public string AuthType { get; set; }

                            /// <summary>
                            /// The name of the cluster to which the microservice belongs.
                            /// </summary>
                            [NameInMap("Clusters")]
                            [Validation(Required=false)]
                            public string Clusters { get; set; }

                            /// <summary>
                            /// The name of the group to which the microservice that is registered with Nacos belongs.
                            /// </summary>
                            [NameInMap("GroupName")]
                            [Validation(Required=false)]
                            public string GroupName { get; set; }

                            /// <summary>
                            /// The ID of the namespace where the microservice that is registered with Nacos resides.
                            /// </summary>
                            [NameInMap("Namespace")]
                            [Validation(Required=false)]
                            public string Namespace { get; set; }

                            /// <summary>
                            /// The password.
                            /// </summary>
                            [NameInMap("Password")]
                            [Validation(Required=false)]
                            public string Password { get; set; }

                            /// <summary>
                            /// The SecretKey of the RAM user that has the resource management permissions on MSE.
                            /// </summary>
                            [NameInMap("SecretKey")]
                            [Validation(Required=false)]
                            public string SecretKey { get; set; }

                            /// <summary>
                            /// The Nacos service address.
                            /// </summary>
                            [NameInMap("ServerAddress")]
                            [Validation(Required=false)]
                            public string ServerAddress { get; set; }

                            /// <summary>
                            /// The microservice name.
                            /// </summary>
                            [NameInMap("ServiceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }

                            /// <summary>
                            /// The username.
                            /// </summary>
                            [NameInMap("UserName")]
                            [Validation(Required=false)]
                            public string UserName { get; set; }

                        }

                        /// <summary>
                        /// The registry type.
                        /// </summary>
                        [NameInMap("RcType")]
                        [Validation(Required=false)]
                        public string RcType { get; set; }

                        [NameInMap("ZookeeperConfig")]
                        [Validation(Required=false)]
                        public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfigZookeeperConfig ZookeeperConfig { get; set; }
                        public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfigZookeeperConfig : TeaModel {
                            [NameInMap("ConnectString")]
                            [Validation(Required=false)]
                            public string ConnectString { get; set; }

                            [NameInMap("Namespace")]
                            [Validation(Required=false)]
                            public string Namespace { get; set; }

                            [NameInMap("ServiceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }

                        }

                    }

                    [NameInMap("EdasConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEdasConfig EdasConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEdasConfig : TeaModel {
                        [NameInMap("EdasAppId")]
                        [Validation(Required=false)]
                        public string EdasAppId { get; set; }

                        [NameInMap("MicroserviceNamespace")]
                        [Validation(Required=false)]
                        public string MicroserviceNamespace { get; set; }

                        [NameInMap("MicroserviceNamespaceId")]
                        [Validation(Required=false)]
                        public string MicroserviceNamespaceId { get; set; }

                        [NameInMap("MicroserviceNamespaceName")]
                        [Validation(Required=false)]
                        public string MicroserviceNamespaceName { get; set; }

                        [NameInMap("MseInstanceId")]
                        [Validation(Required=false)]
                        public string MseInstanceId { get; set; }

                        [NameInMap("RegistryType")]
                        [Validation(Required=false)]
                        public string RegistryType { get; set; }

                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                    }

                    /// <summary>
                    /// The information about the backend service whose type is EventBridge.
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
                        /// The event bus.
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
                    /// The information about the backend service whose type is Function Compute.
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
                        /// The type of the service in Function Compute.
                        /// </summary>
                        [NameInMap("FcType")]
                        [Validation(Required=false)]
                        public string FcType { get; set; }

                        /// <summary>
                        /// The function name that is defined in Function Compute.
                        /// </summary>
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        /// <summary>
                        /// Indicates whether the backend service receives only the service path.
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
                        /// The Alibaba Cloud Resource Name (ARN) of the RAM role that is assumed by API Gateway to access Function Compute.
                        /// </summary>
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                        /// <summary>
                        /// The service name that is defined in Function Compute.
                        /// </summary>
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                    }

                    /// <summary>
                    /// The host of the backend service.
                    /// </summary>
                    [NameInMap("HttpTargetHostName")]
                    [Validation(Required=false)]
                    public string HttpTargetHostName { get; set; }

                    /// <summary>
                    /// The information about the backend service whose type is Mock.
                    /// </summary>
                    [NameInMap("MockConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfig MockConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfig : TeaModel {
                        /// <summary>
                        /// The header returned for service mocking.
                        /// </summary>
                        [NameInMap("MockHeaders")]
                        [Validation(Required=false)]
                        public List<DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfigMockHeaders> MockHeaders { get; set; }
                        public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfigMockHeaders : TeaModel {
                            /// <summary>
                            /// The name of the header parameter.
                            /// </summary>
                            [NameInMap("HeaderName")]
                            [Validation(Required=false)]
                            public string HeaderName { get; set; }

                            /// <summary>
                            /// The value of the header parameter.
                            /// </summary>
                            [NameInMap("HeaderValue")]
                            [Validation(Required=false)]
                            public string HeaderValue { get; set; }

                        }

                        /// <summary>
                        /// The result returned for service mocking.
                        /// </summary>
                        [NameInMap("MockResult")]
                        [Validation(Required=false)]
                        public string MockResult { get; set; }

                        /// <summary>
                        /// The status code that is returned for service mocking.
                        /// </summary>
                        [NameInMap("MockStatusCode")]
                        [Validation(Required=false)]
                        public string MockStatusCode { get; set; }

                    }

                    /// <summary>
                    /// The information about the backend service whose type is Object Storage Service (OSS).
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
                        /// The region ID of the OSS bucket.
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

                    [NameInMap("ServiceTimeout")]
                    [Validation(Required=false)]
                    public int? ServiceTimeout { get; set; }

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
                        /// The name of the VPC configuration.
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
                        /// Indicates whether HTTP or HTTPS is used.
                        /// </summary>
                        [NameInMap("VpcScheme")]
                        [Validation(Required=false)]
                        public string VpcScheme { get; set; }

                        /// <summary>
                        /// The host of the backend service.
                        /// </summary>
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
                /// The environment name.
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
