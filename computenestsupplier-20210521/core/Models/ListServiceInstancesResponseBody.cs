// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstancesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceInstances")]
        [Validation(Required=false)]
        public List<ListServiceInstancesResponseBodyServiceInstances> ServiceInstances { get; set; }
        public class ListServiceInstancesResponseBodyServiceInstances : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EnableInstanceOps")]
            [Validation(Required=false)]
            public bool? EnableInstanceOps { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("IsOperated")]
            [Validation(Required=false)]
            public bool? IsOperated { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OperatedServiceInstanceId")]
            [Validation(Required=false)]
            public string OperatedServiceInstanceId { get; set; }

            [NameInMap("OperationEndTime")]
            [Validation(Required=false)]
            public string OperationEndTime { get; set; }

            [NameInMap("OperationStartTime")]
            [Validation(Required=false)]
            public string OperationStartTime { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            [NameInMap("Service")]
            [Validation(Required=false)]
            public ListServiceInstancesResponseBodyServiceInstancesService Service { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesService : TeaModel {
                [NameInMap("DeployMetadata")]
                [Validation(Required=false)]
                public string DeployMetadata { get; set; }

                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                [NameInMap("EnablePrivateVpcConnection")]
                [Validation(Required=false)]
                public bool? EnablePrivateVpcConnection { get; set; }

                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                [NameInMap("ServiceInfos")]
                [Validation(Required=false)]
                public List<ListServiceInstancesResponseBodyServiceInstancesServiceServiceInfos> ServiceInfos { get; set; }
                public class ListServiceInstancesResponseBodyServiceInstancesServiceServiceInfos : TeaModel {
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    [NameInMap("Locale")]
                    [Validation(Required=false)]
                    public string Locale { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShortDescription")]
                    [Validation(Required=false)]
                    public string ShortDescription { get; set; }

                }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                [NameInMap("SupplierUrl")]
                [Validation(Required=false)]
                public string SupplierUrl { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServiceInstancesResponseBodyServiceInstancesTags> Tags { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
