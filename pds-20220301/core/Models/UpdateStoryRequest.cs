// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateStoryRequest : TeaModel {
        [NameInMap("cover")]
        [Validation(Required=false)]
        public UpdateStoryRequestCover Cover { get; set; }
        public class UpdateStoryRequestCover : TeaModel {
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("revision_id")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> CustomLabels { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

    }

}
