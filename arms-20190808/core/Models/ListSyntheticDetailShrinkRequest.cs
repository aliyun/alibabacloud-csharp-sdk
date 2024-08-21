// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListSyntheticDetailShrinkRequest : TeaModel {
        /// <summary>
        /// An array of filter conditions. This parameter is required.
        /// 
        /// *   To query the list of synthetic test results, set this parameter in the following format: [{"Key":"taskType","OpType":"in","Value":[Task type]}].
        /// *   To query the result details of a synthetic monitoring task, set this parameter in the following format: [{"Key":"dataId","OpType":"eq","Value":"dataId"}]. dataId is returned when you query the list of synthetic test results.
        /// </summary>
        [NameInMap("AdvancedFilters")]
        [Validation(Required=false)]
        public string AdvancedFiltersShrink { get; set; }

        /// <summary>
        /// The type of the results. Set the value to SYNTHETIC.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The type of the list that contains the results. This parameter is required. Valid values:
        /// 
        /// *   ICMP_LIST
        /// *   TCP_LIST
        /// *   DNS_LIST
        /// *   HTTP_LIST
        /// *   WEBSITE_LIST
        /// *   DOWNLOAD_LIST
        /// *   ALL
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// The timestamp of the end time of the query. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// A reserved field.
        /// </summary>
        [NameInMap("ExactFilters")]
        [Validation(Required=false)]
        public string ExactFiltersShrink { get; set; }

        /// <summary>
        /// The filter condition. This parameter is required.
        /// 
        /// *   To query the result of a synthetic monitoring task, set this parameter in the following format: {"taskId":"${taskId}"}.
        /// *   To query the result details of a synthetic monitoring task, set this parameter in the following format: {"taskId":"${taskId}","dataId":"${dataId}"}.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string FiltersShrink { get; set; }

        /// <summary>
        /// The order in which results are sorted. Valid values:
        /// 
        /// - `ASC`: ascending order
        /// - `DESC`: descending order
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The field based on which results are sorted. Set the value to timestamp.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region. Set the value to cn-hangzhou.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The timestamp of the start time of the query. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The type of the synthetic test. Valid values: 1 and 2. 1 represents an immediate test, and 2 represents a scheduled test.
        /// </summary>
        [NameInMap("SyntheticType")]
        [Validation(Required=false)]
        public int? SyntheticType { get; set; }

    }

}
