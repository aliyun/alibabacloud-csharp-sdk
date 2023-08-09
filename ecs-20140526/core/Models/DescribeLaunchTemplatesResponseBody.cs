// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The information about the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateSets")]
        [Validation(Required=false)]
        public DescribeLaunchTemplatesResponseBodyLaunchTemplateSets LaunchTemplateSets { get; set; }
        public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSets : TeaModel {
            [NameInMap("LaunchTemplateSet")]
            [Validation(Required=false)]
            public List<DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSet> LaunchTemplateSet { get; set; }
            public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSet : TeaModel {
                /// <summary>
                /// The ID of the resource group to which the launch template belongs.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The latest version number of the launch template.
                /// </summary>
                [NameInMap("CreatedBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// The time when the launch template was modified.
                /// </summary>
                [NameInMap("DefaultVersionNumber")]
                [Validation(Required=false)]
                public long? DefaultVersionNumber { get; set; }

                /// <summary>
                /// The tags of the launch template.
                /// </summary>
                [NameInMap("LatestVersionNumber")]
                [Validation(Required=false)]
                public long? LatestVersionNumber { get; set; }

                /// <summary>
                /// The time when the launch template was created.
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// The default version number of the launch template.
                /// </summary>
                [NameInMap("LaunchTemplateName")]
                [Validation(Required=false)]
                public string LaunchTemplateName { get; set; }

                /// <summary>
                /// The ID of the launch template.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The creator of the launch template.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The tag of the launch template.
                /// </summary>
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

                        /// <summary>
                        /// The key of tag N of the launch template.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The total number of launch templates.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the launch templates.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
