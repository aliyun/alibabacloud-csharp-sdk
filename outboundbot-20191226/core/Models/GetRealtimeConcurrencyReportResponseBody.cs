// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetRealtimeConcurrencyReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743474900488</para>
        /// </summary>
        [NameInMap("ReportDate")]
        [Validation(Required=false)]
        public long? ReportDate { get; set; }

        [NameInMap("Reports")]
        [Validation(Required=false)]
        public GetRealtimeConcurrencyReportResponseBodyReports Reports { get; set; }
        public class GetRealtimeConcurrencyReportResponseBodyReports : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetRealtimeConcurrencyReportResponseBodyReportsList> List { get; set; }
            public class GetRealtimeConcurrencyReportResponseBodyReportsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>85bf7efa-a07c-498a-850e-99a5849b8589</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                [NameInMap("JobGroupName")]
                [Validation(Required=false)]
                public string JobGroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxConcurrencyLimit")]
                [Validation(Required=false)]
                public long? MaxConcurrencyLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinConcurrencyLimit")]
                [Validation(Required=false)]
                public long? MinConcurrencyLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OccupiedConcurrencyCount")]
                [Validation(Required=false)]
                public long? OccupiedConcurrencyCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1743474900488</para>
                /// </summary>
                [NameInMap("ReportDate")]
                [Validation(Required=false)]
                public long? ReportDate { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
