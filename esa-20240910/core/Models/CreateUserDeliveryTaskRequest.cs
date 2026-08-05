// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateUserDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <para>The real-time log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dcdn_log_er_pod</b>: edge container logs.</description></item>
        /// <item><description><b>dcdn_log_dns</b>: edge DNS logs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_er_pod</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The data center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn</b>: the Chinese mainland.</description></item>
        /// <item><description><b>sg</b>: global (excluding the Chinese mainland).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The delivery type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sls</b>: Alibaba Cloud Simple Log Service.</description></item>
        /// <item><description><b>http</b>: HTTP service.</description></item>
        /// <item><description><b>aws3</b>: Amazon S3 service.</description></item>
        /// <item><description><b>oss</b>: Alibaba Cloud Object Storage Service.</description></item>
        /// <item><description><b>kafka</b>: Kafka service.</description></item>
        /// <item><description><b>aws3cmpt</b>: Amazon S3-compatible service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// <para>The list of Edge Routine (ER) pods to configure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx,xxx</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public string Details { get; set; }

        /// <summary>
        /// <para>The discard rate. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>The fields to deliver, separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClientIP,ClientRequestURI,EdgeResponseStatusCode</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The version of the filter rule.</para>
        /// <remarks>
        /// <para>This parameter is used for backward compatibility with legacy filter rules. The default value is v1. New tasks use v2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("FilterVer")]
        [Validation(Required=false)]
        public string FilterVer { get; set; }

        /// <summary>
        /// <para>The HTTP delivery configuration parameters.</para>
        /// </summary>
        [NameInMap("HttpDelivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestHttpDelivery HttpDelivery { get; set; }
        public class CreateUserDeliveryTaskRequestHttpDelivery : TeaModel {
            /// <summary>
            /// <para>The compression method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gzip</para>
            /// </summary>
            [NameInMap("Compress")]
            [Validation(Required=false)]
            public string Compress { get; set; }

            /// <summary>
            /// <para>The HTTP server delivery address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.aliyun.com/v1/log/upload">http://xxx.aliyun.com/v1/log/upload</a></para>
            /// </summary>
            [NameInMap("DestUrl")]
            [Validation(Required=false)]
            public string DestUrl { get; set; }

            /// <summary>
            /// <para>The Custom Header.</para>
            /// </summary>
            [NameInMap("HeaderParam")]
            [Validation(Required=false)]
            public Dictionary<string, HttpDeliveryHeaderParamValue> HeaderParam { get; set; }

            /// <summary>
            /// <para>The trailing separator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\n</para>
            /// </summary>
            [NameInMap("LastLogSplit")]
            [Validation(Required=false)]
            public bool? LastLogSplit { get; set; }

            /// <summary>
            /// <para>The prefix of the log delivery package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdnVersion:1.0</para>
            /// </summary>
            [NameInMap("LogBodyPrefix")]
            [Validation(Required=false)]
            public string LogBodyPrefix { get; set; }

            /// <summary>
            /// <para>The suffix of the log delivery package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdnVersion:1.0</para>
            /// </summary>
            [NameInMap("LogBodySuffix")]
            [Validation(Required=false)]
            public string LogBodySuffix { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable log segmentation. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LogSplit")]
            [Validation(Required=false)]
            public bool? LogSplit { get; set; }

            /// <summary>
            /// <para>The log separator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\n</para>
            /// </summary>
            [NameInMap("LogSplitWords")]
            [Validation(Required=false)]
            public string LogSplitWords { get; set; }

            /// <summary>
            /// <para>The maximum size of a single delivery batch. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxBatchMB")]
            [Validation(Required=false)]
            public long? MaxBatchMB { get; set; }

            /// <summary>
            /// <para>The maximum number of log entries per delivery batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxBatchSize")]
            [Validation(Required=false)]
            public long? MaxBatchSize { get; set; }

            /// <summary>
            /// <para>The maximum number of retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxRetry")]
            [Validation(Required=false)]
            public long? MaxRetry { get; set; }

            /// <summary>
            /// <para>The custom request parameters.</para>
            /// </summary>
            [NameInMap("QueryParam")]
            [Validation(Required=false)]
            public Dictionary<string, HttpDeliveryQueryParamValue> QueryParam { get; set; }

            /// <summary>
            /// <para>Specifies whether to use standard authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StandardAuthOn")]
            [Validation(Required=false)]
            public bool? StandardAuthOn { get; set; }

            /// <summary>
            /// <para>The standard authentication parameters.</para>
            /// </summary>
            [NameInMap("StandardAuthParam")]
            [Validation(Required=false)]
            public CreateUserDeliveryTaskRequestHttpDeliveryStandardAuthParam StandardAuthParam { get; set; }
            public class CreateUserDeliveryTaskRequestHttpDeliveryStandardAuthParam : TeaModel {
                /// <summary>
                /// <para>The encryption timeout period.</para>
                /// <remarks>
                /// <para>The value must be greater than 0. A value of 300 or greater is recommended. Unit: seconds.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public int? ExpiredTime { get; set; }

                /// <summary>
                /// <para>The private key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("PrivateKey")]
                [Validation(Required=false)]
                public string PrivateKey { get; set; }

                /// <summary>
                /// <para>The URL path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1/log/upload</para>
                /// </summary>
                [NameInMap("UrlPath")]
                [Validation(Required=false)]
                public string UrlPath { get; set; }

            }

            /// <summary>
            /// <para>The timeout period. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TransformTimeout")]
            [Validation(Required=false)]
            public long? TransformTimeout { get; set; }

        }

        /// <summary>
        /// <para>The Kafka delivery configuration parameters.</para>
        /// </summary>
        [NameInMap("KafkaDelivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestKafkaDelivery KafkaDelivery { get; set; }
        public class CreateUserDeliveryTaskRequestKafkaDelivery : TeaModel {
            /// <summary>
            /// <para>The load balancing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka.LeastBytes</para>
            /// </summary>
            [NameInMap("Balancer")]
            [Validation(Required=false)]
            public string Balancer { get; set; }

            /// <summary>
            /// <para>The server array.</para>
            /// </summary>
            [NameInMap("Brokers")]
            [Validation(Required=false)]
            public List<string> Brokers { get; set; }

            /// <summary>
            /// <para>The compression method. By default, no compression is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lz4</para>
            /// </summary>
            [NameInMap("Compress")]
            [Validation(Required=false)]
            public string Compress { get; set; }

            /// <summary>
            /// <para>The encryption method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plain</para>
            /// </summary>
            [NameInMap("MachanismType")]
            [Validation(Required=false)]
            public string MachanismType { get; set; }

            /// <summary>
            /// <para>The encryption password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The Kafka message topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dqc_test2</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable SASL-encrypted transmission for Kafka delivery.</para>
            /// <remarks>
            /// <para>The delivery address must be configured with a public certificate. Verification with a self-signed certificate will fail.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseTLS")]
            [Validation(Required=false)]
            public bool? UseTLS { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable user authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UserAuth")]
            [Validation(Required=false)]
            public bool? UserAuth { get; set; }

            /// <summary>
            /// <para>The encryption username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The OSS delivery configuration parameters.</para>
        /// </summary>
        [NameInMap("OssDelivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestOssDelivery OssDelivery { get; set; }
        public class CreateUserDeliveryTaskRequestOssDelivery : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234***</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_rlog</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The OSS storage path prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test/</para>
            /// </summary>
            [NameInMap("PrefixPath")]
            [Validation(Required=false)]
            public string PrefixPath { get; set; }

            /// <summary>
            /// <para>The OSS region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The S3 or S3-compatible delivery configuration parameters.</para>
        /// </summary>
        [NameInMap("S3Delivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestS3Delivery S3Delivery { get; set; }
        public class CreateUserDeliveryTaskRequestS3Delivery : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the S3 account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g0f46623ll0g0</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The bucket storage path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logriver-test/log</para>
            /// </summary>
            [NameInMap("BucketPath")]
            [Validation(Required=false)]
            public string BucketPath { get; set; }

            /// <summary>
            /// <para>The S3 endpoint address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://s3.oss-cn-hangzhou.aliyuncs.com">https://s3.oss-cn-hangzhou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The storage path prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logriver-test/log</para>
            /// </summary>
            [NameInMap("PrefixPath")]
            [Validation(Required=false)]
            public string PrefixPath { get; set; }

            /// <summary>
            /// <para>The region where the service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Specifies whether the storage is S3-compatible.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("S3Cmpt")]
            [Validation(Required=false)]
            public bool? S3Cmpt { get; set; }

            /// <summary>
            /// <para>The SecretKey of the S3 account.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable S3 server-side encryption.</para>
            /// <para>To configure server-side encryption for the S3 bucket, refer to OSS <a href="https://help.aliyun.com/document_detail/31871.html">Server-side encryption</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ServerSideEncryption")]
            [Validation(Required=false)]
            public bool? ServerSideEncryption { get; set; }

            /// <summary>
            /// <para>The key verification method for S3 delivery.</para>
            /// <remarks>
            /// <para>The key configuration comes from the console or SDK. Keys from the console are encrypted during transmission. Keys from the SDK do not require encryption.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>console</para>
            /// </summary>
            [NameInMap("VertifyType")]
            [Validation(Required=false)]
            public string VertifyType { get; set; }

        }

        /// <summary>
        /// <para>The SLS delivery configuration.</para>
        /// </summary>
        [NameInMap("SlsDelivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestSlsDelivery SlsDelivery { get; set; }
        public class CreateUserDeliveryTaskRequestSlsDelivery : TeaModel {
            /// <summary>
            /// <para>The Simple Log Service (SLS) Logstore name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accesslog-test</para>
            /// </summary>
            [NameInMap("SLSLogStore")]
            [Validation(Required=false)]
            public string SLSLogStore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service (SLS) project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dcdn-test20240417</para>
            /// </summary>
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            /// <summary>
            /// <para>The region where Simple Log Service (SLS) resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SLSRegion")]
            [Validation(Required=false)]
            public string SLSRegion { get; set; }

        }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
