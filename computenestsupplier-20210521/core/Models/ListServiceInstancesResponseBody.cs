// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstancesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.
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
        /// The information about service instances.
        /// </summary>
        [NameInMap("ServiceInstances")]
        [Validation(Required=false)]
        public List<ListServiceInstancesResponseBodyServiceInstances> ServiceInstances { get; set; }
        public class ListServiceInstancesResponseBodyServiceInstances : TeaModel {
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
            /// The time when the service instance expires.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

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
            /// The name of the service instance.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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

            /// <summary>
            /// The beginning of the time range during which hosted O\\&M is implemented.
            /// </summary>
            [NameInMap("OperationStartTime")]
            [Validation(Required=false)]
            public string OperationStartTime { get; set; }

            /// <summary>
            /// The parameters of the service instance.
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
            /// The deployment progress of the service instance. Unit: percentage.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The information about the service.
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public ListServiceInstancesResponseBodyServiceInstancesService Service { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesService : TeaModel {
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
                /// Indicates whether the private connection feature is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("EnablePrivateVpcConnection")]
                [Validation(Required=false)]
                public bool? EnablePrivateVpcConnection { get; set; }

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
                /// The name of the distribution source service provider.
                /// </summary>
                [NameInMap("SourceSupplierName")]
                [Validation(Required=false)]
                public string SourceSupplierName { get; set; }

                /// <summary>
                /// The status of the service.
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
            /// The source from which the service instance is created.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The status of the service instance. Valid values:
            /// 
            /// *   Created
            /// *   Deploying
            /// *   DeployedFailed
            /// *   Deployed
            /// *   Upgrading
            /// *   Deleting
            /// *   Deleted
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

            /// <summary>
            /// The Alibaba Cloud account ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
