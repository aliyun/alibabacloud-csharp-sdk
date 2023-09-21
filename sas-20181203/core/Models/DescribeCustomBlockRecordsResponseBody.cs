// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomBlockRecordsResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCustomBlockRecordsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCustomBlockRecordsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// An array that consists of the defense rules.
        /// </summary>
        [NameInMap("RecordList")]
        [Validation(Required=false)]
        public List<DescribeCustomBlockRecordsResponseBodyRecordList> RecordList { get; set; }
        public class DescribeCustomBlockRecordsResponseBodyRecordList : TeaModel {
            /// <summary>
            /// The timestamp generated when the block action on the IP address becomes invalid.
            /// </summary>
            [NameInMap("BlockExpireDate")]
            [Validation(Required=false)]
            public long? BlockExpireDate { get; set; }

            /// <summary>
            /// The blocked IP address.
            /// </summary>
            [NameInMap("BlockIp")]
            [Validation(Required=false)]
            public string BlockIp { get; set; }

            /// <summary>
            /// The direction of the traffic that is sent by the blocked IP address. Valid values:
            /// 
            /// *   **in**
            /// *   **out**
            /// </summary>
            [NameInMap("Bound")]
            [Validation(Required=false)]
            public string Bound { get; set; }

            /// <summary>
            /// The number of servers for which the defense rule is enabled.
            /// </summary>
            [NameInMap("EnableCount")]
            [Validation(Required=false)]
            public int? EnableCount { get; set; }

            /// <summary>
            /// The record ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The total number of servers on which the IP address is blocked.
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            /// <summary>
            /// The source of the defense rule.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The status of the defense rule against brute-force attacks. Valid values:
            /// 
            /// *   **0**: invalid.
            /// *   **1**: enabled.
            /// *   **2**: failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The servers for which the defense rule is enabled.
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeCustomBlockRecordsResponseBodyRecordListTargetList> TargetList { get; set; }
            public class DescribeCustomBlockRecordsResponseBodyRecordListTargetList : TeaModel {
                /// <summary>
                /// The ID of the destination asset.
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// The type of the query. Valid values:
                /// 
                /// *   Set the value to **uuid**.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
