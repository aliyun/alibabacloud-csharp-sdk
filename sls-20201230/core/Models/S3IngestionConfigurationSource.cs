// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class S3IngestionConfigurationSource : TeaModel {
        [NameInMap("advancedParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParameters { get; set; }

        /// <summary>
        /// <para>Amazon Web Services (AWS) access key ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AKIxxxxxxxxxxYJE</para>
        /// </summary>
        [NameInMap("awsAccessKey")]
        [Validation(Required=false)]
        public string AwsAccessKey { get; set; }

        /// <summary>
        /// <para>Amazon Web Services (AWS) secret access key</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxxxxxxfjf</para>
        /// </summary>
        [NameInMap("awsAccessKeySecret")]
        [Validation(Required=false)]
        public string AwsAccessKeySecret { get; set; }

        /// <summary>
        /// <para>Amazon S3 region</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-northeast-1</para>
        /// </summary>
        [NameInMap("awsRegion")]
        [Validation(Required=false)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// <para>Amazon SQS queue URL</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://sqs.ap-northeast-1.amazonaws.com/123456788/chifan">https://sqs.ap-northeast-1.amazonaws.com/123456788/chifan</a></para>
        /// </summary>
        [NameInMap("awsSQSQueueUrl")]
        [Validation(Required=false)]
        public string AwsSQSQueueUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to use SQS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("awsUseSQS")]
        [Validation(Required=false)]
        public bool? AwsUseSQS { get; set; }

        /// <summary>
        /// <para>Amazon S3 bucket name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s3bucket</para>
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The endpoint for the CloudFront distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtfsb7voqy76q.cloudfront.net</para>
        /// </summary>
        [NameInMap("cloudFrontEndpoint")]
        [Validation(Required=false)]
        public string CloudFrontEndpoint { get; set; }

        /// <summary>
        /// <para>The authentication token for accessing the CloudFront endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@test-s3-access/ABS</para>
        /// </summary>
        [NameInMap("cloudFrontToken")]
        [Validation(Required=false)]
        public string CloudFrontToken { get; set; }

        /// <summary>
        /// <para>Compression codec. Valid values: none, snappy, gzip</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("compressionCodec")]
        [Validation(Required=false)]
        public string CompressionCodec { get; set; }

        /// <summary>
        /// <para>Character encoding</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF-8</para>
        /// </summary>
        [NameInMap("encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>Include only files modified before this Unix timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714360481</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Amazon S3 endpoint</para>
        /// 
        /// <b>Example:</b>
        /// <para>s3.us-east-1.amazonaws.com</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>Format</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public Dictionary<string, object> Format { get; set; }

        /// <summary>
        /// <para>Polling interval for new files</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30m</para>
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>Regular expression to filter file paths</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>Prefix to filter file paths</para>
        /// 
        /// <b>Example:</b>
        /// <para>prefix</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>Ingest processor ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingest-processor-1756802123-953901</para>
        /// </summary>
        [NameInMap("processorId")]
        [Validation(Required=false)]
        public string ProcessorId { get; set; }

        /// <summary>
        /// <para>Include only files modified after this Unix timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714274081</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Enable context browsing</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("tagPackId")]
        [Validation(Required=false)]
        public bool? TagPackId { get; set; }

        /// <summary>
        /// <para>Name of the field that contains event timestamps</para>
        /// 
        /// <b>Example:</b>
        /// <para><b>time</b></para>
        /// </summary>
        [NameInMap("timeField")]
        [Validation(Required=false)]
        public string TimeField { get; set; }

        /// <summary>
        /// <para>Timestamp format in the time field</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("timeFormat")]
        [Validation(Required=false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// <para>Regular expression to extract timestamps from file names or content</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0-9]{0,2}\/[0-9a-zA-Z]+\/[0-9:,]+</para>
        /// </summary>
        [NameInMap("timePattern")]
        [Validation(Required=false)]
        public string TimePattern { get; set; }

        /// <summary>
        /// <para>Time zone for the time field</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT+08:00</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>Use only Amazon SQS to detect new files</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useAwsSQSOnly")]
        [Validation(Required=false)]
        public bool? UseAwsSQSOnly { get; set; }

        /// <summary>
        /// <para>Specifies whether to access S3 through a CloudFront distribution.</para>
        /// </summary>
        [NameInMap("useCloudFront")]
        [Validation(Required=false)]
        public bool? UseCloudFront { get; set; }

    }

}
