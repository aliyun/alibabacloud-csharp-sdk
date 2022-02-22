// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListServicesResponseBody : TeaModel {
        [NameInMap("ClusterIP")]
        [Validation(Required=false)]
        public string ClusterIP { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListServicesResponseBodyData> Data { get; set; }
        public class ListServicesResponseBodyData : TeaModel {
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
            public List<ListServicesResponseBodyDataPortMappings> PortMappings { get; set; }
            public class ListServicesResponseBodyDataPortMappings : TeaModel {
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

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
