// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.InternetBankOpen20240612.Models
{
    public class ListProductReportsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProductReportsResponseBodyData Data { get; set; }
        public class ListProductReportsResponseBodyData : TeaModel {
            [NameInMap("Reports")]
            [Validation(Required=false)]
            public List<ListProductReportsResponseBodyDataReports> Reports { get; set; }
            public class ListProductReportsResponseBodyDataReports : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-11-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("PeriodEnd")]
                [Validation(Required=false)]
                public string PeriodEnd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-11-01T16:00:00Z</para>
                /// </summary>
                [NameInMap("PeriodStart")]
                [Validation(Required=false)]
                public string PeriodStart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloudsec.demo.v1</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a</para>
                /// </summary>
                [NameInMap("ReportId")]
                [Validation(Required=false)]
                public string ReportId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9634F2B3-B59C-5475-BA9F-96D95271882C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
