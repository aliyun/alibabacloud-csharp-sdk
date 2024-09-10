// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomMetricListRequest : TeaModel {
        /// <summary>
        /// The dimensions that specify the resources for which you want to query custom metrics.
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// 
        /// For more information, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The MD5 value of the HTTP request body. The MD5 value is a 128-bit hash value used to verify the uniqueness of the reported custom metrics.
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// The name of the custom metric.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Pages start from page 1. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
