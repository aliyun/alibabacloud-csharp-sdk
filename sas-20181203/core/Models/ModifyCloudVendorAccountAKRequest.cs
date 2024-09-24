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
        /// <para>The regions that are examined during AccessKey pair authentication. This parameter takes effect only when Vendor is set to AWS.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListCloudVendorRegions~~">ListCloudVendorRegions</a> operation to query regions.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The AccessKey ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S3D6c4O***</para>
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret. Valid values:</para>
        /// <para>1\. If AkType is set to primary, specify this parameter based on the following description:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Specify the AccessKey secret of a primary account on Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Specify the AccessKey secret of a primary account on Huawei Cloud.</description></item>
        /// <item><description><b>Azure</b>: Specify the AccessKey secret of a primary account on Microsoft Azure.</description></item>
        /// <item><description><b>AWS</b>: Specifythe AccessKey secret of a primary account on Amazon Web Services (AWS).</description></item>
        /// </list>
        /// <para>2\. If AkType is set to sub, specify this parameter based on the following description:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Specify the AccessKey secret of a sub-account on Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Specify the AccessKey secret of a sub-account on Huawei Cloud.</description></item>
        /// <item><description><b>Azure</b>: Specify the AccessKey secret of a sub-account on Microsoft Azure.</description></item>
        /// <item><description><b>AWS</b>: Specify the AccessKey secret of a sub-account on AWS.</description></item>
        /// </list>
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

    }

}
