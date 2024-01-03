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
            /// The description of the application.
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
            /// The URL of the application topology image.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The message returned for the request.
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
            /// The URL of the image in the database.
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
                /// The service code.
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
                /// The creation mode. Valid values:\
                /// 1: creates a new instance.\
                /// 2: imports an instance.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 1411182597819805/topo-MCEXDI5EL2OM10NY.json
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
            /// CADT application
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// Possible application states:
        /// 
        /// *   Creating: The application is being created.
        /// *   Modified: The application has been modified.
        /// *   Verifying: The application is being verified.
        /// *   Verified_Failure: The application failed to pass the verification.
        /// *   Verified_Success: The application has passed the verification.
        /// *   Valuating: Fees are being calculated for the application.
        /// *   Valuating_Failure: Fees failed to be calculated for the application.
        /// *   Valuating_Success: Fees are calculated for the application.
        /// *   Deploying: The application is being deployed.
        /// *   Deployed_Failure: The application failed to be deployed.
        /// *   Partially_Deployed_Success: Some resources of the application are deployed.
        /// *   Deployed_Success: The application is deployed.
        /// *   Destroying: The application is being released.
        /// *   Delayed_Destroy: The application release is delayed.
        /// *   Destroyed_Failure: The application failed to be released.
        /// *   Partially_Destroyed_Success: Some resources of the application are released.
        /// *   Destroyed_Success: The application is released.
        /// *   Revised: The application architecture is adjusted.
        /// *   Verifying_In_Revision: The application resources are being verified during architecture adjustment.
        /// *   Verified_Failure_In_Revision: The application resources failed to pass the verification during architecture adjustment.
        /// *   Verified_Success_In_Revision: The application resources are verified during architecture adjustment.
        /// *   Valuating_In_Revision: Fees are being calculated for the application during architecture adjustment.
        /// *   Valuating_Failure_In_Revision: Fees failed to be calculated for the application during architecture adjustment.
        /// *   Valuating_Success_In_Revision: Fees are calculated for the application during architecture adjustment.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
