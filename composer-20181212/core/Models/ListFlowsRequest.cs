// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListFlowsRequest : TeaModel {
        /// <summary>
        /// The filter condition, which is in the JSON format of {"key":"value"}. Example: {"key1":"value1"}
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The page number of the current page. Minimum value: 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Specifies the number of workflows to return on each page. A page can contain a maximum of 100 workflows. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
