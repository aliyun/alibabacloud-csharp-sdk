// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// Data redundancy type
        /// </summary>
        [NameInMap("dataRedundancyType")]
        [Validation(Required=false)]
        public string DataRedundancyType { get; set; }

        /// <summary>
        /// The description of the project.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the project. The name must be unique in a region. You cannot change the name after you create the project. The name must meet the following requirements:
        /// 
        /// *   The name must be unique.
        /// *   It can contain only lowercase letters, digits, and hyphens (-).
        /// *   It must start and end with a lowercase letter or a digit.
        /// *   It must be 3 to 63 characters in length.
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
