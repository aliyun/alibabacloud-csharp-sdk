// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class UpdateFlowRequest : TeaModel {
        /// <summary>
        /// The new definition that you want to specify for the workflow.
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The new description that you want to specify for the workflow.
        /// </summary>
        [NameInMap("FlowDescription")]
        [Validation(Required=false)]
        public string FlowDescription { get; set; }

        /// <summary>
        /// The ID of the workflow whose information you want to update.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// The new name that you want to specify for the workflow.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

    }

}
