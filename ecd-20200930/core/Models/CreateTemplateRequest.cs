// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateTemplateRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: the Enterprise edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The data disks.</para>
        /// </summary>
        [NameInMap("DataDiskList")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestDataDiskList> DataDiskList { get; set; }
        public class CreateTemplateRequestDataDiskList : TeaModel {
            /// <summary>
            /// <para>The PL of the data disk. Default value: <c>AutoPL</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AutoPL</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the data disk. Unit: GiB. Valid values: 40 to 2040. Increments: 10 GiB.</para>
            /// <para>**</para>
            /// <para><b>Keep in mind</b> that the larger the ESSD disk capacity, the higher the available PL (for example, PL2 is available for disks larger than 460 GiB). A higher PL comes with a higher cost. Select an ESSD based on your specific needs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The default language of cloud computers during startup. This parameter takes effect only when cloud computers are created from system images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("DefaultLanguage")]
        [Validation(Required=false)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// <para>The template description. It must meet the following criteria:</para>
        /// <list type="bullet">
        /// <item><description>It can be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It can contain letters, digits, and special characters, including spaces. Note: You can use carriage returns to break lines.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer image. You can query image IDs on the Images page. System images and custom images are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktopimage-windows-server-2022-64-asp</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the policy group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-8hlryfn331******</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("PostPaidAfterUsedUp")]
        [Validation(Required=false)]
        public bool? PostPaidAfterUsedUp { get; set; }

        /// <summary>
        /// <para>The service type. Set the value to <c>CloudDesktop</c>.</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDesktop</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The regions of the template. You can create cloud computers by using a template only within the same region as the template itself.</para>
        /// <remarks>
        /// <para> You can specify up to 20 regions.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RegionConfigList")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestRegionConfigList> RegionConfigList { get; set; }
        public class CreateTemplateRequestRegionConfigList : TeaModel {
            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-709******</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the cloud computer type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.enterprise_office.8c16g</para>
            /// </summary>
            [NameInMap("ResourceInstanceType")]
            [Validation(Required=false)]
            public string ResourceInstanceType { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-35fvn8m21pnx2****</para>
            /// </summary>
            [NameInMap("SnapshotPolicyId")]
            [Validation(Required=false)]
            public string SnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The subnet ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1yiu**********</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable disk encryption.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false (default): disables disk encryption.</description></item>
            /// <item><description>true: enables disk encryption.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnable")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnable { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key that you want to use to encrypt disks. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to query KMS keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7b3c0c8-b3a2-4876-b1cc-*********</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4knxmfneq1e******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags added to cloud computers. Specify tags in key-value pairs. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("ResourceTagList")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestResourceTagList> ResourceTagList { get; set; }
        public class CreateTemplateRequestResourceTagList : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>design</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>区域配置管理</para>
        /// </summary>
        [NameInMap("SiteConfigList")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestSiteConfigList> SiteConfigList { get; set; }
        public class CreateTemplateRequestSiteConfigList : TeaModel {
            /// <summary>
            /// <para>应用管控策略ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>bwr-5a5371e0db954d********</para>
            /// </summary>
            [NameInMap("AppRuleId")]
            [Validation(Required=false)]
            public string AppRuleId { get; set; }

            /// <summary>
            /// <para>站点ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>mainland</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

        }

        /// <summary>
        /// <para>The performance level (PL) of the system disk.</para>
        /// <remarks>
        /// <para> Only cloud computers of the Graphics or High Frequency type support Enterprise SSDs (ESSDs).</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL1: a PL1 ESSD.</description></item>
        /// <item><description>PL0: a PL0 ESSD.</description></item>
        /// <item><description>AutoPL: an AutoPL ESSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoPL</para>
        /// </summary>
        [NameInMap("SystemDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of the system disk. Unit: GiB. Valid values: 40 to 500. Increments: 10 GiB.</para>
        /// <remarks>
        /// <para> The system disk size must be at least as large as the configured image size.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The template name. It must meet the following criteria:</para>
        /// <list type="bullet">
        /// <item><description>It can be 2 to 126 characters in length.</description></item>
        /// <item><description>It must begin with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It can contain letters, digits, colons (:), underscores (_), and hyphens (-). Note: Periods (.) are not supported in the name.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-0caoeogrk9m5****</para>
        /// </summary>
        [NameInMap("TimerGroupId")]
        [Validation(Required=false)]
        public string TimerGroupId { get; set; }

        [NameInMap("UserDuration")]
        [Validation(Required=false)]
        public int? UserDuration { get; set; }

    }

}
