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

        [NameInMap("CtdrCloudUserId")]
        [Validation(Required=false)]
        public string CtdrCloudUserId { get; set; }

        /// <summary>
        /// <para>The Active Directory (AD) domain. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>china</b></description></item>
        /// <item><description><b>global</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when Vendor is set to Azure.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

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
        /// <remarks>
        /// <para> This parameter takes effect only when Vendor is set to AWS. You can call the <a href="~~ListCloudVendorRegions~~">ListCloudVendorRegions</a> operation to query regions.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The AccessKey ID.</para>
        /// <remarks>
        /// <para> If AkType is set to <b>primary</b>, you must set SecretId to the AccessKey ID of the third-party master account. If AkType is set to <b>sub</b>, you must set SecretId to the AccessKey ID of the third-party sub-account. This parameter value does not change for a <b>Microsoft Azure account</b>. For an Azure account, set this parameter to the <b>app ID</b> that is used for authentication.</para>
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
