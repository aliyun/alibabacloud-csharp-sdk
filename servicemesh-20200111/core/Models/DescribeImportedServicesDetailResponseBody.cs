// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeImportedServicesDetailResponseBody : TeaModel {
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeImportedServicesDetailResponseBodyDetails> Details { get; set; }
        public class DescribeImportedServicesDetailResponseBodyDetails : TeaModel {
            [NameInMap("ClusterIds")]
            [Validation(Required=false)]
            public List<string> ClusterIds { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeImportedServicesDetailResponseBodyDetailsPorts> Ports { get; set; }
            public class DescribeImportedServicesDetailResponseBodyDetailsPorts : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NodePort")]
                [Validation(Required=false)]
                public int? NodePort { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
