// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the application.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyData Data { get; set; }
        public class GetApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// App ID
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// The resource tag.
            /// </summary>
            [NameInMap("Checklist")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyDataChecklist> Checklist { get; set; }
            public class GetApplicationResponseBodyDataChecklist : TeaModel {
                /// <summary>
                /// The resource tag.
                /// </summary>
                [NameInMap("Lifecycle")]
                [Validation(Required=false)]
                public string Lifecycle { get; set; }

                /// <summary>
                /// The region in which the instance resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The message returned for verification.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The service code.
                /// </summary>
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// The verification result.
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// The resource specifications.
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

            }

            /// <summary>
            /// The time when the app was created
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeployPercent")]
            [Validation(Required=false)]
            public double? DeployPercent { get; set; }

            /// <summary>
            /// Application description
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// The URL of the image in the database.
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            /// <summary>
            /// App name
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The billing results.
            /// </summary>
            [NameInMap("PriceList")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyDataPriceList> PriceList { get; set; }
            public class GetApplicationResponseBodyDataPriceList : TeaModel {
                /// <summary>
                /// The billing method.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The quantity.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Resource Fill Labels.
                /// </summary>
                [NameInMap("Lifecycle")]
                [Validation(Required=false)]
                public string Lifecycle { get; set; }

                /// <summary>
                /// The unit price of the instance.
                /// </summary>
                [NameInMap("OnePrice")]
                [Validation(Required=false)]
                public double? OnePrice { get; set; }

                /// <summary>
                /// The original price of the instance.
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                /// <summary>
                /// The service duration.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// The total price.
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// Unit: USD per hour
                /// </summary>
                [NameInMap("PriceUnit")]
                [Validation(Required=false)]
                public string PriceUnit { get; set; }

                /// <summary>
                /// The region in which the instance resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The error message that is returned when a price query fails.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// Product code
                /// </summary>
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                /// <summary>
                /// The instance type. This parameter indicates the information about the instance type. For example, 192.168.0.0/16 may be returned for a Virtual Private Cloud (VPC) instance, ecs.g5.large may be returned for an Elastic Compute Service (ECS) instance, and slb.s1.small may be returned for a Server Load Balancer (SLB) instance. If the resource does not have a specific type, an empty value is returned.
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// The creation mode. Valid values:\\
                /// 1: creates a new instance.\\
                /// 2: imports an instance.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the resource group to which the app belongs
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The resource specification.
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetApplicationResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// The billing method.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The resource tag.
                /// </summary>
                [NameInMap("Lifecycle")]
                [Validation(Required=false)]
                public string Lifecycle { get; set; }

                [NameInMap("NodeLabel")]
                [Validation(Required=false)]
                public string NodeLabel { get; set; }

                /// <summary>
                /// The deployment result.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The service code.
                /// </summary>
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The resource deployment result.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// Verification passed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the template associated with the application
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// Reason for the request failure
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Request ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
