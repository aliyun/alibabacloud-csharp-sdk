// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the SAP HANA instances.</para>
        /// </summary>
        [NameInMap("Hanas")]
        [Validation(Required=false)]
        public DescribeHanaInstancesResponseBodyHanas Hanas { get; set; }
        public class DescribeHanaInstancesResponseBodyHanas : TeaModel {
            [NameInMap("Hana")]
            [Validation(Required=false)]
            public List<DescribeHanaInstancesResponseBodyHanasHana> Hana { get; set; }
            public class DescribeHanaInstancesResponseBodyHanasHana : TeaModel {
                /// <summary>
                /// <para>The alert settings. Valid value: INHERITED, which indicates that the Cloud Backup client sends alert notifications by using the same method configured for the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INHERITED</para>
                /// </summary>
                [NameInMap("AlertSetting")]
                [Validation(Required=false)]
                public string AlertSetting { get; set; }

                /// <summary>
                /// <para>The ID of the SAP HANA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cl-0004cf6g6******0yd7y</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The name of the Resource Access Management (RAM) role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hbrcrossrole</para>
                /// </summary>
                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                /// <summary>
                /// <para>Specifies whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SELF_ACCOUNT</b>: Data is backed up within the same Alibaba Cloud account.</description></item>
                /// <item><description><b>CROSS_ACCOUNT</b>: Data is backed up across Alibaba Cloud accounts.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CROSS_ACCOUNT</para>
                /// </summary>
                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                /// <summary>
                /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>158975xxxxx4625</para>
                /// </summary>
                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                /// <summary>
                /// <para>The name of the SAP HANA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HANA-DEV</para>
                /// </summary>
                [NameInMap("HanaName")]
                [Validation(Required=false)]
                public string HanaName { get; set; }

                /// <summary>
                /// <para>The private or internal IP address of the host where the primary node of the SAP HANA instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The instance number of the SAP HANA system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00</para>
                /// </summary>
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public int? InstanceNumber { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmvnf22m7itha</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The status of the SAP HANA instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INITIALIZING: The instance is being initialized.</description></item>
                /// <item><description>INITIALIZED: The instance is registered.</description></item>
                /// <item><description>INVALID_HANA_NODE: The instance is invalid.</description></item>
                /// <item><description>INITIALIZE_FAILED: The client fails to be installed on the instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INITIALIZED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>The status information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INSTALL_CLIENT_FAILED</para>
                /// </summary>
                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

                /// <summary>
                /// <para>The tags of the SAP HANA instance.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeHanaInstancesResponseBodyHanasHanaTags Tags { get; set; }
                public class DescribeHanaInstancesResponseBodyHanasHanaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeHanaInstancesResponseBodyHanasHanaTagsTag> Tag { get; set; }
                    public class DescribeHanaInstancesResponseBodyHanasHanaTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ace:rm:rgld</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rg-acfmwutpyat2kwy</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the SAP HANA instance is connected over Secure Sockets Layer (SSL). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The SAP HANA instance is connected over SSL.</description></item>
                /// <item><description>false: The SAP HANA instance is not connected over SSL.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseSsl")]
                [Validation(Required=false)]
                public bool? UseSsl { get; set; }

                /// <summary>
                /// <para>The username of the SYSTEMDB database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>Indicates whether the SSL certificate of the SAP HANA instance is verified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ValidateCertificate")]
                [Validation(Required=false)]
                public bool? ValidateCertificate { get; set; }

                /// <summary>
                /// <para>The ID of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-0000s974******1hl</para>
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4003DD68-3C3C-5071-B4FC-631A6C1BAC1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
