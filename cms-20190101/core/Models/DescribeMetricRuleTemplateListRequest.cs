// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateListRequest : TeaModel {
        /// <summary>
        /// Specifies whether to display the history of applying the alert templates to application groups. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("History")]
        [Validation(Required=false)]
        public bool? History { get; set; }

        /// <summary>
        /// The keyword of the alert template name.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The name of the alert template.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The sorting order. Valid values:
        /// 
        /// *   true (default): ascending order
        /// *   false: descending order
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public bool? Order { get; set; }

        /// <summary>
        /// The sorting basis. Valid values:
        /// 
        /// *   gmtMotified: sorts alert templates by modification time
        /// *   gmtCreate (default): sorts alert templates by creation time
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the alert template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
