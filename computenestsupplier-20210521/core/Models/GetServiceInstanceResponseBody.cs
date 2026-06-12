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
        /// <item><description><para>Normal: The service instance is normal.</para>
        /// </description></item>
        /// <item><description><para>Renewing: The service instance is being renewed.</para>
        /// </description></item>
        /// <item><description><para>RenewFoiled: The service instance failed to be renewed.</para>
        /// </description></item>
        /// <item><description><para>Expired: The service instance has expired.</para>
        /// </description></item>
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
        /// <para>Indicates whether the service instance supports Alibaba Cloud Managed Services. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The service instance supports Alibaba Cloud Managed Services.</para>
        /// </description></item>
        /// <item><description><para>false: The service instance does not support Alibaba Cloud Managed Services.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        /// <summary>
        /// <para>Indicates whether Prometheus is enabled for the user.</para>
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

        [NameInMap("GrantedPermission")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyGrantedPermission GrantedPermission { get; set; }
        public class GetServiceInstanceResponseBodyGrantedPermission : TeaModel {
            [NameInMap("OperationEndTime")]
            [Validation(Required=false)]
            public string OperationEndTime { get; set; }

            [NameInMap("PolicyNames")]
            [Validation(Required=false)]
            public string PolicyNames { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether Alibaba Cloud Managed Services is enabled for the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Alibaba Cloud Managed Services is enabled for the service instance.</para>
        /// </description></item>
        /// <item><description><para>false: Alibaba Cloud Managed Services is not enabled for the service instance.</para>
        /// </description></item>
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
        /// <para>Database B</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NetworkConfig")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyNetworkConfig NetworkConfig { get; set; }
        public class GetServiceInstanceResponseBodyNetworkConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the endpoint for the PrivateLink connection.</para>
            /// <remarks>
            /// <para>This parameter is deprecated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ep-m5ei37240541816b****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint service for the PrivateLink connection.</para>
            /// <remarks>
            /// <para>This parameter is deprecated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-5ei07324541816bxxxx</para>
            /// </summary>
            [NameInMap("EndpointServiceId")]
            [Validation(Required=false)]
            public string EndpointServiceId { get; set; }

            /// <summary>
            /// <para>The information about the PrivateLink connection.</para>
            /// </summary>
            [NameInMap("PrivateVpcConnections")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnections> PrivateVpcConnections { get; set; }
            public class GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnections : TeaModel {
                /// <summary>
                /// <para>The network configuration. This is mainly used for PrivateLink connections.</para>
                /// </summary>
                [NameInMap("ConnectionConfigs")]
                [Validation(Required=false)]
                public List<GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnectionsConnectionConfigs> ConnectionConfigs { get; set; }
                public class GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnectionsConnectionConfigs : TeaModel {
                    /// <summary>
                    /// <para>The bandwidth throttling for the connection that is established using the internal network of Compute Nest. Unit: Mbps.</para>
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
                    /// <para>The IP address of the endpoint for the PrivateLink connection.</para>
                    /// </summary>
                    [NameInMap("EndpointIps")]
                    [Validation(Required=false)]
                    public List<string> EndpointIps { get; set; }

                    /// <summary>
                    /// <para>The status of the Ingress endpoint. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>Ready: The endpoint is connected.</para>
                    /// </description></item>
                    /// <item><description><para>Pending: The endpoint is being connected.</para>
                    /// </description></item>
                    /// <item><description><para>Failed: The endpoint failed to be connected.</para>
                    /// </description></item>
                    /// <item><description><para>Deleted: The endpoint is deleted.</para>
                    /// </description></item>
                    /// <item><description><para>Deleting: The endpoint is being deleted.</para>
                    /// </description></item>
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
                    /// <item><description><para>Ready: The endpoint is connected.</para>
                    /// </description></item>
                    /// <item><description><para>Pending: The endpoint is being connected.</para>
                    /// </description></item>
                    /// <item><description><para>Failed: The endpoint failed to be connected.</para>
                    /// </description></item>
                    /// <item><description><para>Deleted: The endpoint is deleted.</para>
                    /// </description></item>
                    /// <item><description><para>Deleting: The endpoint is being deleted.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("NetworkServiceStatus")]
                    [Validation(Required=false)]
                    public string NetworkServiceStatus { get; set; }

                    /// <summary>
                    /// <para>The name of the security group.</para>
                    /// </summary>
                    [NameInMap("SecurityGroups")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroups { get; set; }

                    /// <summary>
                    /// <para>The name of the virtual switch.</para>
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
                /// <para>The ID of the endpoint for the PrivateLink connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-m5ei37240541816b****</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <para>The ID of the endpoint service for the PrivateLink connection.</para>
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
            /// <para>The information about the reverse PrivateLink connection.</para>
            /// </summary>
            [NameInMap("ReversePrivateVpcConnections")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyNetworkConfigReversePrivateVpcConnections> ReversePrivateVpcConnections { get; set; }
            public class GetServiceInstanceResponseBodyNetworkConfigReversePrivateVpcConnections : TeaModel {
                /// <summary>
                /// <para>The ID of the endpoint for the reverse PrivateLink connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-m5ei42370541816b****</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <para>The ID of the endpoint service for the PrivateLink connection.</para>
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
        /// <para>The ID of the service instance that is managed by Alibaba Cloud Managed Services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("OperatedServiceInstanceId")]
        [Validation(Required=false)]
        public string OperatedServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The end time of the Alibaba Cloud Managed Services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-28T06:48:56Z</para>
        /// </summary>
        [NameInMap("OperationEndTime")]
        [Validation(Required=false)]
        public string OperationEndTime { get; set; }

        /// <summary>
        /// <para>The additional information about Alibaba Cloud Managed Services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc5ce3590ed7f5529e85fec</para>
        /// </summary>
        [NameInMap("OperationExtraInfo")]
        [Validation(Required=false)]
        public string OperationExtraInfo { get; set; }

        /// <summary>
        /// <para>The start time of the Alibaba Cloud Managed Services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-29T06:48:56Z</para>
        /// </summary>
        [NameInMap("OperationStartTime")]
        [Validation(Required=false)]
        public string OperationStartTime { get; set; }

        /// <summary>
        /// <para>The output fields that are returned after the service instance is created.</para>
        /// <list type="bullet">
        /// <item><description><para>In ROS mode, all output fields of the template are returned.</para>
        /// </description></item>
        /// <item><description><para>In SPI mode, the output fields of the ISV and the output fields of the additional features of Compute Nest are returned.</para>
        /// </description></item>
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
        /// <para>The parameters that are entered for deploying the service instance.</para>
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
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Permanent: The service is permanently purchased.</para>
        /// </description></item>
        /// <item><description><para>Subscription: The service is a subscription service from Alibaba Cloud Marketplace.</para>
        /// </description></item>
        /// <item><description><para>PayAsYouGo: The service is a pay-as-you-go service from Alibaba Cloud Marketplace.</para>
        /// </description></item>
        /// <item><description><para>CustomFixTime: The service has a custom fixed duration.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

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
        /// <para>The deployment progress of the service instance. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// <para>The logon URL for the member in the resource directory that corresponds to the service instance.</para>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzkt5buxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resources.</para>
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
        /// <para>The service details.</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyService Service { get; set; }
        public class GetServiceInstanceResponseBodyService : TeaModel {
            /// <summary>
            /// <para>The deployment configuration of the service. The data format varies based on the deployment type. The value is a JSON string.</para>
            /// </summary>
            [NameInMap("DeployMetadata")]
            [Validation(Required=false)]
            public string DeployMetadata { get; set; }

            /// <summary>
            /// <para>The deployment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ros: The service is deployed using ROS.</para>
            /// </description></item>
            /// <item><description><para>terraform: The service is deployed using Terraform.</para>
            /// </description></item>
            /// <item><description><para>ack: The service is deployed using ACK.</para>
            /// </description></item>
            /// <item><description><para>spi: The service is deployed using SPI.</para>
            /// </description></item>
            /// <item><description><para>operation: The service is deployed using Alibaba Cloud Managed Services.</para>
            /// </description></item>
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
            /// <para>The URL of the documentation for the service.</para>
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
            /// <para>The service information.</para>
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
                /// <para>B数据库</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>A short description of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B is an open-source distributed relational database independently designed and developed by Company A.</para>
                /// </summary>
                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

            }

            /// <summary>
            /// <para>The URL of the product page for the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://service-info-private.oss-cn-hangzhou.aliyuncs.com">https://service-info-private.oss-cn-hangzhou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("ServiceProductUrl")]
            [Validation(Required=false)]
            public string ServiceProductUrl { get; set; }

            /// <summary>
            /// <para>The service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>private: The service is deployed in the user\&quot;s account.</para>
            /// </description></item>
            /// <item><description><para>managed: The service is deployed in the service provider\&quot;s account.</para>
            /// </description></item>
            /// <item><description><para>operation: The service is an Alibaba Cloud Managed Services.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The service status. Valid values:</para>
            /// <para>Draft: The service is pending registration.</para>
            /// <para>Submitted: The service is submitted for registration.</para>
            /// <para>Approved: The registration is approved.</para>
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
            /// <para>Company A</para>
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

            /// <summary>
            /// <para>The information about the service versions to which the service can be upgraded.</para>
            /// </summary>
            [NameInMap("UpgradableServiceInfos")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyServiceUpgradableServiceInfos> UpgradableServiceInfos { get; set; }
            public class GetServiceInstanceResponseBodyServiceUpgradableServiceInfos : TeaModel {
                /// <summary>
                /// <para>The service version to which the service can be upgraded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The name of the service version to which the service can be upgraded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>New parameter management feature</para>
                /// </summary>
                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

            /// <summary>
            /// <para>The service versions to which the service can be upgraded.</para>
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
            /// <para>The custom version name specified by the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Version A</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>private: a service instance that is deployed in the user\&quot;s account.</para>
        /// </description></item>
        /// <item><description><para>managed: a service instance that is deployed in the service provider\&quot;s account.</para>
        /// </description></item>
        /// <item><description><para>operation: an Alibaba Cloud Managed Services instance</para>
        /// </description></item>
        /// <item><description><para>poc: a trial service instance.</para>
        /// </description></item>
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
        /// <item><description><para>User: a Compute Nest user.</para>
        /// </description></item>
        /// <item><description><para>Market: Alibaba Cloud Marketplace.</para>
        /// </description></item>
        /// <item><description><para>Supplier: a Compute Nest service provider.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The deployment status of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Created: The service instance is created.</para>
        /// </description></item>
        /// <item><description><para>Deploying: The service instance is being deployed.</para>
        /// </description></item>
        /// <item><description><para>DeployedFailed: The service instance failed to be deployed.</para>
        /// </description></item>
        /// <item><description><para>Deployed: The service instance is deployed.</para>
        /// </description></item>
        /// <item><description><para>Upgrading: The service instance is being upgraded.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The service instance is being deleted.</para>
        /// </description></item>
        /// <item><description><para>Deleted: The service instance is deleted.</para>
        /// </description></item>
        /// <item><description><para>DeletedFailed: The service instance failed to be deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deployed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The description of the deployment status of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deploy successfully</para>
        /// </summary>
        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// <para>The service provider\&quot;s Alibaba Cloud account ID.</para>
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
        /// <para>Template 1</para>
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
        /// <para>The user\&quot;s Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
