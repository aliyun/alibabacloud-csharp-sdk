// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried launch templates.</para>
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
                /// <para>The time when the launch template was created.</para>
                /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-05-14T14:18:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that created the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("CreatedBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// <para>The time when the launch template was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DefaultVersionNumber")]
                [Validation(Required=false)]
                public long? DefaultVersionNumber { get; set; }

                /// <summary>
                /// <para>The tags of the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LatestVersionNumber")]
                [Validation(Required=false)]
                public long? LatestVersionNumber { get; set; }

                /// <summary>
                /// <para>The time when the launch template was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lt-m5e3ofjr1zn1aw7q****</para>
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// <para>The default version number of the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wd-152630748****</para>
                /// </summary>
                [NameInMap("LaunchTemplateName")]
                [Validation(Required=false)]
                public string LaunchTemplateName { get; set; }

                /// <summary>
                /// <para>The time when a version was added to or deleted from the launch template.</para>
                /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-05-14T14:18:00Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The creator of the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The tags of the launch template.</para>
                /// <remarks>
                /// <para> You can only call API operations to add tags to and query the tags of a launch template. You cannot add tags to or view the tags of a launch template in the ECS console.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTags Tags { get; set; }
                public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTagsTag> Tag { get; set; }
                    public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsLaunchTemplateSetTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag value of the launch template.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag key of the launch template.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The total number of launch templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE12CBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the launch templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
