// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCloudVendorAccountAKRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the AccessKey pair.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCloudVendorAccountAKList~~">DescribeCloudVendorAccountAKList</a> operation to obtain this parameter.</para>
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
        /// <para>The list of module codes associated with the AccessKey pair. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HOST</b>: host</description></item>
        /// <item><description><b>CSPM</b>: cloud product configuration check</description></item>
        /// <item><description><b>SIEM</b>: Cloud Threat Detection and Response (CTDR)</description></item>
        /// <item><description><b>TRIAL</b>: log audit<remarks>
        /// <para>Call the <a href="~~GetSupportedModules~~">GetSupportedModules</a> operation to obtain the supported modules.</para>
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
        /// <para>The domain of the connected account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>china</b>: China</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// <item><description><b>europe</b>: Huawei Cloud Europe</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when <b>Vendor</b> is set to <b>HUAWEICLOUD</b>, <b>Azure</b>, <b>AWS</b>, or <b>VOLCENGINE</b>, and is required.</para>
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
        /// <para>Used to store extended information for different vendors.
        /// Google Cloud is accessed through a service account. ExtendInfo stores the JSON-formatted service key file, excluding the private_key_id and zprivate_key fields. The file contains the following fields: type, project_id, client_email, client_id, auth_uri, token_uri, auth_provider_x509_cert_url, client_x509_cert_url, and universe_domain.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;product\&quot;:\&quot;webFirewall\&quot;,\&quot;remark\&quot;:\&quot;remark\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The language type for the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The list of regions used for AccessKey information verification.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The AccessKey parameter ID. Valid values:</para>
        /// <ol>
        /// <item><description>If AkType is set to primary:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKeyId of the primary account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKeyId of the primary account</description></item>
        /// <item><description><b>Azure</b>: ClientId</description></item>
        /// <item><description><b>AWS</b>: AccessKeyId of the primary account</description></item>
        /// <item><description><b>VOLCENGINE</b>: AccessKeyId of the primary account</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>If AkType is set to sub:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKeyId of the RAM user</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKeyId of the RAM user</description></item>
        /// <item><description><b>Azure</b>: ClientId</description></item>
        /// <item><description><b>AWS</b>: AccessKeyId of the RAM user</description></item>
        /// <item><description><b>VOLCENGINE</b>: AccessKeyId of the RAM user</description></item>
        /// <item><description><b>google</b>: private_key_id</description></item>
        /// </list>
        /// <remarks>
        /// <para>If AkType is set to <b>primary</b>, this value is the SecretID of the primary account on the third-party cloud. If AkType is set to <b>sub</b>, this value is the Access Key ID of the RAM user on the third-party cloud. For <b>Azure</b>, no distinction is made, and this value is the <b>appId</b> of the authentication information. Google Cloud is accessed through a service account. AkType is set to sub by default, and this value is the private_key_id property value from the JSON-formatted service key file.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>S3D6c4O***</para>
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// <para>The AccessKey parameter secret.</para>
        /// <remarks>
        /// <para>If AkType is set to <b>primary</b>, this value is the Secret Access Key of the primary account on the third-party cloud. If AkType is set to <b>sub</b>, this value is the Secret Access Key of the RAM user on the third-party cloud. For <b>Azure</b>, no distinction is made, and this value is the <b>password</b> of the authentication information. Google Cloud is accessed through a service account. AkType is set to sub by default, and this value is the private_key property value from the JSON-formatted service key file.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AE6SLd****</para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>The usage status of the AccessKey pair. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: enabled</description></item>
        /// <item><description><b>1</b>: disabled.</description></item>
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
        /// <para>This parameter is no longer valid.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SubscriptionIds")]
        [Validation(Required=false)]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para>This parameter is valid only when Vendor is set to Azure.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>95304a97-339b-4de5-9a7d-cdbffaf****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The name of the AccessKey account.</para>
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
