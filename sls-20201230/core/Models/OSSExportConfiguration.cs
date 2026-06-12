// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OSSExportConfiguration : TeaModel {
        /// <summary>
        /// <para>The start time for the export, specified as a Unix timestamp. Set to 1 to export from the earliest available data in the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718380800</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The name of the source Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The ARN of the Resource Access Management (RAM) role that Log Service assumes to read data from the Logstore. You must specify the ARN of your role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890:role/aliyunlogdefaultrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The configuration of the destination OSS sink.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public OSSExportConfigurationSink Sink { get; set; }
        public class OSSExportConfigurationSink : TeaModel {
            /// <summary>
            /// <para>The name of the destination OSS bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-bucket</para>
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The time in seconds to buffer data before exporting. The value must be an integer from 300 to 900.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("bufferInterval")]
            [Validation(Required=false)]
            public long? BufferInterval { get; set; }

            /// <summary>
            /// <para>The amount of data in MB to buffer before exporting. The value must be an integer from 5 to 256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>256</para>
            /// </summary>
            [NameInMap("bufferSize")]
            [Validation(Required=false)]
            public long? BufferSize { get; set; }

            /// <summary>
            /// <para>The compression type for the exported files. Valid values: <c>snappy</c>, <c>gzip</c>, <c>zstd</c>, and <c>none</c> (no compression).</para>
            /// 
            /// <b>Example:</b>
            /// <para>snappy</para>
            /// </summary>
            [NameInMap("compressionType")]
            [Validation(Required=false)]
            public string CompressionType { get; set; }

            /// <summary>
            /// <para>Format-specific settings. The structure of this JSON object depends on the <c>contentType</c> value.</para>
            /// </summary>
            [NameInMap("contentDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentDetail { get; set; }

            /// <summary>
            /// <para>The format of the files stored in OSS. Valid values: <c>json</c>, <c>parquet</c>, <c>csv</c>, and <c>orc</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>csv</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The delivery delay.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is deprecated.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("delaySec")]
            [Validation(Required=false)]
            [Obsolete]
            public long? DelaySec { get; set; }

            /// <summary>
            /// <para>The delivery delay, in seconds. This value cannot exceed the data retention period of the source Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("delaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>For Object Storage Service (OSS): The OSS internal endpoint. You must use an endpoint in the same region as the Logstore. For more information, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS access domains and data centers</a>. The endpoint must use the HTTPS protocol.</para>
            /// </description></item>
            /// <item><description><para>For OSS-HDFS: The OSS-HDFS internal endpoint. You must use an endpoint in the same region as the Logstore.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss-cn-hangzhou-internal.aliyuncs.com">https://oss-cn-hangzhou-internal.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The path format for exported files. For more information, see <a href="https://help.aliyun.com/document_detail/371934.html">Path format</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%Y/%m/%d/%H/%M</para>
            /// </summary>
            [NameInMap("pathFormat")]
            [Validation(Required=false)]
            public string PathFormat { get; set; }

            /// <summary>
            /// <para>The type of the path format.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>time</para>
            /// </summary>
            [NameInMap("pathFormatType")]
            [Validation(Required=false)]
            public string PathFormatType { get; set; }

            /// <summary>
            /// <para>The prefix for files exported to the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prefix-demo/</para>
            /// </summary>
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role that Log Service assumes to write data to the OSS bucket. You must specify the ARN of your role.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890:role/aliyunlogdefaultrole</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The suffix for the exported files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.json</para>
            /// </summary>
            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            /// <summary>
            /// <para>The time zone used for the path format. For more information, see <a href="https://help.aliyun.com/document_detail/375323.html">Time zones</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>+0800</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("sourceSecureTransport")]
        [Validation(Required=false)]
        public bool? SourceSecureTransport { get; set; }

        /// <summary>
        /// <para>The end time for the export, specified as a Unix timestamp. Set to 0 to run the task continuously until it is stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718380800</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
