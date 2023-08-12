// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplateByScratchResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources that you want to import into a stack in the scenario.
        /// 
        /// > This parameter is returned only if the scenario is of the Resource Management type.
        /// </summary>
        [NameInMap("ResourcesToImport")]
        [Validation(Required=false)]
        public List<GenerateTemplateByScratchResponseBodyResourcesToImport> ResourcesToImport { get; set; }
        public class GenerateTemplateByScratchResponseBodyResourcesToImport : TeaModel {
            /// <summary>
            /// The logical ID of the resource.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The key-value mapping between strings. The value is a JSON string that identifies the resource that you want to import into a stack.\
            /// A key is an identifier for a resource, and a value is an assignment of data to the key. For example, VpcId is a key that indicates the ID of a virtual private cloud (VPC), and `vpc-bp1m6fww66xbntjyc****"` is a value that is assigned to VpcId.
            /// </summary>
            [NameInMap("ResourceIdentifier")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceIdentifier { get; set; }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The template content of the scenario.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

    }

}
