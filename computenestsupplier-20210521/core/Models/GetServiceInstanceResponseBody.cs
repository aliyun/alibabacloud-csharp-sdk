// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceInstanceResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        [NameInMap("Service")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyService Service { get; set; }
        public class GetServiceInstanceResponseBodyService : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("DeployMetadata")]
            [Validation(Required=false)]
            public string DeployMetadata { get; set; }
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
            public List<GetServiceInstanceResponseBodyServiceServiceInfos> ServiceInfos { get; set; }
            public class GetServiceInstanceResponseBodyServiceServiceInfos : TeaModel {
                public string Locale { get; set; }
                public string Image { get; set; }
                public string Name { get; set; }
                public string ShortDescription { get; set; }
            }
        };

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        [NameInMap("OperationStartTime")]
        [Validation(Required=false)]
        public string OperationStartTime { get; set; }

        [NameInMap("OperationEndTime")]
        [Validation(Required=false)]
        public string OperationEndTime { get; set; }

        [NameInMap("OperatedServiceInstanceId")]
        [Validation(Required=false)]
        public string OperatedServiceInstanceId { get; set; }

        [NameInMap("IsOperated")]
        [Validation(Required=false)]
        public bool? IsOperated { get; set; }

        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
