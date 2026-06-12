// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GCSIngestionConfigurationSource : TeaModel {
        /// <summary>
        /// <para>The access key ID for authenticating with the GCS service. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <para>The secret access key corresponding to the <c>accessKeyId</c>. This value is sensitive and must be managed securely.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// <para>A nested object for specifying advanced configuration options as key-value pairs.</para>
        /// </summary>
        [NameInMap("advancedParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParameters { get; set; }

        /// <summary>
        /// <para>The name of the GCS bucket that contains the source data files.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gcsbucket</para>
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The compression format of the source files. Supported values are <c>none</c>, <c>gzip</c>, and <c>zstd</c>. If not specified, the system infers the format from the file extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("compressionCodec")]
        [Validation(Required=false)]
        public string CompressionCodec { get; set; }

        /// <summary>
        /// <para>The character encoding of the source files. The default value is <c>UTF-8</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF-8</para>
        /// </summary>
        [NameInMap("encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>The end of the time range for data ingestion, specified as a Unix timestamp (in seconds). Only objects modified before this time are ingested.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714360481</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The service endpoint for GCS. You can use a custom endpoint for private or accelerated connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>A nested object that defines the format of the source data, such as CSV, JSON, or Parquet.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public Dictionary<string, object> Format { get; set; }

        /// <summary>
        /// <para>The interval for checking for new data. Specify the value in a duration format, such as <c>15m</c> for 15 minutes. Set to <c>never</c> to perform a one-time ingestion.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>never</para>
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>A regular expression that specifies which files to ingest. The pattern is matched against the full object key within the specified prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The object key prefix used to discover files. This limits the scope of ingestion to a specific &quot;folder&quot; within the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prefix</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The unique ID of the processor or pipeline that handles the ingested data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingest-processor-1756802123-953901</para>
        /// </summary>
        [NameInMap("processorId")]
        [Validation(Required=false)]
        public string ProcessorId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically restore objects from archival storage classes before ingestion. Set to <c>true</c> to enable this feature. The default is <c>false</c>.</para>
        /// </summary>
        [NameInMap("restoreObjectEnabled")]
        [Validation(Required=false)]
        public bool? RestoreObjectEnabled { get; set; }

        /// <summary>
        /// <para>The start of the time range for data ingestion, specified as a Unix timestamp (in seconds). Only objects modified at or after this time are ingested.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714274081</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The ID of a predefined tag pack to apply to the ingested data. Tag packs contain rules for data enrichment and categorization.</para>
        /// </summary>
        [NameInMap("tagPackId")]
        [Validation(Required=false)]
        public bool? TagPackId { get; set; }

        /// <summary>
        /// <para>The name of the field in your data that contains the timestamp. This timestamp is used as the event time for the ingested records.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b>time</b></para>
        /// </summary>
        [NameInMap("timeField")]
        [Validation(Required=false)]
        public string TimeField { get; set; }

        /// <summary>
        /// <para>The format of the timestamp in the <c>timeField</c>, specified using the Java <c>SimpleDateFormat</c> pattern. For example: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss.SSSZ</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("timeFormat")]
        [Validation(Required=false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// <para>A regular expression used to extract a timestamp from unstructured data, such as a log entry or filename, if a structured <c>timeField</c> is not available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0-9]{0,2}\/[0-9a-zA-Z]+\/[0-9:,]+</para>
        /// </summary>
        [NameInMap("timePattern")]
        [Validation(Required=false)]
        public string TimePattern { get; set; }

        /// <summary>
        /// <para>The time zone for parsing timestamps that lack explicit time zone information. Specify a valid time zone identifier, such as <c>UTC</c> or <c>America/Los_Angeles</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT+08:00</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
