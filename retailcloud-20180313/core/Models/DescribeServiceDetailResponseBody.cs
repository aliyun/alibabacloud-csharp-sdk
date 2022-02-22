// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeServiceDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeServiceDetailResponseBodyResult Result { get; set; }
        public class DescribeServiceDetailResponseBodyResult : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }
            [NameInMap("ClusterIP")]
            [Validation(Required=false)]
            public string ClusterIP { get; set; }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public long? EnvId { get; set; }
            [NameInMap("Headless")]
            [Validation(Required=false)]
            public bool? Headless { get; set; }
            [NameInMap("K8sServiceId")]
            [Validation(Required=false)]
            public string K8sServiceId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PortMappings")]
            [Validation(Required=false)]
            public List<DescribeServiceDetailResponseBodyResultPortMappings> PortMappings { get; set; }
            public class DescribeServiceDetailResponseBodyResultPortMappings : TeaModel {
                public string Name { get; set; }
                public int? NodePort { get; set; }
                public int? Port { get; set; }
                public string Protocol { get; set; }
                public string TargetPort { get; set; }
            }
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
