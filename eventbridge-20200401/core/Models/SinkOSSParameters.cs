// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkOSSParameters : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("CompressionType")]
        [Validation(Required=false)]
        public string CompressionType { get; set; }

        [NameInMap("ContentTransform")]
        [Validation(Required=false)]
        public SinkOSSParametersContentTransform ContentTransform { get; set; }
        public class SinkOSSParametersContentTransform : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("PathFormat")]
        [Validation(Required=false)]
        public string PathFormat { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("RotateIntervalMs")]
        [Validation(Required=false)]
        public string RotateIntervalMs { get; set; }

        [NameInMap("RotateSizeBytes")]
        [Validation(Required=false)]
        public string RotateSizeBytes { get; set; }

        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public bool? SSLEnabled { get; set; }

        [NameInMap("TaskConcurrency")]
        [Validation(Required=false)]
        public string TaskConcurrency { get; set; }

        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
