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
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("KmsInstance")]
        [Validation(Required=false)]
        public GetKmsInstanceResponseBodyKmsInstance KmsInstance { get; set; }
        public class GetKmsInstanceResponseBodyKmsInstance : TeaModel {
            [NameInMap("BindVpcs")]
            [Validation(Required=false)]
            public GetKmsInstanceResponseBodyKmsInstanceBindVpcs BindVpcs { get; set; }
            public class GetKmsInstanceResponseBodyKmsInstanceBindVpcs : TeaModel {
                [NameInMap("BindVpc")]
                [Validation(Required=false)]
                public List<GetKmsInstanceResponseBodyKmsInstanceBindVpcsBindVpc> BindVpc { get; set; }
                public class GetKmsInstanceResponseBodyKmsInstanceBindVpcsBindVpc : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("VpcOwnerId")]
                    [Validation(Required=false)]
                    public string VpcOwnerId { get; set; }

                }

            }

            /// <summary>
            /// <para>The CA certificate chain for the KMS instance in PEM format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----\r\nMIIDuzCCAqOgAwIBAgIJALTKwWAjvbMiMA0GCSqGSIb3DQEBCwUAMHQxCzAJBgNV****-----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("CaCertificateChainPem")]
            [Validation(Required=false)]
            public string CaCertificateChainPem { get; set; }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PREPAY</c>: subscription</para>
            /// </description></item>
            /// <item><description><para><c>POSTPAY</c>: pay-as-you-go</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The creation time of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-05T12:44:20Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            [NameInMap("DeletionProtectionDescription")]
            [Validation(Required=false)]
            public string DeletionProtectionDescription { get; set; }

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
            /// <para>The maximum number of keys that can be created in the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeyNum")]
            [Validation(Required=false)]
            public long? KeyNum { get; set; }

            /// <summary>
            /// <para>Indicates whether logging is enabled for the KMS instance. Valid values: <c>1</c> (enabled) and <c>0</c> (disabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public long? Log { get; set; }

            /// <summary>
            /// <para>The log storage capacity. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("LogStorage")]
            [Validation(Required=false)]
            public long? LogStorage { get; set; }

            /// <summary>
            /// <para>The product type.<br>Subscription:<br><c>kms_ddi_public_cn</c>: China site<br><c>kms_ddi_public_intl</c>: international site<br>Pay-as-you-go:<br><c>kms_ppi_public_cn</c>: China site<br><c>kms_ppi_public_intl</c>: international site<br><br><br><br><br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>kms_ddi_public_cn</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The version of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProductVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            /// <summary>
            /// <para>The sales status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SaleStatus")]
            [Validation(Required=false)]
            public string SaleStatus { get; set; }

            /// <summary>
            /// <para>The maximum number of credentials that can be created in the KMS instance.</para>
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
            /// <para>The time when the KMS instance was enabled.</para>
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
            /// <item><description><para><c>Uninitialized</c>: The instance is not enabled.</para>
            /// </description></item>
            /// <item><description><para><c>Connecting</c>: The instance is connecting.</para>
            /// </description></item>
            /// <item><description><para><c>Connected</c>: The instance is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>Disconnected</c>: The instance is disconnected.</para>
            /// </description></item>
            /// <item><description><para><c>Error</c>: The instance is in an error state.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The VPC to which the KMS instance is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp19z7cwmltad5dff****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The maximum number of VPCs that can be associated with the KMS instance for access control.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("VpcNum")]
            [Validation(Required=false)]
            public long? VpcNum { get; set; }

            /// <summary>
            /// <para>The vSwitches in the VPC to which the KMS instance is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1i512amda6d10a0****</para>
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

            /// <summary>
            /// <para>The zones to which the KMS instance is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;cn-hangzhou-k&quot;,       &quot;cn-hangzhou-j&quot;</para>
            /// </summary>
            [NameInMap("ZoneIds")]
            [Validation(Required=false)]
            public List<string> ZoneIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use this ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46b4a94a-57d2-44b4-9810-1e87d31abb33</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
