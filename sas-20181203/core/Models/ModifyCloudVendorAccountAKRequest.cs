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
        /// <para> You can call the <a href="~~DescribeCloudVendorAccountAKList~~">DescribeCloudVendorAccountAKList</a> operation to query the unique ID.</para>
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
        /// <para>The modules that are associated with the AccessKey pair. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HOST</b>: host.</description></item>
        /// <item><description><b>CSPM</b>: configuration assessment.</description></item>
        /// <item><description><b>SIEM</b>: Cloud Threat Detection and Response (CTDR).</description></item>
        /// <item><description><b>TRIAL</b>: log audit.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~GetSupportedModules~~">GetSupportedModules</a> operation to query the supported modules.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AuthModules")]
        [Validation(Required=false)]
        public List<string> AuthModules { get; set; }

        /// <summary>
        /// <para>Account ID.</para>
        /// <remarks>
        /// <para>The account ID of the connected cloud vendor, required when the permission description includes threat analysis and response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>azure_demo_1</para>
        /// </summary>
        [NameInMap("CtdrCloudUserId")]
        [Validation(Required=false)]
        public string CtdrCloudUserId { get; set; }

        /// <summary>
        /// <para>Access account domain. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>china</b>: China</description></item>
        /// <item><description><b>global</b>: Global </description></item>
        /// <item><description><b>europe</b>: Huawei Europe<remarks>
        /// <para>This parameter is only valid and required for <b>Vendor</b> being <b>HUAWEICLOUD</b>, <b>Azure</b>, <b>AWS</b>, or <b>VOLCENGINE</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Extended information.</para>
        /// <remarks>
        /// <para>Used to record extended information from different vendors.
        /// For Google Cloud, which is accessed through a service account, ExtendInfo stores a JSON-formatted service key file, excluding the private_key_id and zprivate_key fields. The file includes the following fields: type, project_id, client_email, client_id, auth_uri, token_uri, auth_provider_x509_cert_url, client_x509_cert_url, universe_domain.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;product\&quot;:\&quot;webFirewall\&quot;,\&quot;remark\&quot;:\&quot;remark\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
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
        /// <para>The regions that are examined during AccessKey pair authentication.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>ID of the AK parameter. Values:</para>
        /// <ol>
        /// <item><description>When AkType is primary:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: AccessKeyId of the main account</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: AccessKeyId of the main account</description></item>
        /// <item><description><b>Azure</b>: ClientId</description></item>
        /// <item><description><b>AWS</b>: AccessKeyId of the main account</description></item>
        /// <item><description><b>VOLCENGINE</b>: AccessKeyId of the main account</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>When AkType is sub:</description></item>
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
        /// <para>If AkType is <b>primary</b>, this value is the SecretID of the main account from another cloud. If AkType is <b>sub</b>, this value is the Access Key ID of the sub-account from another cloud. For <b>Azure</b>, there is no distinction, and this value is the <b>appId</b> of the authentication information. Google Cloud is accessed through a service account, with AkType defaulting to sub, and this value is taken from the private_key_id attribute in the JSON format service key file.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>S3D6c4O***</para>
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret.</para>
        /// <remarks>
        /// <para> If AkType is set to <b>primary</b>, you must set SecretKey to the AccessKey secret of the third-party master account. If AkType is set to <b>sub</b>, you must set SecretKey to the AccessKey secret of the third-party sub-account. This parameter value does not change for a <b>Microsoft Azure account</b>. For an Azure account, set this parameter to the <b>password</b> that is used for authentication.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AE6SLd****</para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// <para>The status of the AccessKey pair. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: enabled.</description></item>
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
        /// <para>The IDs of subscriptions.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when Vendor is set to Azure.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SubscriptionIds")]
        [Validation(Required=false)]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when Vendor is set to Azure.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>95304a97-339b-4de5-9a7d-cdbffaf****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The name of the AccessKey pair.</para>
        /// <remarks>
        /// <para> The account information of the third-party cloud servers.</para>
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
