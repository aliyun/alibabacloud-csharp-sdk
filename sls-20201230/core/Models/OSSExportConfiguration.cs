// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OSSExportConfiguration : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to ship data. The value 1 specifies that the data shipping job ships data from the first log in the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logstore-demo</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role that is used to read data from Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunlogdefaultrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The configurations of the OSS data shipping job.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public OSSExportConfigurationSink Sink { get; set; }
        public class OSSExportConfigurationSink : TeaModel {
            /// <summary>
            /// <para>The OSS bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-bucket</para>
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The interval between two data shipping operations. Valid values: 300 to 900. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("bufferInterval")]
            [Validation(Required=false)]
            public long? BufferInterval { get; set; }

            /// <summary>
            /// <para>The size of the OSS object to which data is shipped. Valid values: 5 to 256. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>256</para>
            /// </summary>
            [NameInMap("bufferSize")]
            [Validation(Required=false)]
            public long? BufferSize { get; set; }

            /// <summary>
            /// <para>The compression type. Valid values: snappy, gizp, zstd, and none.</para>
            /// 
            /// <b>Example:</b>
            /// <para>snappy/gizp/zstd/none</para>
            /// </summary>
            [NameInMap("compressionType")]
            [Validation(Required=false)]
            public string CompressionType { get; set; }

            /// <summary>
            /// <para>The details of the OSS object. Note: The value of this parameter is in the JSON format and varies based on the value of contentType.</para>
            /// </summary>
            [NameInMap("contentDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentDetail { get; set; }

            /// <summary>
            /// <para>The storage format of the OSS object. Valid values: json, parquet, csv, and orc.</para>
            /// 
            /// <b>Example:</b>
            /// <para>json/parquet/csv/orc</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The latency of data shipping.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is deprecated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("delaySec")]
            [Validation(Required=false)]
            [Obsolete]
            public long? DelaySec { get; set; }

            /// <summary>
            /// <para>The latency of data shipping. The value of this parameter cannot exceed the data retention period of the source Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("delaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>The endpoint that is used to access OSS. You can specify only an internal OSS endpoint for the region where the Simple Log Service project resides. The value is in the <c>http://+OSS endpoint</c> format. For more information, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</description></item>
            /// <item><description>The endpoint that is used to access OSS-HDFS. You can specify only an internal OSS-HDFS endpoint for the region where the Simple Log Service project resides.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxxxxxx">http://xxxxxxxx</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The partition format. For more information, see <a href="https://help.aliyun.com/document_detail/371934.html">Partition formats</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%Y_%m_%d/good/bad</para>
            /// </summary>
            [NameInMap("pathFormat")]
            [Validation(Required=false)]
            public string PathFormat { get; set; }

            /// <summary>
            /// <para>The partition format type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>only support time</para>
            /// </summary>
            [NameInMap("pathFormatType")]
            [Validation(Required=false)]
            public string PathFormatType { get; set; }

            /// <summary>
            /// <para>The prefix of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prefixxxx/</para>
            /// </summary>
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role that is used to write data to OSS.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::xxxxxxx</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The suffix of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.json</para>
            /// </summary>
            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            /// <summary>
            /// <para>The time zone. For more information, see <a href="https://help.aliyun.com/document_detail/375323.html">Time zones</a>.</para>
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
        /// <para>The end of the time range to ship data. The value 0 specifies that the data shipping job continuously ships data until the job is manually stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
