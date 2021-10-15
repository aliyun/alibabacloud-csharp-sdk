// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListLogstashResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListLogstashResponseBodyHeaders Headers { get; set; }
        public class ListLogstashResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }
        };

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListLogstashResponseBodyResult> Result { get; set; }
        public class ListLogstashResponseBodyResult : TeaModel {
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLogstashResponseBodyResultTags> Tags { get; set; }
            public class ListLogstashResponseBodyResultTags : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public ListLogstashResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class ListLogstashResponseBodyResultNodeSpec : TeaModel {
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

            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public ListLogstashResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class ListLogstashResponseBodyResultNetworkConfig : TeaModel {
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

        }

    }

}
