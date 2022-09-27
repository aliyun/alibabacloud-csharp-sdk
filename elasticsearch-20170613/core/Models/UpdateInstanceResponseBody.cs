// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateInstanceResponseBodyResult Result { get; set; }
        public class UpdateInstanceResponseBodyResult : TeaModel {
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            public UpdateInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class UpdateInstanceResponseBodyResultKibanaConfiguration : TeaModel {
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

            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public UpdateInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class UpdateInstanceResponseBodyResultMasterConfiguration : TeaModel {
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

            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public UpdateInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class UpdateInstanceResponseBodyResultNodeSpec : TeaModel {
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

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
