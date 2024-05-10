// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateSummaryResponseBody : TeaModel {
        /// <summary>
        /// The description of the stack template.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The metadata that is defined in the template.
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The declarations of the parameters in the template.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Parameters { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource identifier summaries.\\
        /// A summary describes the resource that you want to import and the properties that are used to identify the resource during the import. For example, VpcId is an identifier property of ALIYUN::ECS::VPC.
        /// </summary>
        [NameInMap("ResourceIdentifierSummaries")]
        [Validation(Required=false)]
        public List<GetTemplateSummaryResponseBodyResourceIdentifierSummaries> ResourceIdentifierSummaries { get; set; }
        public class GetTemplateSummaryResponseBodyResourceIdentifierSummaries : TeaModel {
            /// <summary>
            /// The logical IDs of all resources of the type that is specified by ResouceType in the template.
            /// </summary>
            [NameInMap("LogicalResourceIds")]
            [Validation(Required=false)]
            public List<string> LogicalResourceIds { get; set; }

            /// <summary>
            /// The resource properties. You can use a resource property to identify the resource that you want to manage. For example, VpcId is an identifier property of ALIYUN::ECS::VPC.
            /// </summary>
            [NameInMap("ResourceIdentifiers")]
            [Validation(Required=false)]
            public List<string> ResourceIdentifiers { get; set; }

            /// <summary>
            /// The resource type.
            /// 
            /// > The resource import feature is supported for the resource type.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// All resource types that are used in the template.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// The version of the template.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
