// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateUserDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_agent,ip_address,ip_port</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        [NameInMap("HttpDelivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestHttpDelivery HttpDelivery { get; set; }
        public class CreateUserDeliveryTaskRequestHttpDelivery : TeaModel {
            [NameInMap("Compress")]
            [Validation(Required=false)]
            public string Compress { get; set; }

            [NameInMap("DestUrl")]
            [Validation(Required=false)]
            public string DestUrl { get; set; }

            [NameInMap("HeaderParam")]
            [Validation(Required=false)]
            public Dictionary<string, HttpDeliveryHeaderParamValue> HeaderParam { get; set; }

            [NameInMap("LastLogSplit")]
            [Validation(Required=false)]
            public string LastLogSplit { get; set; }

            [NameInMap("LogBodyPrefix")]
            [Validation(Required=false)]
            public string LogBodyPrefix { get; set; }

            [NameInMap("LogBodySuffix")]
            [Validation(Required=false)]
            public string LogBodySuffix { get; set; }

            [NameInMap("LogSplit")]
            [Validation(Required=false)]
            public string LogSplit { get; set; }

            [NameInMap("LogSplitWords")]
            [Validation(Required=false)]
            public string LogSplitWords { get; set; }

            [NameInMap("MaxBackoffMS")]
            [Validation(Required=false)]
            public long? MaxBackoffMS { get; set; }

            [NameInMap("MaxBatchMB")]
            [Validation(Required=false)]
            public long? MaxBatchMB { get; set; }

            [NameInMap("MaxBatchSize")]
            [Validation(Required=false)]
            public long? MaxBatchSize { get; set; }

            [NameInMap("MaxRetry")]
            [Validation(Required=false)]
            public long? MaxRetry { get; set; }

            [NameInMap("MinBackoffMS")]
            [Validation(Required=false)]
            public long? MinBackoffMS { get; set; }

            [NameInMap("QueryParam")]
            [Validation(Required=false)]
            public Dictionary<string, HttpDeliveryQueryParamValue> QueryParam { get; set; }

            [NameInMap("ResponseBodyKey")]
            [Validation(Required=false)]
            public string ResponseBodyKey { get; set; }

            [NameInMap("StandardAuthOn")]
            [Validation(Required=false)]
            public bool? StandardAuthOn { get; set; }

            [NameInMap("StandardAuthParam")]
            [Validation(Required=false)]
            public CreateUserDeliveryTaskRequestHttpDeliveryStandardAuthParam StandardAuthParam { get; set; }
            public class CreateUserDeliveryTaskRequestHttpDeliveryStandardAuthParam : TeaModel {
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public int? ExpiredTime { get; set; }

                [NameInMap("PrivateKey")]
                [Validation(Required=false)]
                public string PrivateKey { get; set; }

                [NameInMap("UrlPath")]
                [Validation(Required=false)]
                public string UrlPath { get; set; }

            }

            [NameInMap("SuccessCode")]
            [Validation(Required=false)]
            public long? SuccessCode { get; set; }

            [NameInMap("TransformTimeout")]
            [Validation(Required=false)]
            public long? TransformTimeout { get; set; }

        }

        [NameInMap("KafkaDelivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestKafkaDelivery KafkaDelivery { get; set; }
        public class CreateUserDeliveryTaskRequestKafkaDelivery : TeaModel {
            [NameInMap("Balancer")]
            [Validation(Required=false)]
            public string Balancer { get; set; }

            [NameInMap("Brokers")]
            [Validation(Required=false)]
            public List<string> Brokers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gzip</para>
            /// </summary>
            [NameInMap("Compress")]
            [Validation(Required=false)]
            public string Compress { get; set; }

            [NameInMap("MachanismType")]
            [Validation(Required=false)]
            public string MachanismType { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("UserAuth")]
            [Validation(Required=false)]
            public bool? UserAuth { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("OssDelivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestOssDelivery OssDelivery { get; set; }
        public class CreateUserDeliveryTaskRequestOssDelivery : TeaModel {
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>logriver-test/log</para>
            /// </summary>
            [NameInMap("PrefixPath")]
            [Validation(Required=false)]
            public string PrefixPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("S3Delivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestS3Delivery S3Delivery { get; set; }
        public class CreateUserDeliveryTaskRequestS3Delivery : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            [NameInMap("BucketPath")]
            [Validation(Required=false)]
            public string BucketPath { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("PrefixPath")]
            [Validation(Required=false)]
            public string PrefixPath { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("S3Cmpt")]
            [Validation(Required=false)]
            public bool? S3Cmpt { get; set; }

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

        [NameInMap("SlsDelivery")]
        [Validation(Required=false)]
        public CreateUserDeliveryTaskRequestSlsDelivery SlsDelivery { get; set; }
        public class CreateUserDeliveryTaskRequestSlsDelivery : TeaModel {
            [NameInMap("SLSLogStore")]
            [Validation(Required=false)]
            public string SLSLogStore { get; set; }

            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            [NameInMap("SLSRegion")]
            [Validation(Required=false)]
            public string SLSRegion { get; set; }

        }

        /// <summary>
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
