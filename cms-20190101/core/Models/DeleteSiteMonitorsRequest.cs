// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteSiteMonitorsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to delete the alert rules configured for the site monitoring tasks. Valid values:
        /// 
        /// *   true (default value)
        /// *   false
        /// </summary>
        [NameInMap("IsDeleteAlarms")]
        [Validation(Required=false)]
        public bool? IsDeleteAlarms { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the site monitoring tasks that you want to delete. Separate multiple task IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

    }

}
