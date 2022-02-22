// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateServiceRequest : TeaModel {
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
        public List<CreateServiceRequestPortMappings> PortMappings { get; set; }
        public class CreateServiceRequestPortMappings : TeaModel {
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
            public string TargetPort { get; set; }

        }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
