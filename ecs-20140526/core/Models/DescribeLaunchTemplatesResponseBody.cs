// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplatesResponseBody : TeaModel {
        [NameInMap("LaunchTemplateSets")]
        [Validation(Required=false)]
        public DescribeLaunchTemplatesResponseBodyLaunchTemplateSets LaunchTemplateSets { get; set; }
        public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSets : TeaModel {
            [NameInMap("LaunchTemplateSet")]
            [Validation(Required=false)]
            public List<DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSet> LaunchTemplateSet { get; set; }
            public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSet : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreatedBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                [NameInMap("DefaultVersionNumber")]
                [Validation(Required=false)]
                public long? DefaultVersionNumber { get; set; }

                [NameInMap("LatestVersionNumber")]
                [Validation(Required=false)]
                public long? LatestVersionNumber { get; set; }

                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                [NameInMap("LaunchTemplateName")]
                [Validation(Required=false)]
                public string LaunchTemplateName { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTags Tags { get; set; }
                public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTagsTag> Tag { get; set; }
                    public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE12CBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of launch templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
