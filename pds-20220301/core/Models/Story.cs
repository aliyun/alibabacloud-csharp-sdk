// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Story : TeaModel {
        [NameInMap("cover_file_id")]
        [Validation(Required=false)]
        public string CoverFileId { get; set; }

        [NameInMap("cover_file_thumbnail_url")]
        [Validation(Required=false)]
        public string CoverFileThumbnailUrl { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        [NameInMap("face_group_ids")]
        [Validation(Required=false)]
        public List<string> FaceGroupIds { get; set; }

        [NameInMap("story_end_time")]
        [Validation(Required=false)]
        public string StoryEndTime { get; set; }

        [NameInMap("story_file_list")]
        [Validation(Required=false)]
        public List<File> StoryFileList { get; set; }

        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        [NameInMap("story_start_time")]
        [Validation(Required=false)]
        public string StoryStartTime { get; set; }

        [NameInMap("story_sub_type")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        [NameInMap("story_type")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
