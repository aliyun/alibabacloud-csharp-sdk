// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateMOUsageDetailExportResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateMOUsageDetailExportResponseBodyData Data { get; set; }
        public class CreateMOUsageDetailExportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-15T21:18:45Z</para>
            /// </summary>
            [NameInMap("CompletedAt")]
            [Validation(Required=false)]
            public string CompletedAt { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-15T21:14:45Z</para>
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
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>picture owner error</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The expiration time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-07T21:14:45Z</para>
            /// </summary>
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>The file size in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The query filter conditions.</para>
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public CreateMOUsageDetailExportResponseBodyDataFilters Filters { get; set; }
            public class CreateMOUsageDetailExportResponseBodyDataFilters : TeaModel {
                /// <summary>
                /// <para>The API key to use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-***</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>The inspection end time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-10T02:02:20Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds_copilot**_public_cn-******</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The model to call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-flash</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The inspection start time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-05T16:00:00Z</para>
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
            /// <para>The OssKey passed when calling the operation. (This field is deprecated)</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddd6*****2a76</para>
            /// </summary>
            [NameInMap("OssKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            /// <summary>
            /// <para>The total number of data rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
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
