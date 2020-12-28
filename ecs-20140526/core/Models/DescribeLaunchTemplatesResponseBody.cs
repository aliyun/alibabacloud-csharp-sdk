// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplatesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("LaunchTemplateSets")]
        [Validation(Required=false)]
        public List<DescribeLaunchTemplatesResponseBodyLaunchTemplateSets> LaunchTemplateSets { get; set; }
        public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSets : TeaModel {
            [NameInMap("LaunchTemplateName")]
            [Validation(Required=false)]
            public string LaunchTemplateName { get; set; }

            [NameInMap("DefaultVersionNumber")]
            [Validation(Required=false)]
            public long? DefaultVersionNumber { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsTags> Tags { get; set; }
            public class DescribeLaunchTemplatesResponseBodyLaunchTemplateSetsTags : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("LatestVersionNumber")]
            [Validation(Required=false)]
            public long? LatestVersionNumber { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
