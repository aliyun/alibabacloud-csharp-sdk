// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstancesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("ServiceInstances")]
        [Validation(Required=false)]
        public List<ListServiceInstancesResponseBodyServiceInstances> ServiceInstances { get; set; }
        public class ListServiceInstancesResponseBodyServiceInstances : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            [NameInMap("Service")]
            [Validation(Required=false)]
            public ListServiceInstancesResponseBodyServiceInstancesService Service { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesService : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }
                [NameInMap("SupplierUrl")]
                [Validation(Required=false)]
                public string SupplierUrl { get; set; }
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }
                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }
                [NameInMap("ServiceInfos")]
                [Validation(Required=false)]
                public List<ListServiceInstancesResponseBodyServiceInstancesServiceServiceInfos> ServiceInfos { get; set; }
                public class ListServiceInstancesResponseBodyServiceInstancesServiceServiceInfos : TeaModel {
                    public string Locale { get; set; }
                    public string Image { get; set; }
                    public string Name { get; set; }
                    public string ShortDescription { get; set; }
                }
            };

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

    }

}
