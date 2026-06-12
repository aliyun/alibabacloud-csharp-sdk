// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OSSIngestionConfigurationSource : TeaModel {
        [NameInMap("advancedParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParameters { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ossbucket</para>
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The compression type of the source files.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("compressionCodec")]
        [Validation(Required=false)]
        public string CompressionCodec { get; set; }

        /// <summary>
        /// <para>The encoding of the source files.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF-8</para>
        /// </summary>
        [NameInMap("encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>Imports only files modified before this time. The value is a Unix timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714360481</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The OSS endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>Defines the format of the source data.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public Dictionary<string, object> Format { get; set; }

        /// <summary>
        /// <para>The check interval for new files.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>never</para>
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>A regular expression to filter files by path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The path prefix for filtering files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prefix</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The ID of the writer processor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingest-processor-1756802123-953901</para>
        /// </summary>
        [NameInMap("processorId")]
        [Validation(Required=false)]
        public string ProcessorId { get; set; }

        /// <summary>
        /// <para>Specifies whether to import archived files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("restoreObjectEnabled")]
        [Validation(Required=false)]
        public bool? RestoreObjectEnabled { get; set; }

        /// <summary>
        /// <para>The Role ARN to use for accessing the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::12345:role/aliyunlogdefaultrole</para>
        /// </summary>
        [NameInMap("roleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>Imports only files modified after this time. The value is a Unix timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714274081</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable context retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("tagPackId")]
        [Validation(Required=false)]
        public bool? TagPackId { get; set; }

        /// <summary>
        /// <para>The field containing the log time.</para>
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
        /// <para>The regular expression to extract the time value from a log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0-9]{0,2}\/[0-9a-zA-Z]+\/[0-9:,]+</para>
        /// </summary>
        [NameInMap("timePattern")]
        [Validation(Required=false)]
        public string TimePattern { get; set; }

        /// <summary>
        /// <para>The time zone of the timestamp in the source data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT+08:00</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the OSS metadata index to accelerate file discovery.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useMetaIndex")]
        [Validation(Required=false)]
        public bool? UseMetaIndex { get; set; }

    }

}
