// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: The service instance is normal.</description></item>
        /// <item><description>Renewing: The service instance is being renewed.</description></item>
        /// <item><description>RenewFailed: The service instance failed to be renewed.</description></item>
        /// <item><description>Expired: The service instance expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BizStatus")]
        [Validation(Required=false)]
        public string BizStatus { get; set; }

        /// <summary>
        /// <para>The time when the service instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the service instance supports the hosted O\&amp;M feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        /// <summary>
        /// <para>Indicates whether the Prometheus monitoring feature is enabled on the user side.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        /// <summary>
        /// <para>The time when the service instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-01T12:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The URL of the Grafana dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://g.xxxxxx.aliyun.com/d/xxxxxxxx-cn-mariadb/mysql-xxxxxxxx-quickstart-and-dashboard?orgId=355401&refresh=10s">https://g.xxxxxx.aliyun.com/d/xxxxxxxx-cn-mariadb/mysql-xxxxxxxx-quickstart-and-dashboard?orgId=355401&amp;refresh=10s</a></para>
        /// </summary>
        [NameInMap("GrafanaDashBoardUrl")]
        [Validation(Required=false)]
        public string GrafanaDashBoardUrl { get; set; }

        /// <summary>
        /// <para>Indicates whether the hosted O\&amp;M feature is enabled for the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsOperated")]
        [Validation(Required=false)]
        public bool? IsOperated { get; set; }

        /// <summary>
        /// <para>The license metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;renewType&quot;:&quot;MONTHLY&quot;}</para>
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// <para>The name of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network configurations.</para>
        /// <remarks>
        /// <para> This parameter is discontinued.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NetworkConfig")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyNetworkConfig NetworkConfig { get; set; }
        public class GetServiceInstanceResponseBodyNetworkConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the endpoint for the private connection.</para>
            /// <remarks>
            /// <para> This parameter is discontinued.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ep-m5ei37240541816b****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint service for the private connection.</para>
            /// <remarks>
            /// <para> This parameter is discontinued.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-5ei07324541816bxxxx</para>
            /// </summary>
            [NameInMap("EndpointServiceId")]
            [Validation(Required=false)]
            public string EndpointServiceId { get; set; }

            /// <summary>
            /// <para>The information about private connections.</para>
            /// </summary>
            [NameInMap("PrivateVpcConnections")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnections> PrivateVpcConnections { get; set; }
            public class GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnections : TeaModel {
                /// <summary>
                /// <para>The network configurations, which are mainly used for the private connection.</para>
                /// </summary>
                [NameInMap("ConnectionConfigs")]
                [Validation(Required=false)]
                public List<GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnectionsConnectionConfigs> ConnectionConfigs { get; set; }
                public class GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnectionsConnectionConfigs : TeaModel {
                    /// <summary>
                    /// <para>The bandwidth limit for the private connection established based on the private network interconnection mode of Compute Nest.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1536Mbps</para>
                    /// </summary>
                    [NameInMap("ConnectBandwidth")]
                    [Validation(Required=false)]
                    public int? ConnectBandwidth { get; set; }

                    /// <summary>
                    /// <para>The domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("DomainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    /// <summary>
                    /// <para>The IP addresses of the endpoints for private connections.</para>
                    /// </summary>
                    [NameInMap("EndpointIps")]
                    [Validation(Required=false)]
                    public List<string> EndpointIps { get; set; }

                    /// <summary>
                    /// <para>The status of the Ingress endpoint. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Ready: The Ingress endpoint is connected.</description></item>
                    /// <item><description>Pending: The Ingress endpoint is being connected.</description></item>
                    /// <item><description>Failed: The Ingress endpoint fails to be connected.</description></item>
                    /// <item><description>Deleted: The Ingress endpoint is deleted.</description></item>
                    /// <item><description>Deleting: The Ingress endpoint is being deleted.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("IngressEndpointStatus")]
                    [Validation(Required=false)]
                    public string IngressEndpointStatus { get; set; }

                    /// <summary>
                    /// <para>The status of the network service. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Ready: The network service is connected.</description></item>
                    /// <item><description>Pending: The network service is being connected.</description></item>
                    /// <item><description>Failed: The network service fails to be connected.</description></item>
                    /// <item><description>Deleted: The network service is deleted.</description></item>
                    /// <item><description>Deleting: The network service is being deleted.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("NetworkServiceStatus")]
                    [Validation(Required=false)]
                    public string NetworkServiceStatus { get; set; }

                    /// <summary>
                    /// <para>The names of the security groups.</para>
                    /// </summary>
                    [NameInMap("SecurityGroups")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroups { get; set; }

                    /// <summary>
                    /// <para>The names of the vSwitches.</para>
                    /// </summary>
                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }

                    /// <summary>
                    /// <para>The virtual private cloud (VPC) ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp1vwnn14rqpyiczj****</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the endpoint for the private connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-m5ei37240541816b****</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <para>The ID of the endpoint service for the private connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epsrv-5ei07324541816bxxxx</para>
                /// </summary>
                [NameInMap("EndpointServiceId")]
                [Validation(Required=false)]
                public string EndpointServiceId { get; set; }

                /// <summary>
                /// <para>The custom domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.computenest.aliyuncs.com</para>
                /// </summary>
                [NameInMap("PrivateZoneName")]
                [Validation(Required=false)]
                public string PrivateZoneName { get; set; }

            }

            /// <summary>
            /// <para>The information about the reverse private connection.</para>
            /// </summary>
            [NameInMap("ReversePrivateVpcConnections")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyNetworkConfigReversePrivateVpcConnections> ReversePrivateVpcConnections { get; set; }
            public class GetServiceInstanceResponseBodyNetworkConfigReversePrivateVpcConnections : TeaModel {
                /// <summary>
                /// <para>The ID of the endpoint for the reverse private connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-m5ei42370541816b****</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <para>The ID of the endpoint service for the reverse private connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epsrv-5ei07324541816bxxxx</para>
                /// </summary>
                [NameInMap("EndpointServiceId")]
                [Validation(Required=false)]
                public string EndpointServiceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the service instance that is used to implement hosted O\&amp;M.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("OperatedServiceInstanceId")]
        [Validation(Required=false)]
        public string OperatedServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range during which hosted O\&amp;M is implemented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-28T06:48:56Z</para>
        /// </summary>
        [NameInMap("OperationEndTime")]
        [Validation(Required=false)]
        public string OperationEndTime { get; set; }

        [NameInMap("OperationExtraInfo")]
        [Validation(Required=false)]
        public string OperationExtraInfo { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which hosted O\&amp;M is implemented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-29T06:48:56Z</para>
        /// </summary>
        [NameInMap("OperationStartTime")]
        [Validation(Required=false)]
        public string OperationStartTime { get; set; }

        /// <summary>
        /// <para>The outputs returned from creating the service instance.</para>
        /// <list type="bullet">
        /// <item><description>If the service is deployed by using a ROS template, all output fields of the template are returned.</description></item>
        /// <item><description>If the service is deployed by calling an SPI operation, the output fields of the service provider and for the Compute Nest additional features are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;InstanceIds&quot;: [
        ///             &quot;i-hp38ofxl0dsyfi7z****&quot;
        ///       ]
        /// }</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// <para>The parameters that are specified to deploy the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;param&quot;: &quot;value&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The billing method of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Permanent: Once you purchase the service, you can use it permanently.</description></item>
        /// <item><description>Subscription: You purchase the service from Alibaba Cloud Marketplace and are charged for the service on a subscription basis.</description></item>
        /// <item><description>PayAsYouGo: You purchase the service from Alibaba Cloud Marketplace and are charged for the service on a pay-as-you-go basis.</description></item>
        /// <item><description>CustomFixTime: You are charged for the service based on a custom duration fixed by the service provider.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The package name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Package 1</para>
        /// </summary>
        [NameInMap("PredefinedParameterName")]
        [Validation(Required=false)]
        public string PredefinedParameterName { get; set; }

        /// <summary>
        /// <para>The deployment progress of the service instance. Unit: percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// <para>The logon URL for the accounts in the resource directory corresponding to the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://signin.aliyun.com/switchRole.htm?parentAlias=1307782318217247.onaliyun.com&roleName=ResourceDirectoryAccountAccessRole">https://signin.aliyun.com/switchRole.htm?parentAlias=1307782318217247.onaliyun.com&amp;roleName=ResourceDirectoryAccountAccessRole</a></para>
        /// </summary>
        [NameInMap("RdAccountLoginUrl")]
        [Validation(Required=false)]
        public string RdAccountLoginUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DB0F536-B3BE-4F0D-BD29-E83FB56D550C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzkt5buxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;StackId&quot;: &quot;stack-xxx&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The information about the service to which the service instance belongs.</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyService Service { get; set; }
        public class GetServiceInstanceResponseBodyService : TeaModel {
            /// <summary>
            /// <para>The storage configurations of the service. The format in which the deployment information of a service is stored varies based on the deployment type of the service. In this case, the deployment information is stored in the JSON string format.</para>
            /// </summary>
            [NameInMap("DeployMetadata")]
            [Validation(Required=false)]
            public string DeployMetadata { get; set; }

            /// <summary>
            /// <para>The deployment type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ros: The service is deployed by using Resource Orchestration Service (ROS).</description></item>
            /// <item><description>terraform: The service is deployed by using Terraform.</description></item>
            /// <item><description>ack: The service is deployed by using Container Service for Kubernetes (ACK).</description></item>
            /// <item><description>spi: The service is deployed by calling a service provider interface (SPI).</description></item>
            /// <item><description>operation: The service is deployed by using a hosted O\&amp;M service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ros</para>
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <para>The time when the service was published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-21T00:00:00Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <para>The URL of the service documentation.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("ServiceDocUrl")]
            [Validation(Required=false)]
            public string ServiceDocUrl { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-9c8a3522528b4fe8****</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The information about the service.</para>
            /// </summary>
            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyServiceServiceInfos> ServiceInfos { get; set; }
            public class GetServiceInstanceResponseBodyServiceServiceInfos : TeaModel {
                /// <summary>
                /// <para>The URL of the service icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f356602462.png">https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f356602462.png</a></para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The language of the service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh-CN</para>
                /// </summary>
                [NameInMap("Locale")]
                [Validation(Required=false)]
                public string Locale { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WordPress</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The description of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B是A公司自主设计并研发的开源分布式的关系型数据库</para>
                /// </summary>
                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

            }

            /// <summary>
            /// <para>The URL of the service page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://service-info-private.oss-cn-hangzhou.aliyuncs.com">https://service-info-private.oss-cn-hangzhou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("ServiceProductUrl")]
            [Validation(Required=false)]
            public string ServiceProductUrl { get; set; }

            /// <summary>
            /// <para>The type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
            /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
            /// <item><description>operation: The service is a hosted O\&amp;M service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The status of the service. Valid values:</para>
            /// <para>Draft: The registration request of the service is pending to be submitted.</para>
            /// <para>Submitted: The registration request of the service is submitted.</para>
            /// <para>Approved: The registration request of the service is approved.</para>
            /// <para>Online: The service is published.</para>
            /// <para>Offline: The service is unpublished.</para>
            /// <para>Deleted: The service is deleted.</para>
            /// <para>Launching: The service is being published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud</para>
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// <para>The URL of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

            [NameInMap("UpgradableServiceInfos")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyServiceUpgradableServiceInfos> UpgradableServiceInfos { get; set; }
            public class GetServiceInstanceResponseBodyServiceUpgradableServiceInfos : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

            /// <summary>
            /// <para>The service versions that can be updated.</para>
            /// </summary>
            [NameInMap("UpgradableServiceVersions")]
            [Validation(Required=false)]
            public List<string> UpgradableServiceVersions { get; set; }

            /// <summary>
            /// <para>The service version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The custom version name defined by the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20231127020225</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
        /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
        /// <item><description>operation: The service is a hosted O\&amp;M service.</description></item>
        /// <item><description>poc: The service is a trial service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The source of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: Compute Nest customer</description></item>
        /// <item><description>Market: Alibaba Cloud Marketplace</description></item>
        /// <item><description>Supplier: Compute Nest service provider</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The deployment state of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Created</description></item>
        /// <item><description>Deploying</description></item>
        /// <item><description>DeployedFailed</description></item>
        /// <item><description>Deployed</description></item>
        /// <item><description>Upgrading</description></item>
        /// <item><description>Deleting</description></item>
        /// <item><description>Deleted</description></item>
        /// <item><description>DeletedFailed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deployed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The description of the deployment state of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deploy successfully</para>
        /// </summary>
        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1964460391538545</para>
        /// </summary>
        [NameInMap("SupplierUid")]
        [Validation(Required=false)]
        public long? SupplierUid { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetServiceInstanceResponseBodyTags> Tags { get; set; }
        public class GetServiceInstanceResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>模板1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The time when the service instance was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
