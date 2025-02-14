// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCloudVendorAccountAKRequest : TeaModel {
        /// <summary>
        /// <para>The type of the account to which the AccessKey pair belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>primary</b>: a primary account</description></item>
        /// <item><description><b>sub</b>: a sub-account</description></item>
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
        /// <para>The modules that are associated with the AccessKey pair.</para>
        /// </summary>
        [NameInMap("AuthModules")]
        [Validation(Required=false)]
        public List<string> AuthModules { get; set; }

        /// <summary>
        /// <para>The Active Directory (AD) domain. This parameter takes effect only when Vendor is set to Azure. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>china</b></description></item>
        /// <item><description><b>global</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response messages. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The regions that are examined during AccessKey pair authentication. This parameter takes effect only when Vendor is set to AWS.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListCloudVendorRegions~~">ListCloudVendorRegions</a> operation to query regions.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The AccessKey ID. Valid values:</para>
        /// <para>1\. If AkType is set to primary, specify this parameter based on the following description:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Enter the AccessKey ID of a primary account on Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Enter the AccessKey ID of a primary account on Huawei Cloud.</description></item>
        /// <item><description><b>Azure</b>: Enter the AccessKey ID of a primary account on Microsoft Azure.</description></item>
        /// <item><description><b>AWS</b>: Enter the AccessKey ID of a primary account on AWS.</description></item>
        /// </list>
        /// <para>2\. If AkType is set to sub, specify this parameter based on the following description:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Enter the AccessKey ID of a sub-account on Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Enter the AccessKey ID of a sub-account on Huawei Cloud.</description></item>
        /// <item><description><b>Azure</b>: Enter the AccessKey ID of a sub-account on Microsoft Azure.</description></item>
        /// <item><description><b>AWS</b>: Enter the AccessKey ID of a sub-account on AWS.</description></item>
        /// </list>
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
        /// <para>1\. If AkType is set to primary, specify this parameter based on the following description:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Enter the AccessKey secret of a primary account on Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Enter the AccessKey secret of a primary account on Huawei Cloud.</description></item>
        /// <item><description><b>Azure</b>: Enter the AccessKey secret of a primary account on Microsoft Azure.</description></item>
        /// <item><description><b>AWS</b>: Enter the AccessKey secret of a primary account on AWS.</description></item>
        /// </list>
        /// <para>2\. If AkType is set to sub, specify this parameter based on the following description:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Enter the AccessKey secret of a sub-account on Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Enter the AccessKey secret of a sub-account on Huawei Cloud.</description></item>
        /// <item><description><b>Azure</b>: Enter the AccessKey secret of a sub-account on Microsoft Azure.</description></item>
        /// <item><description><b>AWS</b>: Enter the AccessKey secret of a sub-account on AWS.</description></item>
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
        /// <para>The subscription IDs. This parameter takes effect only when Vendor is set to Azure.</para>
        /// </summary>
        [NameInMap("SubscriptionIds")]
        [Validation(Required=false)]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// <para>The tenant ID. This parameter takes effect only when Vendor is set to Azure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95304a97-339b-4de5-9a7d-cdbffaf****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The cloud service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud</description></item>
        /// <item><description><b>Azure</b>: Microsoft Azure</description></item>
        /// <item><description><b>AWS</b>: Amazon Web Services (AWS)</description></item>
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
