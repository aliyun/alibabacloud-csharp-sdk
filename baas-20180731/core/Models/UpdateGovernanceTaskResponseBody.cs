// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class UpdateGovernanceTaskResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateGovernanceTaskResponseBodyResult Result { get; set; }
        public class UpdateGovernanceTaskResponseBodyResult : TeaModel {
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public UpdateGovernanceTaskResponseBodyResultContent Content { get; set; }
            public class UpdateGovernanceTaskResponseBodyResultContent : TeaModel {
                [NameInMap("AddedOrganizations")]
                [Validation(Required=false)]
                public List<UpdateGovernanceTaskResponseBodyResultContentAddedOrganizations> AddedOrganizations { get; set; }
                public class UpdateGovernanceTaskResponseBodyResultContentAddedOrganizations : TeaModel {
                    [NameInMap("AnchorPeers")]
                    [Validation(Required=false)]
                    public List<UpdateGovernanceTaskResponseBodyResultContentAddedOrganizationsAnchorPeers> AnchorPeers { get; set; }
                    public class UpdateGovernanceTaskResponseBodyResultContentAddedOrganizationsAnchorPeers : TeaModel {
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }

                    [NameInMap("Crls")]
                    [Validation(Required=false)]
                    public string Crls { get; set; }

                    [NameInMap("MspId")]
                    [Validation(Required=false)]
                    public string MspId { get; set; }

                    [NameInMap("MspType")]
                    [Validation(Required=false)]
                    public string MspType { get; set; }

                    [NameInMap("Orderer")]
                    [Validation(Required=false)]
                    public bool? Orderer { get; set; }

                    [NameInMap("OrdererNodes")]
                    [Validation(Required=false)]
                    public List<UpdateGovernanceTaskResponseBodyResultContentAddedOrganizationsOrdererNodes> OrdererNodes { get; set; }
                    public class UpdateGovernanceTaskResponseBodyResultContentAddedOrganizationsOrdererNodes : TeaModel {
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        [NameInMap("Certificate")]
                        [Validation(Required=false)]
                        public string Certificate { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Tlsroot")]
                        [Validation(Required=false)]
                        public string Tlsroot { get; set; }

                    }

                    [NameInMap("RootCertificates")]
                    [Validation(Required=false)]
                    public string RootCertificates { get; set; }

                    [NameInMap("TlsRootCertificates")]
                    [Validation(Required=false)]
                    public string TlsRootCertificates { get; set; }

                }

                [NameInMap("ChaincodeSpecPkg")]
                [Validation(Required=false)]
                public UpdateGovernanceTaskResponseBodyResultContentChaincodeSpecPkg ChaincodeSpecPkg { get; set; }
                public class UpdateGovernanceTaskResponseBodyResultContentChaincodeSpecPkg : TeaModel {
                    [NameInMap("Cs")]
                    [Validation(Required=false)]
                    public UpdateGovernanceTaskResponseBodyResultContentChaincodeSpecPkgCs Cs { get; set; }
                    public class UpdateGovernanceTaskResponseBodyResultContentChaincodeSpecPkgCs : TeaModel {
                        [NameInMap("Input")]
                        [Validation(Required=false)]
                        public string Input { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Sha256")]
                    [Validation(Required=false)]
                    public string Sha256 { get; set; }

                }

                [NameInMap("OrdererConfig")]
                [Validation(Required=false)]
                public UpdateGovernanceTaskResponseBodyResultContentOrdererConfig OrdererConfig { get; set; }
                public class UpdateGovernanceTaskResponseBodyResultContentOrdererConfig : TeaModel {
                    [NameInMap("BatchTimeout")]
                    [Validation(Required=false)]
                    public string BatchTimeout { get; set; }

                    [NameInMap("MaxMessageCount")]
                    [Validation(Required=false)]
                    public int? MaxMessageCount { get; set; }

                    [NameInMap("PreferredMaxBytes")]
                    [Validation(Required=false)]
                    public int? PreferredMaxBytes { get; set; }

                }

                [NameInMap("Raw")]
                [Validation(Required=false)]
                public string Raw { get; set; }

                [NameInMap("RemovedOrganizations")]
                [Validation(Required=false)]
                public List<UpdateGovernanceTaskResponseBodyResultContentRemovedOrganizations> RemovedOrganizations { get; set; }
                public class UpdateGovernanceTaskResponseBodyResultContentRemovedOrganizations : TeaModel {
                    [NameInMap("AnchorPeers")]
                    [Validation(Required=false)]
                    public List<UpdateGovernanceTaskResponseBodyResultContentRemovedOrganizationsAnchorPeers> AnchorPeers { get; set; }
                    public class UpdateGovernanceTaskResponseBodyResultContentRemovedOrganizationsAnchorPeers : TeaModel {
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }

                    [NameInMap("Crls")]
                    [Validation(Required=false)]
                    public string Crls { get; set; }

                    [NameInMap("MspId")]
                    [Validation(Required=false)]
                    public string MspId { get; set; }

                    [NameInMap("MspType")]
                    [Validation(Required=false)]
                    public string MspType { get; set; }

                    [NameInMap("Orderer")]
                    [Validation(Required=false)]
                    public bool? Orderer { get; set; }

                    [NameInMap("OrdererNodes")]
                    [Validation(Required=false)]
                    public List<UpdateGovernanceTaskResponseBodyResultContentRemovedOrganizationsOrdererNodes> OrdererNodes { get; set; }
                    public class UpdateGovernanceTaskResponseBodyResultContentRemovedOrganizationsOrdererNodes : TeaModel {
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        [NameInMap("Certificate")]
                        [Validation(Required=false)]
                        public string Certificate { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Tlsroot")]
                        [Validation(Required=false)]
                        public string Tlsroot { get; set; }

                    }

                    [NameInMap("RootCertificates")]
                    [Validation(Required=false)]
                    public string RootCertificates { get; set; }

                    [NameInMap("TlsRootCertificates")]
                    [Validation(Required=false)]
                    public string TlsRootCertificates { get; set; }

                }

                [NameInMap("RwSets")]
                [Validation(Required=false)]
                public string RwSets { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
