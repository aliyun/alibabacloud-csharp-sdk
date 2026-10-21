// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetDataBatchIngestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The data batch ingestion configuration.</para>
        /// </summary>
        [NameInMap("DataBatchIngestion")]
        [Validation(Required=false)]
        public GetDataBatchIngestionResponseBodyDataBatchIngestion DataBatchIngestion { get; set; }
        public class GetDataBatchIngestionResponseBodyDataBatchIngestion : TeaModel {
            /// <summary>
            /// <para>The list of cloud native mode ingestion IDs.</para>
            /// </summary>
            [NameInMap("ApsaraDataIngestionIds")]
            [Validation(Required=false)]
            public List<string> ApsaraDataIngestionIds { get; set; }

            /// <summary>
            /// <para>Indicates whether new users are automatically discovered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoScanNew")]
            [Validation(Required=false)]
            public string AutoScanNew { get; set; }

            /// <summary>
            /// <para>The effective period of the data batch ingestion. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("DataBatchIngestionEffectTime")]
            [Validation(Required=false)]
            public string DataBatchIngestionEffectTime { get; set; }

            /// <summary>
            /// <para>The batch data ingestion mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("DataBatchIngestionMode")]
            [Validation(Required=false)]
            public string DataBatchIngestionMode { get; set; }

            /// <summary>
            /// <para>The time when the data batch ingestion was configured. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("DataBatchIngestionSetTime")]
            [Validation(Required=false)]
            public string DataBatchIngestionSetTime { get; set; }

            /// <summary>
            /// <para>The accessed state of the data batch ingestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: Pending.</description></item>
            /// <item><description>running: In effect.</description></item>
            /// <item><description>success: Succeeded.</description></item>
            /// <item><description>failed: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("DataBatchIngestionStatus")]
            [Validation(Required=false)]
            public string DataBatchIngestionStatus { get; set; }

            /// <summary>
            /// <para>The list of data ingestions.</para>
            /// </summary>
            [NameInMap("DataIngestions")]
            [Validation(Required=false)]
            public List<GetDataBatchIngestionResponseBodyDataBatchIngestionDataIngestions> DataIngestions { get; set; }
            public class GetDataBatchIngestionResponseBodyDataBatchIngestionDataIngestions : TeaModel {
                /// <summary>
                /// <para>The data ingestion ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas_process_ingestion_173326*******</para>
                /// </summary>
                [NameInMap("DataIngestionId")]
                [Validation(Required=false)]
                public string DataIngestionId { get; set; }

                /// <summary>
                /// <para>The accessed state of the data ingestion. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>enabled: Enabled.</description></item>
                /// <item><description>disabled: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("DataIngestionStatus")]
                [Validation(Required=false)]
                public string DataIngestionStatus { get; set; }

                /// <summary>
                /// <para>The data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas_process_log_173326*******</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                /// <summary>
                /// <para>The product ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>The vendor ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud</para>
                /// </summary>
                [NameInMap("VendorId")]
                [Validation(Required=false)]
                public string VendorId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether automatic discovery of new Logstores is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataSourceRecognizeEnabled")]
            [Validation(Required=false)]
            public bool? DataSourceRecognizeEnabled { get; set; }

            /// <summary>
            /// <para>The list of user IDs for data batch ingestion.</para>
            /// </summary>
            [NameInMap("LogUserIds")]
            [Validation(Required=false)]
            public List<string> LogUserIds { get; set; }

            /// <summary>
            /// <para>The list of recommended ingestion IDs.</para>
            /// </summary>
            [NameInMap("RecommendDataIngestionIds")]
            [Validation(Required=false)]
            public List<string> RecommendDataIngestionIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
