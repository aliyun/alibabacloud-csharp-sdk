// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryNetworkRttReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. <c>200</c> indicates that the request is processed successfully. Other values indicate that the processing failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The description of the request processing result. If the request is successful, <c>success</c> is usually returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of network RTT report data.</para>
        /// </summary>
        [NameInMap("NetworkRttReportDataModel")]
        [Validation(Required=false)]
        public List<QueryNetworkRttReportResponseBodyNetworkRttReportDataModel> NetworkRttReportDataModel { get; set; }
        public class QueryNetworkRttReportResponseBodyNetworkRttReportDataModel : TeaModel {
            /// <summary>
            /// <para>The ID of the app instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The number of users that meet the low-RTT criteria of the report. Unit: users. The current API operation does not return the specific threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("LowRttUserCount")]
            [Validation(Required=false)]
            public long? LowRttUserCount { get; set; }

            /// <summary>
            /// <para>The ratio of low-RTT users to the total number of users involved in the statistics. Valid values: 0 to 1. To obtain the percentage, multiply the value by 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.85</para>
            /// </summary>
            [NameInMap("LowRttUserRate")]
            [Validation(Required=false)]
            public double? LowRttUserRate { get; set; }

            /// <summary>
            /// <para>The ID of the business region to which the report data belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The average RTT of all users involved in the statistics. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35.8</para>
            /// </summary>
            [NameInMap("RttAvg")]
            [Validation(Required=false)]
            public double? RttAvg { get; set; }

            /// <summary>
            /// <para>The maximum value among the average RTTs of all users. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86.2</para>
            /// </summary>
            [NameInMap("RttMax")]
            [Validation(Required=false)]
            public double? RttMax { get; set; }

            /// <summary>
            /// <para>The minimum value among the average RTTs of all users. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.5</para>
            /// </summary>
            [NameInMap("RttMin")]
            [Validation(Required=false)]
            public double? RttMin { get; set; }

            /// <summary>
            /// <para>The end time of the statistical window. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The string itself does not carry a time zone and is interpreted as Asia/Shanghai (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01 10:05:00</para>
            /// </summary>
            [NameInMap("StatEndDate")]
            [Validation(Required=false)]
            public string StatEndDate { get; set; }

            /// <summary>
            /// <para>The start time of the statistical window. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The string itself does not carry a time zone and is interpreted as Asia/Shanghai (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01 10:00:00</para>
            /// </summary>
            [NameInMap("StatStartDate")]
            [Validation(Required=false)]
            public string StatStartDate { get; set; }

            /// <summary>
            /// <para>The total number of users involved in the RTT calculation for the current statistical window. Unit: users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalUserCount")]
            [Validation(Required=false)]
            public long? TotalUserCount { get; set; }

        }

        /// <summary>
        /// <para>The page number corresponding to the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page used in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
