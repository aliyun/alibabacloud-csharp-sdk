// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetDataBatchIngestionResponseBody : TeaModel {
        [NameInMap("DataBatchIngestion")]
        [Validation(Required=false)]
        public GetDataBatchIngestionResponseBodyDataBatchIngestion DataBatchIngestion { get; set; }
        public class GetDataBatchIngestionResponseBodyDataBatchIngestion : TeaModel {
            [NameInMap("ApsaraDataIngestionIds")]
            [Validation(Required=false)]
            public List<string> ApsaraDataIngestionIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled。</para>
            /// </summary>
            [NameInMap("AutoScanNew")]
            [Validation(Required=false)]
            public string AutoScanNew { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("DataBatchIngestionEffectTime")]
            [Validation(Required=false)]
            public string DataBatchIngestionEffectTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>full。</para>
            /// </summary>
            [NameInMap("DataBatchIngestionMode")]
            [Validation(Required=false)]
            public string DataBatchIngestionMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("DataBatchIngestionSetTime")]
            [Validation(Required=false)]
            public string DataBatchIngestionSetTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pending。</para>
            /// </summary>
            [NameInMap("DataBatchIngestionStatus")]
            [Validation(Required=false)]
            public string DataBatchIngestionStatus { get; set; }

            [NameInMap("DataIngestions")]
            [Validation(Required=false)]
            public List<GetDataBatchIngestionResponseBodyDataBatchIngestionDataIngestions> DataIngestions { get; set; }
            public class GetDataBatchIngestionResponseBodyDataBatchIngestionDataIngestions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas_process_ingestion_173326*******。</para>
                /// </summary>
                [NameInMap("DataIngestionId")]
                [Validation(Required=false)]
                public string DataIngestionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>enabled。</para>
                /// </summary>
                [NameInMap("DataIngestionStatus")]
                [Validation(Required=false)]
                public string DataIngestionStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas_process_log_173326*******。</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas。</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alibaba_cloud。</para>
                /// </summary>
                [NameInMap("VendorId")]
                [Validation(Required=false)]
                public string VendorId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true。</para>
            /// </summary>
            [NameInMap("DataSourceRecognizeEnabled")]
            [Validation(Required=false)]
            public bool? DataSourceRecognizeEnabled { get; set; }

            [NameInMap("LogUserIds")]
            [Validation(Required=false)]
            public List<string> LogUserIds { get; set; }

            [NameInMap("RecommendDataIngestionIds")]
            [Validation(Required=false)]
            public List<string> RecommendDataIngestionIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
