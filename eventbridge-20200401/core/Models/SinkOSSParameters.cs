// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkOSSParameters : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket used to store event data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The compression type of the delivered files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gzip</para>
        /// </summary>
        [NameInMap("CompressionType")]
        [Validation(Required=false)]
        public string CompressionType { get; set; }

        /// <summary>
        /// <para>The event content transformation configuration before delivery to OSS.</para>
        /// </summary>
        [NameInMap("ContentTransform")]
        [Validation(Required=false)]
        public SinkOSSParametersContentTransform ContentTransform { get; set; }
        public class SinkOSSParametersContentTransform : TeaModel {
            /// <summary>
            /// <para>The transformation method for the delivered content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSONPATH</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format parameter values. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The value expression used to generate the delivered content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$.data.message</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The endpoint of the destination OSS service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The storage path for event data in the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/EB-test/</para>
        /// </summary>
        [NameInMap("PathFormat")]
        [Validation(Required=false)]
        public string PathFormat { get; set; }

        /// <summary>
        /// <para>The region ID of the destination OSS service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role used to deliver data to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890123456:role/example-eventbridge-role</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The time window for batch aggregation of event data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("RotateIntervalMs")]
        [Validation(Required=false)]
        public string RotateIntervalMs { get; set; }

        /// <summary>
        /// <para>The file size threshold for batch aggregation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("RotateSizeBytes")]
        [Validation(Required=false)]
        public string RotateSizeBytes { get; set; }

        /// <summary>
        /// <para>Specifies whether SSL is enabled.</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public bool? SSLEnabled { get; set; }

        /// <summary>
        /// <para>The number of concurrent delivery tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskConcurrency")]
        [Validation(Required=false)]
        public string TaskConcurrency { get; set; }

        /// <summary>
        /// <para>The time zone used for time variables in the storage path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTC+8:00</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
