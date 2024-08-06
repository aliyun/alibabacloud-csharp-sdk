/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class CreateFlowRequest : TeaModel {
        /// <summary>
        /// The definition of the workflow. The definition must comply with the flow definition language (FDL) syntax. Considering compatibility, the system supports two flow definition specifications.
        /// 
        /// >  In the preceding flow definition example, Name:my_flow_name is the workflow name, which must be consistent with the input parameter Name
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The description of the flow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The execution mode. Valid values: Express and Standard. Considering compatibility, an empty string is equivalent to the Standard execution mode.
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// The path of the external storage.
        /// </summary>
        [NameInMap("ExternalStorageLocation")]
        [Validation(Required=false)]
        public string ExternalStorageLocation { get; set; }

        /// <summary>
        /// The name of the flow. The name is unique within the same region and cannot be modified after the flow is created. Set this parameter based on the following rules:
        /// 
        /// *   The name can contain letters, digits, underscores (_), and hyphens (-).
        /// *   The name must start with a letter or an underscore (_).
        /// *   The name is case-sensitive.
        /// *   The name must be 1 to 128 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Alibaba Cloud resource name (ARN) of the authorized role on which the execution of the flow relies. During the execution of the flow, CloudFlow assumes the role to call API operations of relevant services.
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// The type of the flow. Set this parameter to **FDL**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
