// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstancesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the service instances.
        /// </summary>
        [NameInMap("ServiceInstances")]
        [Validation(Required=false)]
        public List<ListServiceInstancesResponseBodyServiceInstances> ServiceInstances { get; set; }
        public class ListServiceInstancesResponseBodyServiceInstances : TeaModel {
            /// <summary>
            /// The business state of the service instance. Valid values:
            /// 
            /// *   Normal
            /// *   Renewing
            /// *   RenewFailed
            /// *   Expired
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
            /// The time when the service instance expires.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud Marketplace instance.
            /// </summary>
            [NameInMap("MarketInstanceId")]
            [Validation(Required=false)]
            public string MarketInstanceId { get; set; }

            /// <summary>
            /// The name of the service instance.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the managed service instance.
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

            /// <summary>
            /// The beginning of the time range during which hosted O\\&M is implemented.
            /// </summary>
            [NameInMap("OperationStartTime")]
            [Validation(Required=false)]
            public string OperationStartTime { get; set; }

            /// <summary>
            /// The order ID.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// The information returned after the service instance is created.
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// The parameters of the service instance.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// The billing method. Valid values:
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
            /// The deployment progress of the service instance, in percentage.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The resources.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// The services.
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public ListServiceInstancesResponseBodyServiceInstancesService Service { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesService : TeaModel {
                /// <summary>
                /// The commodity details.
                /// </summary>
                [NameInMap("Commodity")]
                [Validation(Required=false)]
                public ListServiceInstancesResponseBodyServiceInstancesServiceCommodity Commodity { get; set; }
                public class ListServiceInstancesResponseBodyServiceInstancesServiceCommodity : TeaModel {
                    /// <summary>
                    /// The configuration metadata related to SaaS Boost.
                    /// </summary>
                    [NameInMap("SaasBoostMetadata")]
                    [Validation(Required=false)]
                    public string SaasBoostMetadata { get; set; }

                    /// <summary>
                    /// The platform type. Valid values:
                    /// 
                    /// *   marketplace: Alibaba Cloud Marketplace.
                    /// *   Css: Lingxiao.
                    /// *   SaasBoost: SaaS Boost.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The deployment type of the service. Valid values:
                /// 
                /// *   ros: The service is deployed by using Resource Orchestration Service (ROS).
                /// *   terraform: The service is deployed by using Terraform.
                /// *   ack: The service is deployed by using Alibaba Cloud Container Service for Kubernetes (ACK).
                /// *   spi: The service is deployed by calling the Service Provider Interface (SPI).
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
                public List<ListServiceInstancesResponseBodyServiceInstancesServiceServiceInfos> ServiceInfos { get; set; }
                public class ListServiceInstancesResponseBodyServiceInstancesServiceServiceInfos : TeaModel {
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
                    /// The name of the service.
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
                /// The service state.
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
            /// The service instance ID.
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
            /// The source from which the service instance is created.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The state of the service instance. Valid values:
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
            /// The description of the deployment of the service instance.
            /// </summary>
            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

            /// <summary>
            /// The custom tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServiceInstancesResponseBodyServiceInstancesTags> Tags { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesTags : TeaModel {
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

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
