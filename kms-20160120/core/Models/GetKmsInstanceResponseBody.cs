// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKmsInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the KMS instance.</para>
        /// </summary>
        [NameInMap("KmsInstance")]
        [Validation(Required=false)]
        public GetKmsInstanceResponseBodyKmsInstance KmsInstance { get; set; }
        public class GetKmsInstanceResponseBodyKmsInstance : TeaModel {
            /// <summary>
            /// <para>A list of associated VPCs.</para>
            /// <remarks>
            /// <para> If your self-managed applications are deployed in multiple VPCs in the same region, you can associate VPCs with the KMS instance beyond the VPC that you specify when you enable the KMS instance. The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, self-managed applications in the VPCs can access the specified KMS instance.</para>
            /// </remarks>
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
                    /// <para>The region to which the VPC belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch in the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1i512amhdje10f1****</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp19z7djuhtad5dff****</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud account to which the VPC belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>190325303126****</para>
                    /// </summary>
                    [NameInMap("VpcOwnerId")]
                    [Validation(Required=false)]
                    public string VpcOwnerId { get; set; }

                }

            }

            /// <summary>
            /// <para>The content of the certificate authority (CA) certificate of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----\r\nMIIDuzCCAqOgAwIBAgIJALTKwWAjvbMiMA0GCSqGSIb3DQEBCwUAMHQxCzAJBgNV****-----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("CaCertificateChainPem")]
            [Validation(Required=false)]
            public string CaCertificateChainPem { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the KMS instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-05T12:44:20Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-05T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The ID of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kst-bjj62f5ba3dnpb6v8****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kst-bjj62f5ba3dnpb6v8****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The number of keys that can be created for the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeyNum")]
            [Validation(Required=false)]
            public long? KeyNum { get; set; }

            [NameInMap("Log")]
            [Validation(Required=false)]
            public long? Log { get; set; }

            [NameInMap("LogStorage")]
            [Validation(Required=false)]
            public long? LogStorage { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("ProductVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            [NameInMap("SaleStatus")]
            [Validation(Required=false)]
            public string SaleStatus { get; set; }

            /// <summary>
            /// <para>The number of secrets that can be created for the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SecretNum")]
            [Validation(Required=false)]
            public string SecretNum { get; set; }

            /// <summary>
            /// <para>The computing performance of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public long? Spec { get; set; }

            /// <summary>
            /// <para>The time when the KMS instance is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-05T12:44:19Z</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The status of the KMS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Uninitialized: The KMS instance is not enabled.</description></item>
            /// <item><description>Connecting: The KMS instance is being connected.</description></item>
            /// <item><description>Connected: The KMS instance is enabled.</description></item>
            /// <item><description>Disconnected: The KMS instance is disconnected.</description></item>
            /// <item><description>Error: The KMS instance is abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) with which the KMS instance is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp19z7cwmltad5dff****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The access management quota for the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("VpcNum")]
            [Validation(Required=false)]
            public long? VpcNum { get; set; }

            /// <summary>
            /// <para>The vSwitch in the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1i512amda6d10a0****</para>
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

            /// <summary>
            /// <para>The zone with which the KMS instance is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;cn-hangzhou-k&quot;,       &quot;cn-hangzhou-j&quot;</para>
            /// </summary>
            [NameInMap("ZoneIds")]
            [Validation(Required=false)]
            public List<string> ZoneIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46b4a94a-57d2-44b4-9810-1e87d31abb33</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
