// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class UpdateFlowRequest : TeaModel {
        /// <summary>
        /// The definition of the workflow. The definition must comply with the flow definition language (FDL) syntax. Considering compatibility, the system supports the two workflow definition specifications.
        /// 
        /// >  In the preceding workflow definition example, Name:my_flow_name is the workflow name, which must be consistent with the input parameter Name
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The description of the flow.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Alibaba Cloud resource name (ARN) of the authorized role on which the execution of the flow relies. During the execution of the flow, the flow execution engine assumes the role to call API operations of relevant services.
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// The type of the flow. Valid value: **FDL**.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
