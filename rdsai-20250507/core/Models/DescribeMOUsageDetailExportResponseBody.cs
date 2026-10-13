// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeMOUsageDetailExportResponseBody : TeaModel {
        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMOUsageDetailExportResponseBodyData Data { get; set; }
        public class DescribeMOUsageDetailExportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-01T01:50:03Z</para>
            /// </summary>
            [NameInMap("CompletedAt")]
            [Validation(Required=false)]
            public string CompletedAt { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-01T01:45:03Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://***</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The error message. Read this message to determine the error when the final value of Status is not SUCCESSED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tenant auth error</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The expiration time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-04T01:45:03Z</para>
            /// </summary>
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>The total size of the source backup file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>252</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The query filter conditions.</para>
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public DescribeMOUsageDetailExportResponseBodyDataFilters Filters { get; set; }
            public class DescribeMOUsageDetailExportResponseBodyDataFilters : TeaModel {
                /// <summary>
                /// <para>The API key that is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-rds-**</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>The end time of the instance in ISO 8601 format. The interval between EndTime and StartTime cannot exceed 30 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-30T01:45:03Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds_copilot**</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The model that is called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>glm-5</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The start time of the instance in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-28T01:45:03Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The target conversion format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>csv</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The total number of data rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public long? RowCount { get; set; }

            /// <summary>
            /// <para>The module status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pending / processing / completed / failed / expired</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
