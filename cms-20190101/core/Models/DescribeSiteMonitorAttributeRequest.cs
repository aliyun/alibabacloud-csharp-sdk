// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the information of the alert rules that are configured for the site monitoring task. Valid values:
        /// 
        /// *   true: The system returns the information of the alert rules that are configured for the site monitoring task.
        /// *   false (default): The system does not return the information of the alert rules that are configured for the site monitoring task.
        /// </summary>
        [NameInMap("IncludeAlert")]
        [Validation(Required=false)]
        public bool? IncludeAlert { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the site monitoring task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
