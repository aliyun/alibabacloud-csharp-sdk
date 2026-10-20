// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCloudVendorAccountAKRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the AccessKey (AK).</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudVendorAccountAKList~~">DescribeCloudVendorAccountAKList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2832</para>
        /// </summary>
        [NameInMap("AuthIds")]
        [Validation(Required=false)]
        public string AuthIds { get; set; }

        /// <summary>
        /// <para>The list of codes for the modules associated with the AK. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HOST</b>: host</description></item>
        /// <item><description><b>CSPM</b>: cloud product configuration check</description></item>
        /// <item><description><b>SIEM</b>: threat analysis and response</description></item>
        /// <item><description><b>TRIAL</b>: log audit<remarks>
        /// <para>You can call the <a href="~~GetSupportedModules~~">GetSupportedModules</a> operation to obtain the supported modules.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("AuthModules")]
        [Validation(Required=false)]
        public List<string> AuthModules { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// <remarks>
        /// <para>The account ID of the connected cloud vendor. This parameter is required when the permission description includes threat analysis and response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>azure_demo_1</para>
        /// </summary>
        [NameInMap("CtdrCloudUserId")]
        [Validation(Required=false)]
        public string CtdrCloudUserId { get; set; }

        /// <summary>
        /// <para>The domain to which the connected account belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>china</b>: China</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// <item><description><b>europe</b>: Huawei Cloud Europe site</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when <b>Vendor</b> is set to <b>HUAWEICLOUD</b>, <b>Azure</b>, <b>AWS</b>, <b>VOLCENGINE</b>, <b>KingsoftCloud</b>, <b>UCloud</b>, <b>BaiduCloud</b>, or <b>OracleCloud</b>. For <b>KingsoftCloud</b> and <b>BaiduCloud</b>, this parameter is fixed to <b>china</b>. For <b>OracleCloud</b>, this parameter is fixed to <b>global</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// <remarks>
        /// <para>This parameter is used to record the extended information of different vendors.
        /// Google Cloud is accessed through a service account. ExtendInfo stores the JSON-formatted service key file, excluding the private_key_id and zprivate_key fields. The file contains the following fields: type, project_id, client_email, client_id, auth_uri, token_uri, auth_provider_x509_cert_url, client_x509_cert_url, and universe_domain. If the vendor is <b>OracleCloud</b>, this parameter contains the <b>fingerprint</b> key, which indicates the fingerprint.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;product\&quot;:\&quot;webFirewall\&quot;,\&quot;remark\&quot;:\&quot;remark\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The language type of the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The list of regions used for AK information verification. This parameter is valid only when <b>Vendor</b> is set to <b>AWS</b> or <b>OracleCloud</b>.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCloudVendorRegions~~">ListCloudVendorRegions</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The ID of the AK parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If AkType is set to primary:</description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>Tencent</b>: the AccessKey ID of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>HUAWEICLOUD</b>: the AccessKey ID of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>Azure</b>: the client ID</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>AWS</b>: the AccessKey ID of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>VOLCENGINE</b>: the AccessKey ID of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>KingsoftCloud</b>: the AccessKey ID of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>UCloud</b>: the AccessKey ID of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If AkType is set to sub:</description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>Tencent</b>: the AccessKey ID of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>HUAWEICLOUD</b>: the AccessKey ID of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>Azure</b>: the client ID</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>AWS</b>: the AccessKey ID of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>VOLCENGINE</b>: the AccessKey ID of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>google</b>: the private key ID</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>OracleCloud</b>: the Oracle Cloud Identifier (OCID) of the sub-user</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>BaiduCloud</b>: the AccessKey ID of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>KingsoftCloud</b>: the AccessKey ID of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>UCloud</b>: the AccessKey ID of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>StateCloud</b>: the AccessKey ID of the sub-account<remarks>
        /// <para>If AkType is set to <b>primary</b>, this value is the SecretID of the primary account of the third-party cloud. If AkType is set to <b>sub</b>, this value is the AccessKey ID of the sub-account of the third-party cloud. For <b>Azure</b>, no distinction is made, and this value is the <b>appId</b> of the authentication information. Google Cloud is accessed through a service account. By default, AkType is set to sub, and this value is obtained from the private_key_id property of the JSON-formatted service key file. If the vendor is <b>OracleCloud</b>, this value is the OCID of the sub-user.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>S3D6c4O***</para>
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// <para>The secret of the AK parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If AkType is set to primary:</description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>Tencent</b>: the SecretAccessKey of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>HUAWEICLOUD</b>: the SecretAccessKey of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>Azure</b>: the client secret</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>AWS</b>: the SecretAccessKey of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>VOLCENGINE</b>: the SecretAccessKey of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>KingsoftCloud</b>: the SecretAccessKey of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>UCloud</b>: the SecretAccessKey of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If AkType is set to sub:</description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>Tencent</b>: the SecretAccessKey of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>HUAWEICLOUD</b>: the SecretAccessKey of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>Azure</b>: the client secret</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>AWS</b>: the SecretAccessKey of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>google</b>: the private key</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>OracleCloud</b>: the private key of the sub-user</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>BaiduCloud</b>: the SecretAccessKey of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>KingsoftCloud</b>: the SecretAccessKey of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>UCloud</b>: the SecretAccessKey of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><b>StateCloud</b>: the SecretAccessKey of the sub-account<remarks>
        /// <para>If AkType is set to <b>primary</b>, this value is the Secret Access Key of the primary account of the third-party cloud. If AkType is set to <b>sub</b>, this value is the Secret Access Key of the sub-account of the third-party cloud. For <b>Azure</b>, no distinction is made, and this value is the <b>password</b> of the authentication information. Google Cloud is accessed through a service account. By default, AkType is set to sub, and this value is obtained from the private_key property of the JSON-formatted service key file. For <b>OracleCloud</b>, this value is obtained from the content of the corresponding private key file.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AE6SLd****</para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>The usage status of the AK. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: enabled</description></item>
        /// <item><description><b>1</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The list of subscription IDs.</para>
        /// <remarks>
        /// <para><b>[Deprecated]</b> This parameter is no longer valid.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SubscriptionIds")]
        [Validation(Required=false)]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para>This parameter is valid only when Vendor is set to <b>Azure</b> or <b>OracleCloud</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>95304a97-339b-4de5-9a7d-cdbffaf****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The name of the AK account.</para>
        /// <remarks>
        /// <para>This parameter is used to identify the account information to which the third-party host assets belong.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VendorAuthAlias")]
        [Validation(Required=false)]
        public string VendorAuthAlias { get; set; }

    }

}
