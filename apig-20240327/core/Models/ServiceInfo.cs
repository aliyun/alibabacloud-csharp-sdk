// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ServiceInfo : TeaModel {
        [NameInMap("expressType")]
        [Validation(Required=false)]
        public string ExpressType { get; set; }

        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("paiWorkspaceId")]
        [Validation(Required=false)]
        public string PaiWorkspaceId { get; set; }

        [NameInMap("paiWorkspaceName")]
        [Validation(Required=false)]
        public string PaiWorkspaceName { get; set; }

        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<ServiceInfoPorts> Ports { get; set; }
        public class ServiceInfoPorts : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ServiceInfoVersions> Versions { get; set; }
        public class ServiceInfoVersions : TeaModel {
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<ServiceInfoVersionsLabels> Labels { get; set; }
            public class ServiceInfoVersionsLabels : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
