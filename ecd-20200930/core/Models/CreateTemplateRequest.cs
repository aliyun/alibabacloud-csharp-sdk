// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic payment is enabled for the subscription order.</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the subscription shared cloud desktop.</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The size and specification configurations of the data cloud disk.</para>
        /// </summary>
        [NameInMap("DataDiskList")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestDataDiskList> DataDiskList { get; set; }
        public class CreateTemplateRequestDataDiskList : TeaModel {
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
            /// <remarks>
            /// <para>Notice: The larger the capacity of a standard SSD, the higher the performance level (PL) that you can select. For example, you can select PL2 for a standard SSD with a capacity of 460 GiB or larger. A higher PL incurs higher costs. Select an appropriate PL based on your business requirements.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The default language configured when the cloud desktop starts. This parameter takes effect only when you use a system image to create a cloud desktop.</para>
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
        /// <item><description>The description must be 2 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain Chinese characters, English letters, digits, spaces, and special characters, and supports line breaks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Design department template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the cloud desktop image. You can query the image ID on the Images page. System images and custom images are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktopimage-windows-server-2022-64-asp</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myHost</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The subscription duration of the shared cloud desktop. This parameter is required and takes effect only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>. The unit is specified by the <c>PeriodUnit</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the <c>PeriodUnit</c> parameter is set to <c>Month</c>, valid values are:<list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If the <c>PeriodUnit</c> parameter is set to <c>Year</c>, valid values are:<list type="bullet">
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
        /// <para>The time unit of the subscription Billable methods.</para>
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
        /// <para>pg-8hlryfn331******</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically switch to the pay-as-you-go billing method after the usage duration plan is exhausted.</para>
        /// </summary>
        [NameInMap("PostPaidAfterUsedUp")]
        [Validation(Required=false)]
        public bool? PostPaidAfterUsedUp { get; set; }

        /// <summary>
        /// <para>The product type. Set the value to <c>CloudDesktop</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDesktop</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The region-specific template configurations. You can configure multiple regions. The configurations are matched based on the specific region when the template is used.</para>
        /// <remarks>
        /// <para>You can configure up to 20 regions.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RegionConfigList")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestRegionConfigList> RegionConfigList { get; set; }
        public class CreateTemplateRequestRegionConfigList : TeaModel {
            /// <summary>
            /// <para>The ID of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-709******</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions supported by WUYING Workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop specification.</para>
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
            /// <para>The ID of the subnet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1yiu**********</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual node pool. This parameter is used in workstation scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vnp-0bydg********</para>
            /// </summary>
            [NameInMap("VirtualNodePoolId")]
            [Validation(Required=false)]
            public string VirtualNodePoolId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable cloud disk encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnable")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnable { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key used when cloud disk encryption is enabled. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to obtain the key ID.</para>
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
        /// <para>The tags of the cloud desktop. The tags are in key-value pairs. You can specify up to 20 tags.</para>
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
        /// <para>Site configuration management.</para>
        /// </summary>
        [NameInMap("SiteConfigList")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestSiteConfigList> SiteConfigList { get; set; }
        public class CreateTemplateRequestSiteConfigList : TeaModel {
            /// <summary>
            /// <para>The ID of the application control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bwr-5a5371e0db954d********</para>
            /// </summary>
            [NameInMap("AppRuleId")]
            [Validation(Required=false)]
            public string AppRuleId { get; set; }

            /// <summary>
            /// <para>The site ID.</para>
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
        /// <para>Only cloud desktops with high clock speeds or GPU-accelerated specifications support ESSDs.</para>
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
        /// <para>The size of the system cloud disk cannot be smaller than the size of the configured image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The name of the template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 126 characters in length.</description></item>
        /// <item><description>The name must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The name can contain letters, digits, Chinese characters, colons (:), underscores (_), and hyphens (-), but cannot contain periods (.).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My cloud desktop template 001</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The ID of the configuration group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-0caoeogrk9m5****</para>
        /// </summary>
        [NameInMap("TimerGroupId")]
        [Validation(Required=false)]
        public string TimerGroupId { get; set; }

        /// <summary>
        /// <para>The usage duration plan for a single user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("UserDuration")]
        [Validation(Required=false)]
        public int? UserDuration { get; set; }

    }

}
