// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sServicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<GetK8sServicesResponseBodyServices> Services { get; set; }
        public class GetK8sServicesResponseBodyServices : TeaModel {
            [NameInMap("ClusterIP")]
            [Validation(Required=false)]
            public string ClusterIP { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ServicePorts")]
            [Validation(Required=false)]
            public List<GetK8sServicesResponseBodyServicesServicePorts> ServicePorts { get; set; }
            public class GetK8sServicesResponseBodyServicesServicePorts : TeaModel {
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
                public string TargetPort { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
