// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the request.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateInstanceResponseBodyResult Result { get; set; }
        public class UpdateInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The private domain name of the instance.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The edition of the dedicated KMS instance.
            /// </summary>
            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The configuration of Kibana nodes.
            /// </summary>
            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public UpdateInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class UpdateInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The size of the node storage space.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node. This parameter can be ignored.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The node specifications.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The configuration of dedicated master nodes.
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public UpdateInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class UpdateInstanceResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The storage space of the node. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node. Only cloud_ssd(SSD cloud disk) is supported.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The node specifications.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The number of data nodes.
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// The configuration of data nodes.
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public UpdateInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class UpdateInstanceResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// The storage space of the node. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node. Valid values:
                /// 
                /// *   cloud_ssd: standard SSD
                /// *   cloud_efficiency: ultra disk
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The node specifications.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The billing method of the instance. Valid values:
            /// 
            /// *   prepaid: subscription
            /// *   postpaid: pay-as-you-go
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// The state of the instance. Valid values:
            /// 
            /// *   active: normal
            /// *   activating: taking effect
            /// *   inactive: frozen
            /// *   invalid: invalid
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
