// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OSSExportConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1714123644</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>logstore-demo</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunlogdefaultrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("sink")]
        [Validation(Required=false)]
        public OSSExportConfigurationSink Sink { get; set; }
        public class OSSExportConfigurationSink : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-bucket</para>
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("bufferInterval")]
            [Validation(Required=false)]
            public long? BufferInterval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>256</para>
            /// </summary>
            [NameInMap("bufferSize")]
            [Validation(Required=false)]
            public long? BufferSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>snappy</para>
            /// </summary>
            [NameInMap("compressionType")]
            [Validation(Required=false)]
            public string CompressionType { get; set; }

            [NameInMap("contentDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>json</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("delaySec")]
            [Validation(Required=false)]
            [Obsolete]
            public long? DelaySec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("delaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://oss-cn-hangzhou-internal.aliyuncs.com">http://oss-cn-hangzhou-internal.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%Y/%m/%d/%H/%M</para>
            /// </summary>
            [NameInMap("pathFormat")]
            [Validation(Required=false)]
            public string PathFormat { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>time</para>
            /// </summary>
            [NameInMap("pathFormatType")]
            [Validation(Required=false)]
            public string PathFormatType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo/</para>
            /// </summary>
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789:role/aliyunlogdefaultrole</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>.json</para>
            /// </summary>
            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>+0800</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1714357112</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
