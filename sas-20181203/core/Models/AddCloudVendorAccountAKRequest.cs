// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCloudVendorAccountAKRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>primary</b>: Primary account</description></item>
        /// <item><description><b>sub</b>: Sub-account</description></item>
        /// <item><description><b>ctdr</b>: Agentic SOC<remarks>
        /// <para>Warning: When the vendor is <b>CHAITIN</b>, <b>FORTINET</b>, <b>THREATBOOK</b>, or <b>WIZ</b>, set this parameter to <b>ctdr</b>. When the vendor is <b>OracleCloud</b>, <b>google</b>, <b>BaiduCloud</b>, or <b>StateCloud</b>, set this parameter to <b>sub</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("AkType")]
        [Validation(Required=false)]
        public string AkType { get; set; }

        /// <summary>
        /// <para>The list of modules associated with the AccessKey.</para>
        /// <para>When AkType is set to ctdr, this parameter is required and at least one module must be provided, such as SIEM, HOST, or CSPM. If this parameter is not provided, the API returns HTTP 400 with the error code -101.</para>
        /// </summary>
        [NameInMap("AuthModules")]
        [Validation(Required=false)]
        public List<string> AuthModules { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// <remarks>
        /// <para>The account ID of the connected cloud vendor. This parameter is required when the permission description includes Cloud Threat Detection and Response.</para>
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
        /// <item><description><b>global</b>: Global</description></item>
        /// <item><description><b>europe</b>: Huawei Cloud Europe</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when <b>Vendor</b> is set to <b>HUAWEICLOUD</b>, <b>Azure</b>, <b>AWS</b>, <b>VOLCENGINE</b>, <b>KingsoftCloud</b>, <b>UCloud</b>, <b>BaiduCloud</b>, or <b>OracleCloud</b>. For <b>KingsoftCloud</b> and <b>BaiduCloud</b>, set this parameter to <b>china</b>. For <b>OracleCloud</b>, set this parameter to <b>global</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The extension information.</para>
        /// <remarks>
        /// <para>This parameter is used to record the extension information of different vendors.
        /// Google Cloud is accessed through a service account. ExtendInfo stores the JSON-formatted service key file, excluding the private_key_id and zprivate_key fields. The file contains the following fields: type, project_id, client_email, client_id, auth_uri, token_uri, auth_provider_x509_cert_url, client_x509_cert_url, and universe_domain. When the vendor is <b>OracleCloud</b>, this parameter contains the <b>fingerprint</b> key, which indicates the fingerprint.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;product\&quot;:\&quot;webFirewall\&quot;,\&quot;remark\&quot;:\&quot;remark\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The list of regions used to verify the AccessKey information. This parameter is valid only when <b>Vendor</b> is set to <b>AWS</b> or <b>OracleCloud</b>.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCloudVendorRegions~~">ListCloudVendorRegions</a> operation to query the regions.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The AccessKey ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If AkType is set to primary:<list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKey ID of the primary account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKey ID of the primary account</description></item>
        /// <item><description><b>Azure</b>: Client ID</description></item>
        /// <item><description><b>AWS</b>: AccessKey ID of the primary account</description></item>
        /// <item><description><b>VOLCENGINE</b>: AccessKey ID of the primary account</description></item>
        /// <item><description><b>KingsoftCloud</b>: AccessKey ID of the primary account</description></item>
        /// <item><description><b>UCloud</b>: AccessKey ID of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If AkType is set to sub:<list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKey ID of the sub-account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKey ID of the sub-account</description></item>
        /// <item><description><b>Azure</b>: Client ID</description></item>
        /// <item><description><b>AWS</b>: AccessKey ID of the sub-account</description></item>
        /// <item><description><b>VOLCENGINE</b>: AccessKey ID of the sub-account</description></item>
        /// <item><description><b>google</b>: private_key_id</description></item>
        /// <item><description><b>OracleCloud</b>: OCID of the sub-user</description></item>
        /// <item><description><b>BaiduCloud</b>: AccessKey ID of the sub-account</description></item>
        /// <item><description><b>KingsoftCloud</b>: AccessKey ID of the sub-account</description></item>
        /// <item><description><b>UCloud</b>: AccessKey ID of the sub-account</description></item>
        /// <item><description><b>StateCloud</b>: AccessKey ID of the sub-account</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If AkType is set to <b>primary</b>, this value is the AccessKey ID of the primary account in the third-party cloud. If AkType is set to <b>sub</b>, this value is the AccessKey ID of the sub-account in the third-party cloud. For <b>Azure</b>, this parameter is not differentiated and the value is the <b>appId</b> of the authentication information. Google Cloud is accessed through a service account, and AkType defaults to <b>sub</b>. The value is obtained from the private_key_id property in the JSON-formatted service key file. If the vendor is <b>OracleCloud</b>, this value is the OCID of the sub-user.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45GLRV4SOT0YFB****</para>
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If AkType is set to primary:<list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKey secret of the primary account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKey secret of the primary account</description></item>
        /// <item><description><b>Azure</b>: Client secret</description></item>
        /// <item><description><b>AWS</b>: AccessKey secret of the primary account</description></item>
        /// <item><description><b>VOLCENGINE</b>: AccessKey secret of the primary account</description></item>
        /// <item><description><b>KingsoftCloud</b>: AccessKey secret of the primary account</description></item>
        /// <item><description><b>UCloud</b>: AccessKey secret of the primary account</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If AkType is set to sub:<list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKey secret of the sub-account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKey secret of the sub-account</description></item>
        /// <item><description><b>Azure</b>: Client secret</description></item>
        /// <item><description><b>AWS</b>: AccessKey secret of the sub-account</description></item>
        /// <item><description><b>google</b>: private_key</description></item>
        /// <item><description><b>OracleCloud</b>: private_key of the sub-user</description></item>
        /// <item><description><b>BaiduCloud</b>: AccessKey secret of the sub-account</description></item>
        /// <item><description><b>KingsoftCloud</b>: AccessKey secret of the sub-account</description></item>
        /// <item><description><b>UCloud</b>: AccessKey secret of the sub-account</description></item>
        /// <item><description><b>StateCloud</b>: AccessKey secret of the sub-account<remarks>
        /// <para>If AkType is set to <b>primary</b>, this value is the AccessKey secret of the primary account in the third-party cloud. If AkType is set to <b>sub</b>, this value is the AccessKey secret of the sub-account in the third-party cloud. For <b>Azure</b>, this parameter is not differentiated and the value is the <b>password</b> of the authentication information. Google Cloud is accessed through a service account, and AkType defaults to <b>sub</b>. The value is obtained from the private_key property in the JSON-formatted service key file. For <b>OracleCloud</b>, this value is obtained from the content of the corresponding private key file.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE6SLd****</para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>The list of subscription IDs.</para>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
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
        /// <para>The cloud asset vendor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud</description></item>
        /// <item><description><b>Azure</b>: Azure</description></item>
        /// <item><description><b>AWS</b>: AWS</description></item>
        /// <item><description><b>VOLCENGINE</b>: Volcengine</description></item>
        /// <item><description><b>google</b>: Google Cloud</description></item>
        /// <item><description><b>CHAITIN</b>: Chaitin Tech</description></item>
        /// <item><description><b>FORTINET</b>: Fortinet</description></item>
        /// <item><description><b>THREATBOOK</b>: ThreatBook</description></item>
        /// <item><description><b>KingsoftCloud</b>: Kingsoft Cloud</description></item>
        /// <item><description><b>UCloud</b>: UCloud</description></item>
        /// <item><description><b>BaiduCloud</b>: Baidu AI Cloud</description></item>
        /// <item><description><b>WIZ</b>: Wiz</description></item>
        /// <item><description><b>OracleCloud</b>: Oracle Cloud</description></item>
        /// <item><description><b>StateCloud</b>: China Telecom Cloud</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AWS</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

        /// <summary>
        /// <para>The name of the AccessKey account.</para>
        /// <remarks>
        /// <para>This parameter is used to identify the account to which the third-party host assets belong.</para>
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
