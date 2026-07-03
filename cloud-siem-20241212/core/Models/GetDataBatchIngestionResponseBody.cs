// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetDataBatchIngestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the batch data ingestion task.</para>
        /// </summary>
        [NameInMap("DataBatchIngestion")]
        [Validation(Required=false)]
        public GetDataBatchIngestionResponseBodyDataBatchIngestion DataBatchIngestion { get; set; }
        public class GetDataBatchIngestionResponseBodyDataBatchIngestion : TeaModel {
            /// <summary>
            /// <para>The list of data ingestion IDs for Alibaba Cloud services.</para>
            /// </summary>
            [NameInMap("ApsaraDataIngestionIds")]
            [Validation(Required=false)]
            public List<string> ApsaraDataIngestionIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically discover new users. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: New users are automatically discovered.</para>
            /// </description></item>
            /// <item><description><para>disabled: New users are not automatically discovered.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoScanNew")]
            [Validation(Required=false)]
            public string AutoScanNew { get; set; }

            /// <summary>
            /// <para>The time when the configuration of the batch data ingestion task took effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("DataBatchIngestionEffectTime")]
            [Validation(Required=false)]
            public string DataBatchIngestionEffectTime { get; set; }

            /// <summary>
            /// <para>The mode of the batch data ingestion task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("DataBatchIngestionMode")]
            [Validation(Required=false)]
            public string DataBatchIngestionMode { get; set; }

            /// <summary>
            /// <para>The time when the batch data ingestion task was configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("DataBatchIngestionSetTime")]
            [Validation(Required=false)]
            public string DataBatchIngestionSetTime { get; set; }

            /// <summary>
            /// <para>The status of the batch data ingestion task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>pending: The configuration is pending to take effect.</para>
            /// </description></item>
            /// <item><description><para>running: The configuration is taking effect.</para>
            /// </description></item>
            /// <item><description><para>success: The configuration has taken effect.</para>
            /// </description></item>
            /// <item><description><para>failed: The configuration failed to take effect.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("DataBatchIngestionStatus")]
            [Validation(Required=false)]
            public string DataBatchIngestionStatus { get; set; }

            /// <summary>
            /// <para>The list of data ingestion tasks.</para>
            /// </summary>
            [NameInMap("DataIngestions")]
            [Validation(Required=false)]
            public List<GetDataBatchIngestionResponseBodyDataBatchIngestionDataIngestions> DataIngestions { get; set; }
            public class GetDataBatchIngestionResponseBodyDataBatchIngestionDataIngestions : TeaModel {
                /// <summary>
                /// <para>The ID of the data ingestion task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas_process_ingestion_173326*******</para>
                /// </summary>
                [NameInMap("DataIngestionId")]
                [Validation(Required=false)]
                public string DataIngestionId { get; set; }

                /// <summary>
                /// <para>The status of the data ingestion task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>enabled: enabled</para>
                /// </description></item>
                /// <item><description><para>disabled: disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("DataIngestionStatus")]
                [Validation(Required=false)]
                public string DataIngestionStatus { get; set; }

                /// <summary>
                /// <para>The ID of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas_process_log_173326*******</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                /// <summary>
                /// <para>The ID of the product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>The ID of the vendor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud</para>
                /// </summary>
                [NameInMap("VendorId")]
                [Validation(Required=false)]
                public string VendorId { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically discover new Logstores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataSourceRecognizeEnabled")]
            [Validation(Required=false)]
            public bool? DataSourceRecognizeEnabled { get; set; }

            /// <summary>
            /// <para>The list of user IDs for batch data ingestion.</para>
            /// </summary>
            [NameInMap("LogUserIds")]
            [Validation(Required=false)]
            public List<string> LogUserIds { get; set; }

            /// <summary>
            /// <para>The list of recommended data ingestion IDs.</para>
            /// </summary>
            [NameInMap("RecommendDataIngestionIds")]
            [Validation(Required=false)]
            public List<string> RecommendDataIngestionIds { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
