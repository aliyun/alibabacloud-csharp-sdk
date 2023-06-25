// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackOperationRisksResponseBody : TeaModel {
        /// <summary>
        /// The operations on which the permissions are not granted to the Alibaba Cloud account of the caller.
        /// </summary>
        [NameInMap("MissingPolicyActions")]
        [Validation(Required=false)]
        public List<string> MissingPolicyActions { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources that are at risk.
        /// </summary>
        [NameInMap("RiskResources")]
        [Validation(Required=false)]
        public List<ListStackOperationRisksResponseBodyRiskResources> RiskResources { get; set; }
        public class ListStackOperationRisksResponseBodyRiskResources : TeaModel {
            /// <summary>
            /// The error code that is returned when the risk detection fails.
            /// 
            /// >  This parameter is not returned if the risk detection is successful.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The logical ID of the resource. The logical ID is the resource name that is defined in the template.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The error message that is returned when the risk detection fails.
            /// 
            /// >  This parameter is not returned if the risk detection is successful.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The physical ID of the resource. The physical ID is the actual ID of the resource.
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// The cause of the risk.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The ID of the request when the risk detection fails.
            /// 
            /// >  This parameter is not returned if the risk detection is successful.
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The type of the risk. Valid values:
            /// 
            /// *   Referenced: The resource is referenced by other resources.
            /// *   MaybeReferenced: The resource may be referenced by other resources.
            /// *   AdditionalRiskCheckRequired: An additional risk detection is required for a nested stack.
            /// *   OperationIgnored: The operation does not take effect for the resource.
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

        }

    }

}
