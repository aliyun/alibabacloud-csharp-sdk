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
        /// The resources that you want to import to a stack in the scenario of the Resource Management type.
        /// 
        /// >  This parameter is returned only for scenarios of the Resource Management type.
        /// </summary>
        [NameInMap("ResourcesToImport")]
        [Validation(Required=false)]
        public List<GenerateTemplateByScratchResponseBodyResourcesToImport> ResourcesToImport { get; set; }
        public class GenerateTemplateByScratchResponseBodyResourcesToImport : TeaModel {
            /// <summary>
            /// The ID of the logical resource.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The key-value mappings from string to string. The parameter value is a JSON string that identifies the resource that is imported.
            /// 
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
        /// The content of the template that is created for the scenario.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

    }

}
