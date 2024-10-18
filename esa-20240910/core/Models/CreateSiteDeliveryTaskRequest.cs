// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteDeliveryTaskRequest : TeaModel {
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
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_agent,ip_adress,ip_port</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        [NameInMap("HttpDelivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestHttpDelivery HttpDelivery { get; set; }
        public class CreateSiteDeliveryTaskRequestHttpDelivery : TeaModel {
            [NameInMap("Compress")]
            [Validation(Required=false)]
            public string Compress { get; set; }

            [NameInMap("DestUrl")]
            [Validation(Required=false)]
            public string DestUrl { get; set; }

            [NameInMap("HeaderParam")]
            [Validation(Required=false)]
            public Dictionary<string, HttpDeliveryHeaderParamValue> HeaderParam { get; set; }

            [NameInMap("LogBodyPrefix")]
            [Validation(Required=false)]
            public string LogBodyPrefix { get; set; }

            [NameInMap("LogBodySuffix")]
            [Validation(Required=false)]
            public string LogBodySuffix { get; set; }

            [NameInMap("MaxBatchMB")]
            [Validation(Required=false)]
            public long? MaxBatchMB { get; set; }

            [NameInMap("MaxBatchSize")]
            [Validation(Required=false)]
            public long? MaxBatchSize { get; set; }

            [NameInMap("MaxRetry")]
            [Validation(Required=false)]
            public long? MaxRetry { get; set; }

            [NameInMap("QueryParam")]
            [Validation(Required=false)]
            public Dictionary<string, HttpDeliveryQueryParamValue> QueryParam { get; set; }

            [NameInMap("StandardAuthOn")]
            [Validation(Required=false)]
            public bool? StandardAuthOn { get; set; }

            [NameInMap("StandardAuthParam")]
            [Validation(Required=false)]
            public CreateSiteDeliveryTaskRequestHttpDeliveryStandardAuthParam StandardAuthParam { get; set; }
            public class CreateSiteDeliveryTaskRequestHttpDeliveryStandardAuthParam : TeaModel {
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

            [NameInMap("TransformTimeout")]
            [Validation(Required=false)]
            public long? TransformTimeout { get; set; }

        }

        [NameInMap("KafkaDelivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestKafkaDelivery KafkaDelivery { get; set; }
        public class CreateSiteDeliveryTaskRequestKafkaDelivery : TeaModel {
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
        public CreateSiteDeliveryTaskRequestOssDelivery OssDelivery { get; set; }
        public class CreateSiteDeliveryTaskRequestOssDelivery : TeaModel {
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
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("S3Delivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestS3Delivery S3Delivery { get; set; }
        public class CreateSiteDeliveryTaskRequestS3Delivery : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312312112***</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        [NameInMap("SlsDelivery")]
        [Validation(Required=false)]
        public CreateSiteDeliveryTaskRequestSlsDelivery SlsDelivery { get; set; }
        public class CreateSiteDeliveryTaskRequestSlsDelivery : TeaModel {
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
        /// <para>dcdn-test-task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
