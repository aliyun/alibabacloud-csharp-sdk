// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// The business status of the service instance. Valid values:
        /// 
        /// *   Normal: The service instance is normal.
        /// *   Renewing: The service instance is being renewed.
        /// *   RenewFailed: The service instance failed to be renewed.
        /// *   Expired: The service instance expired.
        /// </summary>
        [NameInMap("BizStatus")]
        [Validation(Required=false)]
        public string BizStatus { get; set; }

        /// <summary>
        /// The time when the service instance was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Indicates whether the service instance supports the hosted O\\&M feature. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        /// <summary>
        /// Indicates whether the Prometheus monitoring feature is enabled on the user side.
        /// </summary>
        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        /// <summary>
        /// The time when the service instance expires.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The URL of the Grafana dashboard.
        /// </summary>
        [NameInMap("GrafanaDashBoardUrl")]
        [Validation(Required=false)]
        public string GrafanaDashBoardUrl { get; set; }

        /// <summary>
        /// Indicates whether the hosted O\\&M feature is enabled for the service instance. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsOperated")]
        [Validation(Required=false)]
        public bool? IsOperated { get; set; }

        /// <summary>
        /// The license metadata.
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// The name of the service instance.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The network configurations.
        /// 
        /// >  This parameter is discontinued.
        /// </summary>
        [NameInMap("NetworkConfig")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyNetworkConfig NetworkConfig { get; set; }
        public class GetServiceInstanceResponseBodyNetworkConfig : TeaModel {
            /// <summary>
            /// The ID of the endpoint for the private connection.
            /// 
            /// >  This parameter is discontinued.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The ID of the endpoint service for the private connection.
            /// 
            /// >  This parameter is discontinued.
            /// </summary>
            [NameInMap("EndpointServiceId")]
            [Validation(Required=false)]
            public string EndpointServiceId { get; set; }

            /// <summary>
            /// The information about private connections.
            /// </summary>
            [NameInMap("PrivateVpcConnections")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnections> PrivateVpcConnections { get; set; }
            public class GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnections : TeaModel {
                /// <summary>
                /// The network configurations, which are mainly used for the private connection.
                /// </summary>
                [NameInMap("ConnectionConfigs")]
                [Validation(Required=false)]
                public List<GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnectionsConnectionConfigs> ConnectionConfigs { get; set; }
                public class GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnectionsConnectionConfigs : TeaModel {
                    /// <summary>
                    /// The bandwidth limit for the private connection established based on the private network interconnection mode of Compute Nest.
                    /// </summary>
                    [NameInMap("ConnectBandwidth")]
                    [Validation(Required=false)]
                    public int? ConnectBandwidth { get; set; }

                    /// <summary>
                    /// The domain name.
                    /// </summary>
                    [NameInMap("DomainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    /// <summary>
                    /// The IP addresses of the endpoints for private connections.
                    /// </summary>
                    [NameInMap("EndpointIps")]
                    [Validation(Required=false)]
                    public List<string> EndpointIps { get; set; }

                    /// <summary>
                    /// The status of the Ingress endpoint. Valid values:
                    /// 
                    /// *   Ready: The Ingress endpoint is connected.
                    /// *   Pending: The Ingress endpoint is being connected.
                    /// *   Failed: The Ingress endpoint fails to be connected.
                    /// *   Deleted: The Ingress endpoint is deleted.
                    /// *   Deleting: The Ingress endpoint is being deleted.
                    /// </summary>
                    [NameInMap("IngressEndpointStatus")]
                    [Validation(Required=false)]
                    public string IngressEndpointStatus { get; set; }

                    /// <summary>
                    /// The status of the network service. Valid values:
                    /// 
                    /// *   Ready: The network service is connected.
                    /// *   Pending: The network service is being connected.
                    /// *   Failed: The network service fails to be connected.
                    /// *   Deleted: The network service is deleted.
                    /// *   Deleting: The network service is being deleted.
                    /// </summary>
                    [NameInMap("NetworkServiceStatus")]
                    [Validation(Required=false)]
                    public string NetworkServiceStatus { get; set; }

                    /// <summary>
                    /// The names of the security groups.
                    /// </summary>
                    [NameInMap("SecurityGroups")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroups { get; set; }

                    /// <summary>
                    /// The names of the vSwitches.
                    /// </summary>
                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }

                    /// <summary>
                    /// The virtual private cloud (VPC) ID.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// The ID of the endpoint for the private connection.
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// The ID of the endpoint service for the private connection.
                /// </summary>
                [NameInMap("EndpointServiceId")]
                [Validation(Required=false)]
                public string EndpointServiceId { get; set; }

                /// <summary>
                /// The custom domain name.
                /// </summary>
                [NameInMap("PrivateZoneName")]
                [Validation(Required=false)]
                public string PrivateZoneName { get; set; }

            }

            /// <summary>
            /// The information about the reverse private connection.
            /// </summary>
            [NameInMap("ReversePrivateVpcConnections")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyNetworkConfigReversePrivateVpcConnections> ReversePrivateVpcConnections { get; set; }
            public class GetServiceInstanceResponseBodyNetworkConfigReversePrivateVpcConnections : TeaModel {
                /// <summary>
                /// The ID of the endpoint for the reverse private connection.
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// The ID of the endpoint service for the reverse private connection.
                /// </summary>
                [NameInMap("EndpointServiceId")]
                [Validation(Required=false)]
                public string EndpointServiceId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the service instance that is used to implement hosted O\\&M.
        /// </summary>
        [NameInMap("OperatedServiceInstanceId")]
        [Validation(Required=false)]
        public string OperatedServiceInstanceId { get; set; }

        /// <summary>
        /// The end of the time range during which hosted O\\&M is implemented.
        /// </summary>
        [NameInMap("OperationEndTime")]
        [Validation(Required=false)]
        public string OperationEndTime { get; set; }

        [NameInMap("OperationExtraInfo")]
        [Validation(Required=false)]
        public string OperationExtraInfo { get; set; }

        /// <summary>
        /// The beginning of the time range during which hosted O\\&M is implemented.
        /// </summary>
        [NameInMap("OperationStartTime")]
        [Validation(Required=false)]
        public string OperationStartTime { get; set; }

        /// <summary>
        /// The outputs returned from creating the service instance.
        /// 
        /// *   If the service is deployed by using a ROS template, all output fields of the template are returned.
        /// *   If the service is deployed by calling an SPI operation, the output fields of the service provider and for the Compute Nest additional features are returned.
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// The parameters that are specified to deploy the service instance.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// The billing method of the service. Valid values:
        /// 
        /// *   Permanent: Once you purchase the service, you can use it permanently.
        /// *   Subscription: You purchase the service from Alibaba Cloud Marketplace and are charged for the service on a subscription basis.
        /// *   PayAsYouGo: You purchase the service from Alibaba Cloud Marketplace and are charged for the service on a pay-as-you-go basis.
        /// *   CustomFixTime: You are charged for the service based on a custom duration fixed by the service provider.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The package name.
        /// </summary>
        [NameInMap("PredefinedParameterName")]
        [Validation(Required=false)]
        public string PredefinedParameterName { get; set; }

        /// <summary>
        /// The deployment progress of the service instance. Unit: percentage.
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// The logon URL for the accounts in the resource directory corresponding to the service instance.
        /// </summary>
        [NameInMap("RdAccountLoginUrl")]
        [Validation(Required=false)]
        public string RdAccountLoginUrl { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The list of resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// The information about the service to which the service instance belongs.
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyService Service { get; set; }
        public class GetServiceInstanceResponseBodyService : TeaModel {
            /// <summary>
            /// The storage configurations of the service. The format in which the deployment information of a service is stored varies based on the deployment type of the service. In this case, the deployment information is stored in the JSON string format.
            /// </summary>
            [NameInMap("DeployMetadata")]
            [Validation(Required=false)]
            public string DeployMetadata { get; set; }

            /// <summary>
            /// The deployment type of the service. Valid values:
            /// 
            /// *   ros: The service is deployed by using Resource Orchestration Service (ROS).
            /// *   terraform: The service is deployed by using Terraform.
            /// *   ack: The service is deployed by using Container Service for Kubernetes (ACK).
            /// *   spi: The service is deployed by calling a service provider interface (SPI).
            /// *   operation: The service is deployed by using a hosted O\\&M service.
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// The time when the service was published.
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// The URL of the service documentation.
            /// </summary>
            [NameInMap("ServiceDocUrl")]
            [Validation(Required=false)]
            public string ServiceDocUrl { get; set; }

            /// <summary>
            /// The service ID.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// The information about the service.
            /// </summary>
            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyServiceServiceInfos> ServiceInfos { get; set; }
            public class GetServiceInstanceResponseBodyServiceServiceInfos : TeaModel {
                /// <summary>
                /// The URL of the service icon.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The language of the service instance.
                /// </summary>
                [NameInMap("Locale")]
                [Validation(Required=false)]
                public string Locale { get; set; }

                /// <summary>
                /// The service name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The description of the service.
                /// </summary>
                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

            }

            /// <summary>
            /// The URL of the service page.
            /// </summary>
            [NameInMap("ServiceProductUrl")]
            [Validation(Required=false)]
            public string ServiceProductUrl { get; set; }

            /// <summary>
            /// The type of the service. Valid values:
            /// 
            /// *   private: The service is a private service and is deployed within the account of a customer.
            /// *   managed: The service is a fully managed service and is deployed within the account of a service provider.
            /// *   operation: The service is a hosted O\\&M service.
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// The status of the service. Valid values:
            /// 
            /// Draft: The registration request of the service is pending to be submitted.
            /// 
            /// Submitted: The registration request of the service is submitted.
            /// 
            /// Approved: The registration request of the service is approved.
            /// 
            /// Online: The service is published.
            /// 
            /// Offline: The service is unpublished.
            /// 
            /// Deleted: The service is deleted.
            /// 
            /// Launching: The service is being published.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the service provider.
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// The URL of the service provider.
            /// </summary>
            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

            /// <summary>
            /// The service versions that can be updated.
            /// </summary>
            [NameInMap("UpgradableServiceVersions")]
            [Validation(Required=false)]
            public List<string> UpgradableServiceVersions { get; set; }

            /// <summary>
            /// The service version.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The custom version name defined by the service provider.
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// The ID of the service instance.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// The type of the service. Valid values:
        /// 
        /// *   private: The service is a private service and is deployed within the account of a customer.
        /// *   managed: The service is a fully managed service and is deployed within the account of a service provider.
        /// *   operation: The service is a hosted O\\&M service.
        /// *   poc: The service is a trial service.
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// The source of the service instance. Valid values:
        /// 
        /// *   User: Compute Nest customer
        /// *   Market: Alibaba Cloud Marketplace
        /// *   Supplier: Compute Nest service provider
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The deployment state of the service instance. Valid values:
        /// 
        /// *   Created
        /// *   Deploying
        /// *   DeployedFailed
        /// *   Deployed
        /// *   Upgrading
        /// *   Deleting
        /// *   Deleted
        /// *   DeletedFailed
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The description of the deployment state of the service instance.
        /// </summary>
        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the service provider.
        /// </summary>
        [NameInMap("SupplierUid")]
        [Validation(Required=false)]
        public long? SupplierUid { get; set; }

        /// <summary>
        /// The custom tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetServiceInstanceResponseBodyTags> Tags { get; set; }
        public class GetServiceInstanceResponseBodyTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The template name.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The time when the service instance was updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
