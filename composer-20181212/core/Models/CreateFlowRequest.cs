// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class CreateFlowRequest : TeaModel {
        /// <summary>
        /// The definition of the workflow, which must be a JSON string.
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The description of the workflow.
        /// </summary>
        [NameInMap("FlowDescription")]
        [Validation(Required=false)]
        public string FlowDescription { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The source of the workflow. Valid values:
        /// 
        /// *   Default: Create the workflow in the console.
        /// *   CloudConfig: Create the workflow by using Cloud Config.
        /// *   Solution: Create the workflow by using Logic Composer.
        /// </summary>
        [NameInMap("FlowSource")]
        [Validation(Required=false)]
        public string FlowSource { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
