// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSceneDefensePoliciesRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management.
        /// 
        /// If you do not configure this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The status of the policy. Valid values:
        /// 
        /// *   **0**: disabled
        /// *   **1**: pending enabling
        /// *   **2**: enabled
        /// *   **3**: expired
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of the template that is used to create the policy. Valid values:
        /// 
        /// *   **promotion**: the Important Activity template
        /// *   **bypass**: the Forward All template
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
