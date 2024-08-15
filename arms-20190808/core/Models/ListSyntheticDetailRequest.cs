// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListSyntheticDetailRequest : TeaModel {
        /// <summary>
        /// An array of filter conditions. This parameter is required.
        /// 
        /// *   To query the list of synthetic test results, set this parameter in the following format: [{"Key":"taskType","OpType":"in","Value":[Task type]}].
        /// *   To query the result details of a synthetic monitoring task, set this parameter in the following format: [{"Key":"dataId","OpType":"eq","Value":"dataId"}]. dataId is returned when you query the list of synthetic test results.
        /// </summary>
        [NameInMap("AdvancedFilters")]
        [Validation(Required=false)]
        public List<ListSyntheticDetailRequestAdvancedFilters> AdvancedFilters { get; set; }
        public class ListSyntheticDetailRequestAdvancedFilters : TeaModel {
            /// <summary>
            /// The filter condition. The taskType and dataId fields are supported.
            /// 
            /// *   To query the list of synthetic test results, set the key to taskType.
            /// *   To query the result details of a synthetic monitoring task, set the key to dataId.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The type of the filter condition. Valid values: eq and in. eq: equal to. in: include.
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            /// <summary>
            /// The value of the filter condition. The type of the task. Valid values: 1: ICMP 2: TCP 3: DNS 4: HTTP 5: website speed measurement 6: file download
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

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

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ExactFilters")]
        [Validation(Required=false)]
        public List<ListSyntheticDetailRequestExactFilters> ExactFilters { get; set; }
        public class ListSyntheticDetailRequestExactFilters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        /// <summary>
        /// The filter condition. This parameter is required.
        /// 
        /// *   To query the result of a synthetic monitoring task, set this parameter in the following format: {"taskId":"${taskId}"}.
        /// *   To query the result details of a synthetic monitoring task, set this parameter in the following format: {"taskId":"${taskId}","dataId":"${dataId}"}.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Filters { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("SyntheticType")]
        [Validation(Required=false)]
        public int? SyntheticType { get; set; }

    }

}
