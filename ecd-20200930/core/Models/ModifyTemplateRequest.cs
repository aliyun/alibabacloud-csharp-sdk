// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyTemplateRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("DataDiskList")]
        [Validation(Required=false)]
        public List<ModifyTemplateRequestDataDiskList> DataDiskList { get; set; }
        public class ModifyTemplateRequestDataDiskList : TeaModel {
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("DefaultLanguage")]
        [Validation(Required=false)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>m-gx2x1dhsmusr2****</para>
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
        /// <b>Example:</b>
        /// <para>pg-gx2x1dhsmthe9****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("PostPaidAfterUsedUp")]
        [Validation(Required=false)]
        public bool? PostPaidAfterUsedUp { get; set; }

        [NameInMap("RegionConfigList")]
        [Validation(Required=false)]
        public List<ModifyTemplateRequestRegionConfigList> RegionConfigList { get; set; }
        public class ModifyTemplateRequestRegionConfigList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-709****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eds.enterprise_office.8c16g</para>
            /// </summary>
            [NameInMap("ResourceInstanceType")]
            [Validation(Required=false)]
            public string ResourceInstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sp-35fvn8m2*****</para>
            /// </summary>
            [NameInMap("SnapshotPolicyId")]
            [Validation(Required=false)]
            public string SnapshotPolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-adjrehad1****</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnable")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a7b3c0c8-b3a2-4876-b1cc-116dddc9****</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-a5fqjjqaejt***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceTagList")]
        [Validation(Required=false)]
        public List<ModifyTemplateRequestResourceTagList> ResourceTagList { get; set; }
        public class ModifyTemplateRequestResourceTagList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>design</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("SiteConfigList")]
        [Validation(Required=false)]
        public List<ModifyTemplateRequestSiteConfigList> SiteConfigList { get; set; }
        public class ModifyTemplateRequestSiteConfigList : TeaModel {
            [NameInMap("AppRuleId")]
            [Validation(Required=false)]
            public string AppRuleId { get; set; }

            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AutoPL</para>
        /// </summary>
        [NameInMap("SystemDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-0caoeogs88y*****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bcc-dweha*****</para>
        /// </summary>
        [NameInMap("TimerGroupId")]
        [Validation(Required=false)]
        public string TimerGroupId { get; set; }

        [NameInMap("UserDuration")]
        [Validation(Required=false)]
        public int? UserDuration { get; set; }

    }

}
