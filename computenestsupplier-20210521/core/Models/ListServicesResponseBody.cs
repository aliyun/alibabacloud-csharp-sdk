// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServicesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListServicesResponseBodyServices> Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public string ApprovalType { get; set; }

            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            [NameInMap("ArtifactVersion")]
            [Validation(Required=false)]
            public string ArtifactVersion { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public bool? DefaultVersion { get; set; }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("LatestResellSourceServiceVersion")]
            [Validation(Required=false)]
            public string LatestResellSourceServiceVersion { get; set; }

            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            [NameInMap("ResellServiceId")]
            [Validation(Required=false)]
            public string ResellServiceId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesServiceInfos> ServiceInfos { get; set; }
            public class ListServicesResponseBodyServicesServiceInfos : TeaModel {
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

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("SourceImage")]
            [Validation(Required=false)]
            public string SourceImage { get; set; }

            [NameInMap("SourceServiceId")]
            [Validation(Required=false)]
            public string SourceServiceId { get; set; }

            [NameInMap("SourceServiceVersion")]
            [Validation(Required=false)]
            public string SourceServiceVersion { get; set; }

            [NameInMap("SourceSupplierName")]
            [Validation(Required=false)]
            public string SourceSupplierName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesTags> Tags { get; set; }
            public class ListServicesResponseBodyServicesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("TenantType")]
            [Validation(Required=false)]
            public string TenantType { get; set; }

            [NameInMap("TrialType")]
            [Validation(Required=false)]
            public string TrialType { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
