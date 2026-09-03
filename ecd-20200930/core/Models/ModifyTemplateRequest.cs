// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic payment is enabled for the subscription order.</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the subscription cloud computer.</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The system cloud disk performance level.</para>
        /// </summary>
        [NameInMap("DataDiskList")]
        [Validation(Required=false)]
        public List<ModifyTemplateRequestDataDiskList> DataDiskList { get; set; }
        public class ModifyTemplateRequestDataDiskList : TeaModel {
            /// <summary>
            /// <para>The performance level of the data cloud disk. Default value: <c>AutoPL</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AutoPL</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the data cloud disk. Unit: GiB. Valid values: 40 to 2040. The value must be a multiple of 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The default language that is set when the cloud computer starts. This parameter takes effect only when a system image is used to create the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("DefaultLanguage")]
        [Validation(Required=false)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// <para>The description of the template. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain Chinese characters, letters, digits, spaces, and special characters. Line breaks are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer image. You can query the ID on the Image Management page. System images and custom images are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-gx2x1dhsmusr2****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The subscription duration of the subscription cloud computer. This parameter takes effect and is required only when <c>ChargeType</c> is set to <c>PrePaid</c>. The unit is specified by <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values:<list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values:<list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>4</description></item>
        /// <item><description>5</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration for the subscription billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the global policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-gx2x1dhsmthe9****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically switch to pay-as-you-go billing after the duration plan is used up.</para>
        /// </summary>
        [NameInMap("PostPaidAfterUsedUp")]
        [Validation(Required=false)]
        public bool? PostPaidAfterUsedUp { get; set; }

        /// <summary>
        /// <para>The region-specific template configurations. You can specify multiple configurations. The configuration that matches the specific region is used.</para>
        /// <remarks>
        /// <para>You can specify configurations for up to 20 regions.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RegionConfigList")]
        [Validation(Required=false)]
        public List<ModifyTemplateRequestRegionConfigList> RegionConfigList { get; set; }
        public class ModifyTemplateRequestRegionConfigList : TeaModel {
            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-709****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the list of regions supported by Elastic Desktop Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The cloud computer specification ID.</para>
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
            /// <para>sp-35fvn8m2*****</para>
            /// </summary>
            [NameInMap("SnapshotPolicyId")]
            [Validation(Required=false)]
            public string SnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The subnet ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-adjrehad1****</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable disk encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnable")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnable { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used when disk encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7b3c0c8-b3a2-4876-b1cc-116dddc9****</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-a5fqjjqaejt***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the cloud computer in key-value format. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("ResourceTagList")]
        [Validation(Required=false)]
        public List<ModifyTemplateRequestResourceTagList> ResourceTagList { get; set; }
        public class ModifyTemplateRequestResourceTagList : TeaModel {
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
        /// <para>The site configuration management.</para>
        /// </summary>
        [NameInMap("SiteConfigList")]
        [Validation(Required=false)]
        public List<ModifyTemplateRequestSiteConfigList> SiteConfigList { get; set; }
        public class ModifyTemplateRequestSiteConfigList : TeaModel {
            /// <summary>
            /// <para>The application control policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bwr-5a5371e0*******</para>
            /// </summary>
            [NameInMap("AppRuleId")]
            [Validation(Required=false)]
            public string AppRuleId { get; set; }

            /// <summary>
            /// <para>The site name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mainland</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

        }

        /// <summary>
        /// <para>The type of the system cloud disk.</para>
        /// <remarks>
        /// <para>Only high frequency and graphics cloud computer specifications support ESSD cloud disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AutoPL</para>
        /// </summary>
        [NameInMap("SystemDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk. Unit: GiB. Valid values: 40 to 500. The value must be a multiple of 10.</para>
        /// <remarks>
        /// <para>The system cloud disk size cannot be smaller than the size of the configured image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-0caoeogs88y*****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 126 characters in length.</description></item>
        /// <item><description>The name must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The name can contain letters, digits, Chinese characters, colons (:), underscores (_), or hyphens (-). Periods (.) are not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MyCloudComputerTemplate001</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The configuration group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bcc-dweha*****</para>
        /// </summary>
        [NameInMap("TimerGroupId")]
        [Validation(Required=false)]
        public string TimerGroupId { get; set; }

        /// <summary>
        /// <para>The per-user usage duration plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("UserDuration")]
        [Validation(Required=false)]
        public int? UserDuration { get; set; }

    }

}
