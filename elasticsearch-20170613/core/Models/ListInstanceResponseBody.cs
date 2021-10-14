// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceResponseBodyHeaders Headers { get; set; }
        public class ListInstanceResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceResponseBodyResult> Result { get; set; }
        public class ListInstanceResponseBodyResult : TeaModel {
            [NameInMap("advancedDedicateMaster")]
            [Validation(Required=false)]
            public bool? AdvancedDedicateMaster { get; set; }

            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("dedicateMaster")]
            [Validation(Required=false)]
            public bool? DedicateMaster { get; set; }

            [NameInMap("serviceVpc")]
            [Validation(Required=false)]
            public bool? ServiceVpc { get; set; }

            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("postpaidServiceStatus")]
            [Validation(Required=false)]
            public string PostpaidServiceStatus { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            [NameInMap("isNewDeployment")]
            [Validation(Required=false)]
            public string IsNewDeployment { get; set; }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyResultTags> Tags { get; set; }
            public class ListInstanceResponseBodyResultTags : TeaModel {
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendConfigs { get; set; }

            [NameInMap("clientNodeConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultClientNodeConfiguration ClientNodeConfiguration { get; set; }
            public class ListInstanceResponseBodyResultClientNodeConfiguration : TeaModel {
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }
            };

            [NameInMap("elasticDataNodeConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }
            public class ListInstanceResponseBodyResultElasticDataNodeConfiguration : TeaModel {
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }
            };

            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class ListInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }
            };

            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class ListInstanceResponseBodyResultMasterConfiguration : TeaModel {
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }
            };

            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class ListInstanceResponseBodyResultNetworkConfig : TeaModel {
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }
            };

            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public ListInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class ListInstanceResponseBodyResultNodeSpec : TeaModel {
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }
            };

        }

    }

}
