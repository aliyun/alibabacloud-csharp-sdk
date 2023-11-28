// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class MoveResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public MoveResourceGroupResponseBodyResult Result { get; set; }
        public class MoveResourceGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the cluster was created.
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The configurations of IK dictionaries.
            /// </summary>
            [NameInMap("dictList")]
            [Validation(Required=false)]
            public List<MoveResourceGroupResponseBodyResultDictList> DictList { get; set; }
            public class MoveResourceGroupResponseBodyResultDictList : TeaModel {
                /// <summary>
                /// The size of the dictionary file. Unit: bytes.
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// The name of the dictionary file.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the source of the dictionary file. Valid values:
                /// 
                /// *   OSS: Object Storage Service (OSS). You must make sure that the access control list (ACL) of the related OSS bucket is public read.
                /// *   ORIGIN: previously uploaded dictionary.
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The type of the dictionary. Valid values:
                /// 
                /// *   STOP: stopword list
                /// *   MAIN: main dictionary
                /// *   SYNONYMS: synonym dictionary
                /// *   ALI_WS: Alibaba Cloud dictionary
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The internal endpoint of the cluster.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The version of the cluster.
            /// </summary>
            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The configurations of Kibana nodes.
            /// </summary>
            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class MoveResourceGroupResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The storage capacity. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The specification category.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The public endpoint of the Kibana console of the cluster.
            /// </summary>
            [NameInMap("kibanaDomain")]
            [Validation(Required=false)]
            public string KibanaDomain { get; set; }

            /// <summary>
            /// The port number that is used to access the Kibana console of the cluster over the Internet.
            /// </summary>
            [NameInMap("kibanaPort")]
            [Validation(Required=false)]
            public int? KibanaPort { get; set; }

            /// <summary>
            /// The configurations of dedicated master nodes.
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class MoveResourceGroupResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The storage capacity. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The specification category.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The network configurations.
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class MoveResourceGroupResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// The network type. Only the VPC is supported.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone where the cluster resides.
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// The number of data nodes in the cluster.
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// The configurations of data nodes.
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class MoveResourceGroupResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// The storage capacity. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The specification category.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The billing method of the cluster. Valid values:
            /// 
            /// *   prepaid: subscription
            /// *   postpaid: pay-as-you-go
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// The public endpoint of the cluster.
            /// </summary>
            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

            /// <summary>
            /// The port number that is used to access the cluster over the Internet.
            /// </summary>
            [NameInMap("publicPort")]
            [Validation(Required=false)]
            public int? PublicPort { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values:
            /// 
            /// *   active: The cluster is normal.
            /// *   activating: The cluster is being activated.
            /// *   Inactive: The cluster is frozen.
            /// *   invalid: The cluster is valid.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The configurations of synonym dictionaries.
            /// </summary>
            [NameInMap("synonymsDicts")]
            [Validation(Required=false)]
            public List<MoveResourceGroupResponseBodyResultSynonymsDicts> SynonymsDicts { get; set; }
            public class MoveResourceGroupResponseBodyResultSynonymsDicts : TeaModel {
                /// <summary>
                /// The size of the dictionary file. Unit: bytes.
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// The name of the dictionary file.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the source of the dictionary file. Valid values:
                /// 
                /// *   OSS: Object Storage Service (OSS). You must make sure that the ACL of the related OSS bucket is public read.
                /// *   ORIGIN: previously uploaded dictionary.
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The type of the dictionary. Valid values:
                /// 
                /// *   STOP: stopword list
                /// *   MAIN: main dictionary
                /// *   SYNONYMS: synonym dictionary
                /// *   ALI_WS: Alibaba Cloud dictionary
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The time when the cluster was last updated.
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

    }

}
