// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class MoveResourceGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public MoveResourceGroupResponseBodyResult Result { get; set; }
        public class MoveResourceGroupResponseBodyResult : TeaModel {
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dictList")]
            [Validation(Required=false)]
            public List<MoveResourceGroupResponseBodyResultDictList> DictList { get; set; }
            public class MoveResourceGroupResponseBodyResultDictList : TeaModel {
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class MoveResourceGroupResponseBodyResultKibanaConfiguration : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("kibanaDomain")]
            [Validation(Required=false)]
            public string KibanaDomain { get; set; }

            [NameInMap("kibanaPort")]
            [Validation(Required=false)]
            public int? KibanaPort { get; set; }

            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class MoveResourceGroupResponseBodyResultMasterConfiguration : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class MoveResourceGroupResponseBodyResultNetworkConfig : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class MoveResourceGroupResponseBodyResultNodeSpec : TeaModel {
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

            [NameInMap("publicPort")]
            [Validation(Required=false)]
            public int? PublicPort { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("synonymsDicts")]
            [Validation(Required=false)]
            public List<MoveResourceGroupResponseBodyResultSynonymsDicts> SynonymsDicts { get; set; }
            public class MoveResourceGroupResponseBodyResultSynonymsDicts : TeaModel {
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

    }

}
