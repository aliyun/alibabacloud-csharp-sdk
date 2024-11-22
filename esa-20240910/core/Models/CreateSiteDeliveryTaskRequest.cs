// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <para>The log category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dcdn_log_access_l1</b> (default): access logs.</description></item>
        /// <item><description><b>dcdn_log_er</b>: Edge Routine logs.</description></item>
        /// <item><description><b>dcdn_log_waf</b>: firewall logs.</description></item>
        /// <item><description><b>dcdn_log_ipa</b>: TCP/UDP proxy logs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The data center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn: the Chinese mainland.</description></item>
        /// <item><description>oversea: outside the Chinese mainland.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The destination of the delivery. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sls: Alibaba Cloud Simple Log Service (SLS).</description></item>
        /// <item><description>http: HTTP server.</description></item>
        /// <item><description>aws3: Amazon Simple Storage Service (S3).</description></item>
        /// <item><description>oss: Alibaba Cloud Object Storage Service (OSS).</description></item>
        /// <item><description>kafka: Kafka.</description></item>
        /// <item><description>aws3cmpt: S3-compatible storage service.</description></item>
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
        /// <para>The discard rate. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>The log fields, which are separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_agent,ip_adress,ip_port</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The configurations for delivery to an HTTP server.</para>
        /// </summary>
        [NameInMap("HttpDelivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestHttpDelivery HttpDelivery { get; set; }
        public class CreateSiteDeliveryTaskRequestHttpDelivery : TeaModel {
            /// <summary>
            /// <para>The compression method. By default, data is not compressed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gzip</para>
            /// </summary>
            [NameInMap("Compress")]
            [Validation(Required=false)]
            public string Compress { get; set; }

            /// <summary>
            /// <para>The address of the HTTP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.aliyun.com/v1/log/upload">http://xxx.aliyun.com/v1/log/upload</a></para>
            /// </summary>
            [NameInMap("DestUrl")]
            [Validation(Required=false)]
            public string DestUrl { get; set; }

            /// <summary>
            /// <para>The custom headers.</para>
            /// </summary>
            [NameInMap("HeaderParam")]
            [Validation(Required=false)]
            public Dictionary<string, HttpDeliveryHeaderParamValue> HeaderParam { get; set; }

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
            /// <para>The maximum size of data for each delivery. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxBatchMB")]
            [Validation(Required=false)]
            public long? MaxBatchMB { get; set; }

            /// <summary>
            /// <para>The maximum number of entries for each delivery.</para>
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
            /// <para>The custom query parameters.</para>
            /// </summary>
            [NameInMap("QueryParam")]
            [Validation(Required=false)]
            public Dictionary<string, HttpDeliveryQueryParamValue> QueryParam { get; set; }

            /// <summary>
            /// <para>Specifies whether to use server authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StandardAuthOn")]
            [Validation(Required=false)]
            public bool? StandardAuthOn { get; set; }

            /// <summary>
            /// <para>The authentication configurations.</para>
            /// </summary>
            [NameInMap("StandardAuthParam")]
            [Validation(Required=false)]
            public CreateSiteDeliveryTaskRequestHttpDeliveryStandardAuthParam StandardAuthParam { get; set; }
            public class CreateSiteDeliveryTaskRequestHttpDeliveryStandardAuthParam : TeaModel {
                /// <summary>
                /// <para>The validity period of the signature.</para>
                /// <remarks>
                /// <para> The value must be greater than 0. We recommend that you specify a value that is greater than 300.</para>
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
                /// <hr>
                /// </summary>
                [NameInMap("PrivateKey")]
                [Validation(Required=false)]
                public string PrivateKey { get; set; }

                /// <summary>
                /// <para>The URI path for server authentication.</para>
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
        /// <para>The configurations for delivery to Kafka.</para>
        /// </summary>
        [NameInMap("KafkaDelivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestKafkaDelivery KafkaDelivery { get; set; }
        public class CreateSiteDeliveryTaskRequestKafkaDelivery : TeaModel {
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
            /// <para>The brokers.</para>
            /// </summary>
            [NameInMap("Brokers")]
            [Validation(Required=false)]
            public List<string> Brokers { get; set; }

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
            /// <para>The encryption method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plain</para>
            /// </summary>
            [NameInMap("MachanismType")]
            [Validation(Required=false)]
            public string MachanismType { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dqc_test2</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UserAuth")]
            [Validation(Required=false)]
            public bool? UserAuth { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The configurations for delivery to OSS.</para>
        /// </summary>
        [NameInMap("OssDelivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestOssDelivery OssDelivery { get; set; }
        public class CreateSiteDeliveryTaskRequestOssDelivery : TeaModel {
            /// <summary>
            /// <para>The ID of your Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234***</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_rlog</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The prefix of the path in which you want to store logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logriver-test/log</para>
            /// </summary>
            [NameInMap("PrefixPath")]
            [Validation(Required=false)]
            public string PrefixPath { get; set; }

            /// <summary>
            /// <para>The region in which the bucket is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The configurations for delivery to Amazon S3 or an S3-compatible service.</para>
        /// </summary>
        [NameInMap("S3Delivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestS3Delivery S3Delivery { get; set; }
        public class CreateSiteDeliveryTaskRequestS3Delivery : TeaModel {
            /// <summary>
            /// <para>The access key ID of your Amazon S3 account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAIKh***</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The directory in the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logriver-test/log</para>
            /// </summary>
            [NameInMap("BucketPath")]
            [Validation(Required=false)]
            public string BucketPath { get; set; }

            /// <summary>
            /// <para>The endpoint. This parameter is required when the S3Cmpt parameter is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://s3.oss-cn-hangzhou.aliyuncs.com">https://s3.oss-cn-hangzhou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The prefix of the path in which you want to store logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logriver-test/log</para>
            /// </summary>
            [NameInMap("PrefixPath")]
            [Validation(Required=false)]
            public string PrefixPath { get; set; }

            /// <summary>
            /// <para>The region ID of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Specifies whether the service is compatible with Amazon S3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("S3Cmpt")]
            [Validation(Required=false)]
            public bool? S3Cmpt { get; set; }

            /// <summary>
            /// <para>The secret access key of your Amazon S3 account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LDSIKh***</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            [NameInMap("ServerSideEncryption")]
            [Validation(Required=false)]
            public bool? ServerSideEncryption { get; set; }

            [NameInMap("VertifyType")]
            [Validation(Required=false)]
            public string VertifyType { get; set; }

        }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312312112***</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The configurations for delivery to SLS.</para>
        /// </summary>
        [NameInMap("SlsDelivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestSlsDelivery SlsDelivery { get; set; }
        public class CreateSiteDeliveryTaskRequestSlsDelivery : TeaModel {
            /// <summary>
            /// <para>The name of the Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accesslog-test</para>
            /// </summary>
            [NameInMap("SLSLogStore")]
            [Validation(Required=false)]
            public string SLSLogStore { get; set; }

            /// <summary>
            /// <para>The name of the SLS project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dcdn-test20240417</para>
            /// </summary>
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            /// <summary>
            /// <para>The region in which the SLS project resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SLSRegion")]
            [Validation(Required=false)]
            public string SLSRegion { get; set; }

        }

        /// <summary>
        /// <para>The name of the delivery task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn-test-task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
