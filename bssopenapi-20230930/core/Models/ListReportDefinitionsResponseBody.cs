// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListReportDefinitionsResponseBody : TeaModel {
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        [NameInMap("ReportDefinitions")]
        [Validation(Required=false)]
        public List<ListReportDefinitionsResponseBodyReportDefinitions> ReportDefinitions { get; set; }
        public class ListReportDefinitionsResponseBodyReportDefinitions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05</para>
            /// </summary>
            [NameInMap("BeginBillingCycle")]
            [Validation(Required=false)]
            public string BeginBillingCycle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-bill</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567812345678</para>
            /// </summary>
            [NameInMap("OssBucketOwnerAccountId")]
            [Validation(Required=false)]
            public long? OssBucketOwnerAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bill/</para>
            /// </summary>
            [NameInMap("OssBucketPath")]
            [Validation(Required=false)]
            public string OssBucketPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ReportSourceName")]
            [Validation(Required=false)]
            public string ReportSourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ReportSourceType")]
            [Validation(Required=false)]
            public string ReportSourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123321</para>
            /// </summary>
            [NameInMap("ReportTaskId")]
            [Validation(Required=false)]
            public long? ReportTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BillingItemDetailForBillingPeriod</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-21 10:36:31</para>
            /// </summary>
            [NameInMap("SubscribeCreateTime")]
            [Validation(Required=false)]
            public string SubscribeCreateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
