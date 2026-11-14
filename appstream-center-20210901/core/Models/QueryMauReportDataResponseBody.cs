// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryMauReportDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates that the request is successful. Other values indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of monthly active user report data.</para>
        /// </summary>
        [NameInMap("MauReportDataModel")]
        [Validation(Required=false)]
        public List<QueryMauReportDataResponseBodyMauReportDataModel> MauReportDataModel { get; set; }
        public class QueryMauReportDataResponseBodyMauReportDataModel : TeaModel {
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
            /// <para>The number of monthly active users in the statistical month. Unit: users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>286</para>
            /// </summary>
            [NameInMap("Mau")]
            [Validation(Required=false)]
            public long? Mau { get; set; }

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
            /// <para>The statistical cutoff date used for the month. Format: <c>yyyy-MM-dd</c>. For the last month, the date is usually the day before the requested EndDate. The date is interpreted as a natural date in the Asia/Shanghai (UTC+8) time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-29</para>
            /// </summary>
            [NameInMap("StatDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

            /// <summary>
            /// <para>The statistical month. Format: <c>yyyy-MM</c>. The month is interpreted as a natural month in the Asia/Shanghai (UTC+8) time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09</para>
            /// </summary>
            [NameInMap("StatMonth")]
            [Validation(Required=false)]
            public string StatMonth { get; set; }

        }

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
