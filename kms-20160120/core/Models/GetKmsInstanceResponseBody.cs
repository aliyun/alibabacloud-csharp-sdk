// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKmsInstanceResponseBody : TeaModel {
        /// <summary>
        /// The details of the KMS instance.
        /// </summary>
        [NameInMap("KmsInstance")]
        [Validation(Required=false)]
        public GetKmsInstanceResponseBodyKmsInstance KmsInstance { get; set; }
        public class GetKmsInstanceResponseBodyKmsInstance : TeaModel {
            /// <summary>
            /// A list of associated VPCs.
            /// 
            /// >  If your self-managed applications are deployed in multiple VPCs in the same region, you can associate VPCs with the KMS instance beyond the VPC that you specify when you enable the KMS instance. The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, self-managed applications in the VPCs can access the specified KMS instance.
            /// </summary>
            [NameInMap("BindVpcs")]
            [Validation(Required=false)]
            public GetKmsInstanceResponseBodyKmsInstanceBindVpcs BindVpcs { get; set; }
            public class GetKmsInstanceResponseBodyKmsInstanceBindVpcs : TeaModel {
                [NameInMap("BindVpc")]
                [Validation(Required=false)]
                public List<GetKmsInstanceResponseBodyKmsInstanceBindVpcsBindVpc> BindVpc { get; set; }
                public class GetKmsInstanceResponseBodyKmsInstanceBindVpcsBindVpc : TeaModel {
                    /// <summary>
                    /// The region to which the VPC belongs.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The vSwitch in the VPC.
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// The ID of the VPC.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// The Alibaba Cloud account to which the VPC belongs.
                    /// </summary>
                    [NameInMap("VpcOwnerId")]
                    [Validation(Required=false)]
                    public string VpcOwnerId { get; set; }

                }

            }

            /// <summary>
            /// The content of the certificate authority (CA) certificate of the KMS instance.
            /// </summary>
            [NameInMap("CaCertificateChainPem")]
            [Validation(Required=false)]
            public string CaCertificateChainPem { get; set; }

            /// <summary>
            /// The time when the KMS instance is created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The expiration time of the KMS instance.
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// The ID of the KMS instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the KMS instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The number of keys that can be created for the KMS instance.
            /// </summary>
            [NameInMap("KeyNum")]
            [Validation(Required=false)]
            public long? KeyNum { get; set; }

            /// <summary>
            /// The number of secrets that can be created for the KMS instance.
            /// </summary>
            [NameInMap("SecretNum")]
            [Validation(Required=false)]
            public string SecretNum { get; set; }

            /// <summary>
            /// The computing performance of the KMS instance.
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public long? Spec { get; set; }

            /// <summary>
            /// The time when the KMS instance is enabled.
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// The status of the KMS instance. Valid values:
            /// 
            /// *   Uninitialized: The KMS instance is not enabled.
            /// *   Connecting: The KMS instance is being connected.
            /// *   Connected: The KMS instance is enabled.
            /// *   Disconnected: The KMS instance is disconnected.
            /// *   Error: The KMS instance is abnormal.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) with which the KMS instance is associated.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The access management quota for the KMS instance.
            /// </summary>
            [NameInMap("VpcNum")]
            [Validation(Required=false)]
            public long? VpcNum { get; set; }

            /// <summary>
            /// The vSwitch in the VPC.
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public string VswitchIds { get; set; }

            /// <summary>
            /// The zone with which the KMS instance is associated.
            /// </summary>
            [NameInMap("ZoneIds")]
            [Validation(Required=false)]
            public string ZoneIds { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
