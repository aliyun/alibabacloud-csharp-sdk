// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AzureBlobIngestionConfigurationSource : TeaModel {
        /// <summary>
        /// <para>The access key for the Azure Blob Storage account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdGtleQ==</para>
        /// </summary>
        [NameInMap("accountKey")]
        [Validation(Required=false)]
        public string AccountKey { get; set; }

        /// <summary>
        /// <para>The name of the Azure Blob Storage account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test001</para>
        /// </summary>
        [NameInMap("accountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Advanced configuration options.</para>
        /// </summary>
        [NameInMap("advancedParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParameters { get; set; }

        /// <summary>
        /// <para>The compression codec for the source data. Valid values are <c>none</c>, <c>snappy</c>, and <c>gzip</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("compressionCodec")]
        [Validation(Required=false)]
        public string CompressionCodec { get; set; }

        /// <summary>
        /// <para>The name of the container in Azure Blob Storage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-container</para>
        /// </summary>
        [NameInMap("containerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The character encoding of the source files.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF-8</para>
        /// </summary>
        [NameInMap("encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>Ingests only files modified before this time, specified as a Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714360481</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The service endpoint for Azure Blob Storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://your-storage.blob.core.windows.net">https://your-storage.blob.core.windows.net</a></para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The format of the source data.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public Dictionary<string, object> Format { get; set; }

        /// <summary>
        /// <para>The interval at which to check for new files to ingest.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30m</para>
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>A pattern used to filter files by path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The file path prefix used to filter files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prefix</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The ID of the processor that receives the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingest-processor-1756802123-953901</para>
        /// </summary>
        [NameInMap("processorId")]
        [Validation(Required=false)]
        public string ProcessorId { get; set; }

        /// <summary>
        /// <para>Ingests only files modified after this time, specified as a Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714274081</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable context query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("tagPackId")]
        [Validation(Required=false)]
        public bool? TagPackId { get; set; }

        /// <summary>
        /// <para>The source field for the time value.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b>time</b></para>
        /// </summary>
        [NameInMap("timeField")]
        [Validation(Required=false)]
        public string TimeField { get; set; }

        /// <summary>
        /// <para>The format of the time field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("timeFormat")]
        [Validation(Required=false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// <para>The pattern used to extract the time value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0-9]{0,2}\/[0-9a-zA-Z]+\/[0-9:,]+</para>
        /// </summary>
        [NameInMap("timePattern")]
        [Validation(Required=false)]
        public string TimePattern { get; set; }

        /// <summary>
        /// <para>The time zone of the time field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT+08:00</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
