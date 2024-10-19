// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeBackendInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the backend service.</para>
        /// </summary>
        [NameInMap("BackendInfo")]
        [Validation(Required=false)]
        public DescribeBackendInfoResponseBodyBackendInfo BackendInfo { get; set; }
        public class DescribeBackendInfoResponseBodyBackendInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6fc978bb63574146b766863dd7bdf661</para>
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// <para>The configurations of the backend service in the environment.</para>
            /// </summary>
            [NameInMap("BackendModels")]
            [Validation(Required=false)]
            public List<DescribeBackendInfoResponseBodyBackendInfoBackendModels> BackendModels { get; set; }
            public class DescribeBackendInfoResponseBodyBackendInfoBackendModels : TeaModel {
                /// <summary>
                /// <para>The backend service configurations.</para>
                /// </summary>
                [NameInMap("BackendConfig")]
                [Validation(Required=false)]
                public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfig BackendConfig { get; set; }
                public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfig : TeaModel {
                    /// <summary>
                    /// <para>The information about the backend service whose type is Service Discovery.</para>
                    /// </summary>
                    [NameInMap("DiscoveryConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfig DiscoveryConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfig : TeaModel {
                        /// <summary>
                        /// <para>The Nacos configurations.</para>
                        /// </summary>
                        [NameInMap("NacosConfig")]
                        [Validation(Required=false)]
                        public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfigNacosConfig NacosConfig { get; set; }
                        public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfigNacosConfig : TeaModel {
                            /// <summary>
                            /// <para>The AccessKey of the RAM user that has the resource management permissions on Microservices Engine (MSE).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>A5FIDxxxxxx</para>
                            /// </summary>
                            [NameInMap("AccessKey")]
                            [Validation(Required=false)]
                            public string AccessKey { get; set; }

                            /// <summary>
                            /// <para>The authentication method.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PASSWORD</para>
                            /// </summary>
                            [NameInMap("AuthType")]
                            [Validation(Required=false)]
                            public string AuthType { get; set; }

                            /// <summary>
                            /// <para>The name of the cluster to which the microservice belongs.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cluster1</para>
                            /// </summary>
                            [NameInMap("Clusters")]
                            [Validation(Required=false)]
                            public string Clusters { get; set; }

                            /// <summary>
                            /// <para>The name of the group to which the microservice that is registered with Nacos belongs.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>DEFAULT_GROUP</para>
                            /// </summary>
                            [NameInMap("GroupName")]
                            [Validation(Required=false)]
                            public string GroupName { get; set; }

                            /// <summary>
                            /// <para>The ID of the namespace where the microservice that is registered with Nacos resides.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>public</para>
                            /// </summary>
                            [NameInMap("Namespace")]
                            [Validation(Required=false)]
                            public string Namespace { get; set; }

                            /// <summary>
                            /// <para>The password.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>password</para>
                            /// </summary>
                            [NameInMap("Password")]
                            [Validation(Required=false)]
                            public string Password { get; set; }

                            /// <summary>
                            /// <para>The SecretKey of the RAM user that has the resource management permissions on MSE.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>dl5loxxxxxx</para>
                            /// </summary>
                            [NameInMap("SecretKey")]
                            [Validation(Required=false)]
                            public string SecretKey { get; set; }

                            /// <summary>
                            /// <para>The Nacos service address.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://1xx.2xx.3xx.4xx:8848">http://1xx.2xx.3xx.4xx:8848</a></para>
                            /// </summary>
                            [NameInMap("ServerAddress")]
                            [Validation(Required=false)]
                            public string ServerAddress { get; set; }

                            /// <summary>
                            /// <para>The microservice name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>service-provider</para>
                            /// </summary>
                            [NameInMap("ServiceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }

                            /// <summary>
                            /// <para>The username.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>username</para>
                            /// </summary>
                            [NameInMap("UserName")]
                            [Validation(Required=false)]
                            public string UserName { get; set; }

                        }

                        /// <summary>
                        /// <para>The registry type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NACOS</para>
                        /// </summary>
                        [NameInMap("RcType")]
                        [Validation(Required=false)]
                        public string RcType { get; set; }

                        [NameInMap("ZookeeperConfig")]
                        [Validation(Required=false)]
                        public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfigZookeeperConfig ZookeeperConfig { get; set; }
                        public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigDiscoveryConfigZookeeperConfig : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para><a href="http://192.168.1.xxx:2181">http://192.168.1.xxx:2181</a></para>
                            /// </summary>
                            [NameInMap("ConnectString")]
                            [Validation(Required=false)]
                            public string ConnectString { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>provider</para>
                            /// </summary>
                            [NameInMap("Namespace")]
                            [Validation(Required=false)]
                            public string Namespace { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>service</para>
                            /// </summary>
                            [NameInMap("ServiceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }

                        }

                    }

                    [NameInMap("EdasConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEdasConfig EdasConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEdasConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>6cd0c599-dxxx-496d-b3d5-6a71c657xxxxx</para>
                        /// </summary>
                        [NameInMap("EdasAppId")]
                        [Validation(Required=false)]
                        public string EdasAppId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou:edasNacos</para>
                        /// </summary>
                        [NameInMap("MicroserviceNamespace")]
                        [Validation(Required=false)]
                        public string MicroserviceNamespace { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou:edasNacos</para>
                        /// </summary>
                        [NameInMap("MicroserviceNamespaceId")]
                        [Validation(Required=false)]
                        public string MicroserviceNamespaceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Edas-Nacos</para>
                        /// </summary>
                        [NameInMap("MicroserviceNamespaceName")]
                        [Validation(Required=false)]
                        public string MicroserviceNamespaceName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mse-cn-jia3n1rxxxx</para>
                        /// </summary>
                        [NameInMap("MseInstanceId")]
                        [Validation(Required=false)]
                        public string MseInstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>EDAS</para>
                        /// </summary>
                        [NameInMap("RegistryType")]
                        [Validation(Required=false)]
                        public string RegistryType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>service</para>
                        /// </summary>
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the backend service whose type is EventBridge.</para>
                    /// </summary>
                    [NameInMap("EventBridgeConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEventBridgeConfig EventBridgeConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEventBridgeConfig : TeaModel {
                        /// <summary>
                        /// <para>The region ID of the event bus in EventBridge.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("EventBridgeRegionId")]
                        [Validation(Required=false)]
                        public string EventBridgeRegionId { get; set; }

                        /// <summary>
                        /// <para>The event bus.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testBus</para>
                        /// </summary>
                        [NameInMap("EventBus")]
                        [Validation(Required=false)]
                        public string EventBus { get; set; }

                        /// <summary>
                        /// <para>The event source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds_driver</para>
                        /// </summary>
                        [NameInMap("EventSource")]
                        [Validation(Required=false)]
                        public string EventSource { get; set; }

                        /// <summary>
                        /// <para>The ARN of the RAM role to be assumed by API Gateway to access EventBridge.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:ram::1975133748561***:role/aliyunserviceroleforiotlogexport</para>
                        /// </summary>
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the backend service whose type is Function Compute.</para>
                    /// </summary>
                    [NameInMap("FunctionComputeConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigFunctionComputeConfig : TeaModel {
                        /// <summary>
                        /// <para>The root path of the Function Compute service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://t*******.ap-*****.fcapp.run/">https://t*******.ap-*****.fcapp.run/</a></para>
                        /// </summary>
                        [NameInMap("FcBaseUrl")]
                        [Validation(Required=false)]
                        public string FcBaseUrl { get; set; }

                        /// <summary>
                        /// <para>The region ID of the Function Compute service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("FcRegionId")]
                        [Validation(Required=false)]
                        public string FcRegionId { get; set; }

                        /// <summary>
                        /// <para>The type of the service in Function Compute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HttpTrigger</para>
                        /// </summary>
                        [NameInMap("FcType")]
                        [Validation(Required=false)]
                        public string FcType { get; set; }

                        /// <summary>
                        /// <para>The function name that is defined in Function Compute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>edge_function</para>
                        /// </summary>
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the backend service receives only the service path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("OnlyBusinessPath")]
                        [Validation(Required=false)]
                        public bool? OnlyBusinessPath { get; set; }

                        /// <summary>
                        /// <para>The alias of the function.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testQualifier</para>
                        /// </summary>
                        [NameInMap("Qualifier")]
                        [Validation(Required=false)]
                        public string Qualifier { get; set; }

                        /// <summary>
                        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role that is assumed by API Gateway to access Function Compute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:ram::31985*:role/aliyunserviceroleforbastionhostpam</para>
                        /// </summary>
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                        /// <summary>
                        /// <para>The service name that is defined in Function Compute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>myservice</para>
                        /// </summary>
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                    }

                    /// <summary>
                    /// <para>The host of the backend service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.host.com">www.host.com</a></para>
                    /// </summary>
                    [NameInMap("HttpTargetHostName")]
                    [Validation(Required=false)]
                    public string HttpTargetHostName { get; set; }

                    /// <summary>
                    /// <para>The information about the backend service whose type is Mock.</para>
                    /// </summary>
                    [NameInMap("MockConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfig MockConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfig : TeaModel {
                        /// <summary>
                        /// <para>The header returned for service mocking.</para>
                        /// </summary>
                        [NameInMap("MockHeaders")]
                        [Validation(Required=false)]
                        public List<DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfigMockHeaders> MockHeaders { get; set; }
                        public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigMockConfigMockHeaders : TeaModel {
                            /// <summary>
                            /// <para>The name of the header parameter.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test</para>
                            /// </summary>
                            [NameInMap("HeaderName")]
                            [Validation(Required=false)]
                            public string HeaderName { get; set; }

                            /// <summary>
                            /// <para>The value of the header parameter.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>123</para>
                            /// </summary>
                            [NameInMap("HeaderValue")]
                            [Validation(Required=false)]
                            public string HeaderValue { get; set; }

                        }

                        /// <summary>
                        /// <para>The result returned for service mocking.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("MockResult")]
                        [Validation(Required=false)]
                        public string MockResult { get; set; }

                        /// <summary>
                        /// <para>The status code that is returned for service mocking.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("MockStatusCode")]
                        [Validation(Required=false)]
                        public string MockStatusCode { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the backend service whose type is Object Storage Service (OSS).</para>
                    /// </summary>
                    [NameInMap("OssConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigOssConfig OssConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigOssConfig : TeaModel {
                        /// <summary>
                        /// <para>The name of the OSS bucket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my_bucket</para>
                        /// </summary>
                        [NameInMap("BucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }

                        /// <summary>
                        /// <para>The region ID of the OSS bucket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("OssRegionId")]
                        [Validation(Required=false)]
                        public string OssRegionId { get; set; }

                    }

                    /// <summary>
                    /// <para>The URL of the backend service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.0.1</para>
                    /// </summary>
                    [NameInMap("ServiceAddress")]
                    [Validation(Required=false)]
                    public string ServiceAddress { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("ServiceTimeout")]
                    [Validation(Required=false)]
                    public int? ServiceTimeout { get; set; }

                    /// <summary>
                    /// <para>The type of the backend service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The information about the virtual private cloud (VPC). This parameter is available only for backend services whose type is VPC.</para>
                    /// </summary>
                    [NameInMap("VpcConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigVpcConfig VpcConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigVpcConfig : TeaModel {
                        /// <summary>
                        /// <para>The ID of the Elastic Compute Service (ECS) or Server Load Balancer (SLB) instance in the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-uf6iaale3gfef9t9cb41</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The name of the VPC configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dypls-cn-beijing-slb-pre</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The port number that corresponds to the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8080</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }

                        /// <summary>
                        /// <para>The ID of the VPC access authorization.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2zej3ehuzg9m77kvwnfpn</para>
                        /// </summary>
                        [NameInMap("VpcAccessId")]
                        [Validation(Required=false)]
                        public string VpcAccessId { get; set; }

                        /// <summary>
                        /// <para>The ID of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-wz9v96hqi6d14744sxqmx</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// <para>Indicates whether HTTP or HTTPS is used.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>http</para>
                        /// </summary>
                        [NameInMap("VpcScheme")]
                        [Validation(Required=false)]
                        public string VpcScheme { get; set; }

                        /// <summary>
                        /// <para>The host of the backend service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>openapi.alipan.com</para>
                        /// </summary>
                        [NameInMap("VpcTargetHostName")]
                        [Validation(Required=false)]
                        public string VpcTargetHostName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the backend service in the environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5c4995d08e8b4954b0f326e8e4f2b97d</para>
                /// </summary>
                [NameInMap("BackendModelId")]
                [Validation(Required=false)]
                public string BackendModelId { get; set; }

                /// <summary>
                /// <para>The description of the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDvs 1</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the backend service was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-20T03:22:03.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the backend service was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-20T03:22:03.000+0000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6fc978bb63574146b766863dd7bdf661</para>
                /// </summary>
                [NameInMap("StageModeId")]
                [Validation(Required=false)]
                public string StageModeId { get; set; }

                /// <summary>
                /// <para>The environment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

            /// <summary>
            /// <para>The name of the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testoss2</para>
            /// </summary>
            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }

            /// <summary>
            /// <para>The type of the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            /// <summary>
            /// <para>The time when the backend service was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-22T11:10:46+08:00</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The description of the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the backend service was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-11T15:18:09+08:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AA90E87-3506-5AA6-AFFB-A4D53B4F6231</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
