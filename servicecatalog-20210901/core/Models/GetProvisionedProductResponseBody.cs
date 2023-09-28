// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetProvisionedProductResponseBody : TeaModel {
        /// <summary>
        /// The details of the product instance.
        /// </summary>
        [NameInMap("ProvisionedProductDetail")]
        [Validation(Required=false)]
        public GetProvisionedProductResponseBodyProvisionedProductDetail ProvisionedProductDetail { get; set; }
        public class GetProvisionedProductResponseBodyProvisionedProductDetail : TeaModel {
            /// <summary>
            /// The time when the product instance was created.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the task that was last run on the product instance.
            /// 
            /// The task can be one of the following types:
            /// 
            /// *   LaunchProduct: a task that launches the product.
            /// *   UpdateProvisionedProduct: a task that updates the information about the product instance.
            /// *   TerminateProvisionedProduct: a task that terminates the product instance.
            /// </summary>
            [NameInMap("LastProvisioningTaskId")]
            [Validation(Required=false)]
            public string LastProvisioningTaskId { get; set; }

            /// <summary>
            /// The ID of the last task that was successfully run on the product instance.
            /// 
            /// The task can be one of the following types:
            /// 
            /// *   LaunchProduct: a task that launches the product.
            /// *   UpdateProvisionedProduct: a task that updates the information about the product instance.
            /// *   TerminateProvisionedProduct: a task that terminates the product instance.
            /// </summary>
            [NameInMap("LastSuccessfulProvisioningTaskId")]
            [Validation(Required=false)]
            public string LastSuccessfulProvisioningTaskId { get; set; }

            /// <summary>
            /// The ID of the task that was last run.
            /// </summary>
            [NameInMap("LastTaskId")]
            [Validation(Required=false)]
            public string LastTaskId { get; set; }

            /// <summary>
            /// The ID of the RAM entity to which the product instance belongs.
            /// </summary>
            [NameInMap("OwnerPrincipalId")]
            [Validation(Required=false)]
            public string OwnerPrincipalId { get; set; }

            /// <summary>
            /// The type of the Resource Access Management (RAM) entity to which the product instance belongs. Valid values:
            /// 
            /// *   RamUser: a RAM user
            /// *   RamRole: a RAM role
            /// </summary>
            [NameInMap("OwnerPrincipalType")]
            [Validation(Required=false)]
            public string OwnerPrincipalType { get; set; }

            /// <summary>
            /// The ID of the product portfolio.
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// The ID of the product.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The name of the product.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// The ID of the product version.
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// The name of the product version.
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the product instance.
            /// </summary>
            [NameInMap("ProvisionedProductArn")]
            [Validation(Required=false)]
            public string ProvisionedProductArn { get; set; }

            /// <summary>
            /// The ID of the product instance.
            /// </summary>
            [NameInMap("ProvisionedProductId")]
            [Validation(Required=false)]
            public string ProvisionedProductId { get; set; }

            /// <summary>
            /// The name of the product instance.
            /// </summary>
            [NameInMap("ProvisionedProductName")]
            [Validation(Required=false)]
            public string ProvisionedProductName { get; set; }

            /// <summary>
            /// The type of the product instance.
            /// 
            /// The value is fixed as RosStack, which indicates an ROS stack.
            /// </summary>
            [NameInMap("ProvisionedProductType")]
            [Validation(Required=false)]
            public string ProvisionedProductType { get; set; }

            /// <summary>
            /// The ID of the Resource Orchestration Service (ROS) stack.
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// The ID of the region to which the ROS stack belongs.
            /// </summary>
            [NameInMap("StackRegionId")]
            [Validation(Required=false)]
            public string StackRegionId { get; set; }

            /// <summary>
            /// The state of the product instance. Valid values:
            /// 
            /// *   Available: The product instance was available.
            /// *   UnderChange: The information about the product instance was being changed.
            /// *   Error: An exception occurred on the product instance.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The message that is returned for the status of the product instance.
            /// 
            /// > This parameter is returned only when Error is returned for the Status parameter.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
