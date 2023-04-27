// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateSLARulesShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > :To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](~~181330~~).
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The timeout period. Unit: minutes.
        /// </summary>
        [NameInMap("SlaRuleList")]
        [Validation(Required=false)]
        public string SlaRuleListShrink { get; set; }

        /// <summary>
        /// The list of SLA rules.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
