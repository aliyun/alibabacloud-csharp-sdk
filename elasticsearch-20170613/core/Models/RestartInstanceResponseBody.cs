// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RestartInstanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public RestartInstanceResponseBodyResult Result { get; set; }
        public class RestartInstanceResponseBodyResult : TeaModel {
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
            /// The configuration of the IK dictionaries.
            /// </summary>
            [NameInMap("dictList")]
            [Validation(Required=false)]
            public List<RestartInstanceResponseBodyResultDictList> DictList { get; set; }
            public class RestartInstanceResponseBodyResultDictList : TeaModel {
                /// <summary>
                /// The size of the Dictionary File. Unit: bytes.
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
                /// The source type. Valid values:
                /// 
                /// *   OSS: OSS open storage (need to ensure that OSS storage space is public readable.)
                /// *   ORIGIN: Open source Elasticsearch
                /// *   UPLOAD: Uploaded files
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The type of the dictionary. Valid values:
                /// 
                /// *   STOP: The STOP word.
                /// *   MAIN: MAIN Dictionary
                /// *   SYNONYMS: SYNONYMS
                /// *   ALI_WS: an Alibaba Dictionary.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The intranet access address of the instance.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The version of the instance.
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
            public RestartInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class RestartInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// The number of performance metrics.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The size of the node storage space. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The specification of data nodes.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The public network access address of Kibana.
            /// </summary>
            [NameInMap("kibanaDomain")]
            [Validation(Required=false)]
            public string KibanaDomain { get; set; }

            /// <summary>
            /// The public port of the Kibana network.
            /// </summary>
            [NameInMap("kibanaPort")]
            [Validation(Required=false)]
            public int? KibanaPort { get; set; }

            /// <summary>
            /// The configuration of dedicated master nodes.
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public RestartInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class RestartInstanceResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// The number of nodes in the cluster.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// The size of the node storage space. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node. This tool only supports cloud_ssd (cloud SSD) disks.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The node specifications of the cluster.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The network configuration.
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public RestartInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class RestartInstanceResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// The network type. Only Virtual Private Cloud (VPC) is supported.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone where the instance is deployed.
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// The ID of the vSwitch associated with the specified VPC.
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

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
            public RestartInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class RestartInstanceResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// The storage space size per data node. Unit: GB.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The storage type of the node. Valid values: cloud_ssd and cloud_efficiency.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The specification of data nodes.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The billing method of the created ECS instance.
            /// 
            /// Valid values: prepaid and postpaid.
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// The public network access address.
            /// </summary>
            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

            /// <summary>
            /// The public network port.
            /// </summary>
            [NameInMap("publicPort")]
            [Validation(Required=false)]
            public int? PublicPort { get; set; }

            /// <summary>
            /// The state of the cluster.
            /// 
            /// Supported: active (normal), activating (initializing), inactive (blocked), and invalid (expired).
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The configuration of the synonym dictionaries.
            /// </summary>
            [NameInMap("synonymsDicts")]
            [Validation(Required=false)]
            public List<RestartInstanceResponseBodyResultSynonymsDicts> SynonymsDicts { get; set; }
            public class RestartInstanceResponseBodyResultSynonymsDicts : TeaModel {
                /// <summary>
                /// The size of the Dictionary File. Unit: bytes.
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
                /// The source type. Valid values:
                /// 
                /// *   OSS:OSS open storage (the OSS storage space must be publicly readable.)
                /// *   ORIGIN: open-source Elasticsearch
                /// *   UPLOAD
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The type of the dictionary. Valid values:
                /// 
                /// *   STOP: The STOP word.
                /// *   MAIN: MAIN Dictionary
                /// *   SYNONYMS: SYNONYMS
                /// *   ALI_WS: an Alibaba Dictionary.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The time when the instance was last updated.
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

    }

}
