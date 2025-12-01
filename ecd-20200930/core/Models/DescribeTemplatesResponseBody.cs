// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The modification result. If the request was successful, <c>success</c> is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The templates.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyData> Data { get; set; }
        public class DescribeTemplatesResponseBodyData : TeaModel {
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The sizes of the data disks.</para>
            /// </summary>
            [NameInMap("DataDiskList")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyDataDataDiskList> DataDiskList { get; set; }
            public class DescribeTemplatesResponseBodyDataDataDiskList : TeaModel {
                /// <summary>
                /// <para>The PL of the data disk.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL1: a PL1 ESSD.</description></item>
                /// <item><description>PL0: a PL0 ESSD.</description></item>
                /// <item><description>AutoPL: an AutoPL SSD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AutoPL</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the data disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <para>The default language of the template.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>en-US: English.</description></item>
            /// <item><description>zh-HK: Chinese, Traditional (Hong Kong, China).</description></item>
            /// <item><description>zh-CN: Simplified Chinese.</description></item>
            /// <item><description>ja-JP: Japanese.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("DefaultLanguage")]
            [Validation(Required=false)]
            public string DefaultLanguage { get; set; }

            /// <summary>
            /// <para>The template description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the template was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in Coordinated Universal Time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25T05:18:46.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the template was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25T05:18:46.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-5q8ehbihx*****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>User: a custom image.</description></item>
            /// <item><description>Shared: a shared image.</description></item>
            /// <item><description>System: a system image.</description></item>
            /// <item><description>Community: a community image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-0caoeogkhz*****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("PostPaidAfterUsedUp")]
            [Validation(Required=false)]
            public bool? PostPaidAfterUsedUp { get; set; }

            /// <summary>
            /// <para>The service type.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>CloudDesktop: cloud computers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The region-related settings.</para>
            /// </summary>
            [NameInMap("RegionConfigList")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyDataRegionConfigList> RegionConfigList { get; set; }
            public class DescribeTemplatesResponseBodyDataRegionConfigList : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                /// <summary>
                /// <para>The GPU memory information. This parameter is supported only by Graphics cloud computer types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4GiB</para>
                /// </summary>
                [NameInMap("GpuSpec")]
                [Validation(Required=false)]
                public string GpuSpec { get; set; }

                /// <summary>
                /// <para>The memory size. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public long? MemorySize { get; set; }

                /// <summary>
                /// <para>The office network ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing+dir-3040*****</para>
                /// </summary>
                [NameInMap("OfficeSiteId")]
                [Validation(Required=false)]
                public string OfficeSiteId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the cloud computer type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eds.enterprise_office.4c8g</para>
                /// </summary>
                [NameInMap("ResourceInstanceType")]
                [Validation(Required=false)]
                public string ResourceInstanceType { get; set; }

                /// <summary>
                /// <para>The snapshot policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-b9fasjuu0*****</para>
                /// </summary>
                [NameInMap("SnapshotPolicyId")]
                [Validation(Required=false)]
                public string SnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>The subnet ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-dgea1*****</para>
                /// </summary>
                [NameInMap("SubnetId")]
                [Validation(Required=false)]
                public string SubnetId { get; set; }

                /// <summary>
                /// <para>Indicates whether disk encryption is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("VolumeEncryptionEnable")]
                [Validation(Required=false)]
                public bool? VolumeEncryptionEnable { get; set; }

                /// <summary>
                /// <para>The ID of the Key Management Service (KMS) key that is used to encrypt the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3bc77be0-cbce-4a29-b07b-13f16394****</para>
                /// </summary>
                [NameInMap("VolumeEncryptionKey")]
                [Validation(Required=false)]
                public string VolumeEncryptionKey { get; set; }

            }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1871984F-51F6-5588-BAF6-******</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-a5fqjjqaejt***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags added to cloud computers. A tag is a key-value pair.</para>
            /// </summary>
            [NameInMap("ResourceTagList")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyDataResourceTagList> ResourceTagList { get; set; }
            public class DescribeTemplatesResponseBodyDataResourceTagList : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The property value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
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
            public List<DescribeTemplatesResponseBodyDataSiteConfigList> SiteConfigList { get; set; }
            public class DescribeTemplatesResponseBodyDataSiteConfigList : TeaModel {
                /// <summary>
                /// <para>应用管控策略ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>bwr-5a5371e0*******</para>
                /// </summary>
                [NameInMap("AppRuleId")]
                [Validation(Required=false)]
                public string AppRuleId { get; set; }

                /// <summary>
                /// <para>站点名称。</para>
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
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>PL1: a PL1 Enterprise SSD (ESSD).</description></item>
            /// <item><description>PL0: a PL0 ESSD.</description></item>
            /// <item><description>AutoPL: an AutoPL SSD.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoPL</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-0caoeogs88y*****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The template type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER_TEMPLATE: custom templates.</description></item>
            /// <item><description>SYSTEM_TEMPLATE: system templates.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER_TEMPLATE</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bcc-dweha*****</para>
            /// </summary>
            [NameInMap("TimerGroupId")]
            [Validation(Required=false)]
            public string TimerGroupId { get; set; }

            [NameInMap("UserDuration")]
            [Validation(Required=false)]
            public string UserDuration { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned. This parameter is not returned if the value of Code is <c>success</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1871984F-51F6-5588-BAF6-*******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
