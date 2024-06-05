// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateStoryRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public Address Address { get; set; }

        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> CustomLabels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("max_image_count")]
        [Validation(Required=false)]
        public long? MaxImageCount { get; set; }

        [NameInMap("min_image_count")]
        [Validation(Required=false)]
        public long? MinImageCount { get; set; }

        [NameInMap("story_end_time")]
        [Validation(Required=false)]
        public string StoryEndTime { get; set; }

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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("story_type")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

    }

}
