// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetRealtimeConcurrencyReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The time when the report was generated. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743474900488</para>
        /// </summary>
        [NameInMap("ReportDate")]
        [Validation(Required=false)]
        public long? ReportDate { get; set; }

        /// <summary>
        /// <para>The report details.</para>
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public GetRealtimeConcurrencyReportResponseBodyReports Reports { get; set; }
        public class GetRealtimeConcurrencyReportResponseBodyReports : TeaModel {
            /// <summary>
            /// <para>The list of reports.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetRealtimeConcurrencyReportResponseBodyReportsList> List { get; set; }
            public class GetRealtimeConcurrencyReportResponseBodyReportsList : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85bf7efa-a07c-498a-850e-99a5849b8589</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Intelligent outbound call scenario</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>First job group</para>
                /// </summary>
                [NameInMap("JobGroupName")]
                [Validation(Required=false)]
                public string JobGroupName { get; set; }

                /// <summary>
                /// <para>The configured maximum concurrency limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxConcurrencyLimit")]
                [Validation(Required=false)]
                public long? MaxConcurrencyLimit { get; set; }

                /// <summary>
                /// <para>The minimum concurrency limit for the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinConcurrencyLimit")]
                [Validation(Required=false)]
                public long? MinConcurrencyLimit { get; set; }

                /// <summary>
                /// <para>The occupied concurrency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OccupiedConcurrencyCount")]
                [Validation(Required=false)]
                public long? OccupiedConcurrencyCount { get; set; }

                /// <summary>
                /// <para>The time when the report was generated. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1743474900488</para>
                /// </summary>
                [NameInMap("ReportDate")]
                [Validation(Required=false)]
                public long? ReportDate { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
