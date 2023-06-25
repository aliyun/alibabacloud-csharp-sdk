// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateCustomizedStoryRequest : TeaModel {
        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> CustomLabels { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("story_cover")]
        [Validation(Required=false)]
        public CreateCustomizedStoryRequestStoryCover StoryCover { get; set; }
        public class CreateCustomizedStoryRequestStoryCover : TeaModel {
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("revision_id")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

        [NameInMap("story_files")]
        [Validation(Required=false)]
        public List<CreateCustomizedStoryRequestStoryFiles> StoryFiles { get; set; }
        public class CreateCustomizedStoryRequestStoryFiles : TeaModel {
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("revision_id")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        [NameInMap("story_sub_type")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        [NameInMap("story_type")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

    }

}
