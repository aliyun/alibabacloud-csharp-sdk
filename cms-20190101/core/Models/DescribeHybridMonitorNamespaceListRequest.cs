// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorNamespaceListRequest : TeaModel {
        /// <summary>
        /// The search keyword.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// The name can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Page numbers start from 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Page numbers start from 1. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to return the configuration details of metric import tasks for Alibaba Cloud services and the number of metric import tasks for third-party services. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("ShowTaskStatistic")]
        [Validation(Required=false)]
        public bool? ShowTaskStatistic { get; set; }

    }

}
