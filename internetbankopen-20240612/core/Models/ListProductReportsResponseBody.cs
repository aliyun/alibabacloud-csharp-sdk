// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.InternetBankOpen20240612.Models
{
    public class ListProductReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results of the periodic report list, which includes the Reports array. The array is empty if no available reports exist.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProductReportsResponseBodyData Data { get; set; }
        public class ListProductReportsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The available report records sorted by period in descending order. By default, up to ten records are returned. If LatestOnly is set to true, at most one record is returned. The array is empty if no reports exist. A single natural week may have multiple report records; use ReportId to distinguish them. The list does not contain download URLs. The actual download status is subject to GetAiReport.</para>
            /// </summary>
            [NameInMap("Reports")]
            [Validation(Required=false)]
            public List<ListProductReportsResponseBodyDataReports> Reports { get; set; }
            public class ListProductReportsResponseBodyDataReports : TeaModel {
                /// <summary>
                /// <para>The end time of the natural week to which the report belongs, exclusive. The natural week ends at 00:00:00 on the following Monday in UTC+8 (Asia/Shanghai). This field is transformed to UTC RFC 3339 format and ends with Z. The example corresponds to 00:00:00 on Monday, November 9, 2026, UTC+8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("PeriodEnd")]
                [Validation(Required=false)]
                public string PeriodEnd { get; set; }

                /// <summary>
                /// <para>The start time of the natural week to which the report belongs, inclusive. The natural week is calculated based on UTC+8 (Asia/Shanghai) and starts at 00:00:00 on Monday. This field is transformed to UTC RFC 3339 format and ends with Z. The example corresponds to 00:00:00 on Monday, November 2, 2026, UTC+8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-01T16:00:00Z</para>
                /// </summary>
                [NameInMap("PeriodStart")]
                [Validation(Required=false)]
                public string PeriodStart { get; set; }

                /// <summary>
                /// <para>The product code of the data product to which the report belongs. This is consistent with the ProductCode of the current request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloudsec.demo.v1</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The unique ID of the periodic report. Pass this value as the reportId parameter to GetAiReport to query the current status of the report and obtain the download URL when it is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a</para>
                /// </summary>
                [NameInMap("ReportId")]
                [Validation(Required=false)]
                public string ReportId { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique identity of the request, which is used for Tracing Analysis and troubleshooting. Provide this identity when troubleshooting exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9634F2B3-B59C-5475-BA9F-96D95271882C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
