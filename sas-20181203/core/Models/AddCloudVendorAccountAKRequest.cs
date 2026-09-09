// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCloudVendorAccountAKRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey (AK) type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>primary</b>: Primary account.</description></item>
        /// <item><description><b>sub</b>: Sub-account.</description></item>
        /// <item><description><b>ctdr</b>: Agentic SOC.<remarks>
        /// <para>Warning: When the vendor is <b>CHAITIN</b>, <b>FORTINET</b>, <b>THREATBOOK</b>, or <b>WIZ</b>, set this parameter to ctdr.</warning></para>
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
        /// <para>The list of AK-associated modules.</para>
        /// </summary>
        [NameInMap("AuthModules")]
        [Validation(Required=false)]
        public List<string> AuthModules { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// <remarks>
        /// <para>The account ID of the connected cloud vendor. This parameter is required when the permission description includes Cloud Threat Detection and Response (CTDR).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>azure_demo_1</para>
        /// </summary>
        [NameInMap("CtdrCloudUserId")]
        [Validation(Required=false)]
        public string CtdrCloudUserId { get; set; }

        /// <summary>
        /// <para>The account domain for access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>china</b>: China</description></item>
        /// <item><description><b>global</b>: Global</description></item>
        /// <item><description><b>europe</b>: Huawei Cloud Europe</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when <b>Vendor</b> is set to <b>HUAWEICLOUD</b>, <b>Azure</b>, <b>AWS</b>, <b>VOLCENGINE</b>, <b>KingsoftCloud</b>, <b>UCloud</b>, or <b>BaiduCloud</b>, and is required. Set this parameter to <b>china</b> for KingsoftCloud and BaiduCloud, and to <b>global</b> for UCloud.</para>
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
        /// <para>Used to record extended information for different vendors.
        /// Google Cloud is accessed through a service account. ExtendInfo stores the JSON-formatted service key file, excluding the private_key_id and private_key fields. The file contains the following fields: type, project_id, client_email, client_id, auth_uri, token_uri, auth_provider_x509_cert_url, client_x509_cert_url, and universe_domain.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;product\&quot;:\&quot;webFirewall\&quot;,\&quot;remark\&quot;:\&quot;remark\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The list of regions used for AK information verification. This parameter is valid only when Vendor is set to AWS.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListCloudVendorRegions~~">ListCloudVendorRegions</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The AK parameter ID. Valid values:</para>
        /// <ol>
        /// <item><description>When AkType is set to primary:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKeyId of the primary account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKeyId of the primary account</description></item>
        /// <item><description><b>Azure</b>: ClientId</description></item>
        /// <item><description><b>AWS</b>: AccessKeyId of the primary account</description></item>
        /// <item><description><b>VOLCENGINE</b>: AccessKeyId of the primary account</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>When AkType is set to sub:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKeyId of the sub-account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKeyId of the sub-account</description></item>
        /// <item><description><b>Azure</b>: ClientId</description></item>
        /// <item><description><b>AWS</b>: AccessKeyId of the sub-account</description></item>
        /// <item><description><b>VOLCENGINE</b>: AccessKeyId of the sub-account</description></item>
        /// <item><description><b>google</b>: private_key_id</description></item>
        /// </list>
        /// <remarks>
        /// <para>If AkType is set to <b>primary</b>, this value is the SecretID of the primary account on the third-party cloud. If AkType is set to <b>sub</b>, this value is the Access Key ID of the sub-account on the third-party cloud. For <b>Azure</b>, no distinction is made, and this value is the <b>appId</b> in the authentication information. Google Cloud is accessed through a service account. AkType defaults to sub, and this value is the private_key_id property value from the JSON-formatted service key file.</para>
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
        /// <para>The AK parameter secret. Valid values:</para>
        /// <ol>
        /// <item><description>When AkType is set to primary:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: SecretAccessKey of the primary account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: SecretAccessKey of the primary account</description></item>
        /// <item><description><b>Azure</b>: ClientSecret</description></item>
        /// <item><description><b>AWS</b>: SecretAccessKey of the primary account</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>When AkType is set to sub:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: SecretAccessKey of the sub-account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: SecretAccessKey of the sub-account</description></item>
        /// <item><description><b>Azure</b>: ClientSecret</description></item>
        /// <item><description><b>AWS</b>: SecretAccessKey of the sub-account</description></item>
        /// <item><description><b>google</b>: private_key<remarks>
        /// <para>If AkType is set to <b>primary</b>, this value is the Secret Access Key of the primary account on the third-party cloud. If AkType is set to <b>sub</b>, this value is the Secret Access Key of the sub-account on the third-party cloud. For <b>Azure</b>, no distinction is made, and this value is the <b>password</b> in the authentication information. Google Cloud is accessed through a service account. AkType defaults to sub, and this value is the private_key property value from the JSON-formatted service key file.</para>
        /// </remarks>
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
        /// <para>This parameter is no longer valid.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SubscriptionIds")]
        [Validation(Required=false)]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// <para>The tenant ID. This parameter is valid only when Vendor is set to Azure.</para>
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
        /// <item><description><b>CHAITIN</b>: Chaitin Technology</description></item>
        /// <item><description><b>FORTINET</b>: Fortinet</description></item>
        /// <item><description><b>THREATBOOK</b>: ThreatBook</description></item>
        /// <item><description><b>KingsoftCloud</b>: Kingsoft Cloud</description></item>
        /// <item><description><b>UCloud</b>: UCloud</description></item>
        /// <item><description><b>BaiduCloud</b>: Baidu AI Cloud</description></item>
        /// <item><description><b>WIZ</b>: Wiz Security</description></item>
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
        /// <para>The AK account name.</para>
        /// <remarks>
        /// <para>Used to identify the account to which third-party host assets belong.</para>
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
