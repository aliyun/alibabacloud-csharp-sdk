// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyData> Data { get; set; }
        public class DescribeTemplatesResponseBodyData : TeaModel {
            [NameInMap("DataDiskList")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyDataDataDiskList> DataDiskList { get; set; }
            public class DescribeTemplatesResponseBodyDataDataDiskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AutoPL</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("DefaultLanguage")]
            [Validation(Required=false)]
            public string DefaultLanguage { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-25T05:18:46.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-25T05:18:46.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>m-5q8ehbihx*****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pg-0caoeogkhz*****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("RegionConfigList")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyDataRegionConfigList> RegionConfigList { get; set; }
            public class DescribeTemplatesResponseBodyDataRegionConfigList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4GiB</para>
                /// </summary>
                [NameInMap("GpuSpec")]
                [Validation(Required=false)]
                public string GpuSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public long? MemorySize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing+dir-3040*****</para>
                /// </summary>
                [NameInMap("OfficeSiteId")]
                [Validation(Required=false)]
                public string OfficeSiteId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eds.enterprise_office.4c8g</para>
                /// </summary>
                [NameInMap("ResourceInstanceType")]
                [Validation(Required=false)]
                public string ResourceInstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sp-b9fasjuu0*****</para>
                /// </summary>
                [NameInMap("SnapshotPolicyId")]
                [Validation(Required=false)]
                public string SnapshotPolicyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-dgea1*****</para>
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
                /// <para>3bc77be0-cbce-4a29-b07b-13f16394****</para>
                /// </summary>
                [NameInMap("VolumeEncryptionKey")]
                [Validation(Required=false)]
                public string VolumeEncryptionKey { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1871984F-51F6-5588-BAF6-******</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-a5fqjjqaejt***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceTagList")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyDataResourceTagList> ResourceTagList { get; set; }
            public class DescribeTemplatesResponseBodyDataResourceTagList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("SiteConfigList")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyDataSiteConfigList> SiteConfigList { get; set; }
            public class DescribeTemplatesResponseBodyDataSiteConfigList : TeaModel {
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
            /// <para>USER_TEMPLATE</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bcc-dweha*****</para>
            /// </summary>
            [NameInMap("TimerGroupId")]
            [Validation(Required=false)]
            public string TimerGroupId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1871984F-51F6-5588-BAF6-*******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
