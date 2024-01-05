// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdatePolicyBindingShrinkRequest : TeaModel {
        /// <summary>
        /// The advanced options.
        /// </summary>
        [NameInMap("AdvancedOptions")]
        [Validation(Required=false)]
        public string AdvancedOptionsShrink { get; set; }

        /// <summary>
        /// The ID of the data source.
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Specifies whether to disable the backup policy for the data source.
        /// 
        /// *   true: disables the backup policy for the data source
        /// *   false: enables the backup policy for the data source
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The description of the association.
        /// </summary>
        [NameInMap("PolicyBindingDescription")]
        [Validation(Required=false)]
        public string PolicyBindingDescription { get; set; }

        /// <summary>
        /// The ID of the backup policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **UDM_ECS**: ECS instance backup
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
