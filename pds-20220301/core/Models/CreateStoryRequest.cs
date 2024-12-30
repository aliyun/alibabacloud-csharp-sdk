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

        /// <term><b>Obsolete</b></term>
        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, string> CustomLabels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("max_image_count")]
        [Validation(Required=false)]
        public long? MaxImageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("min_image_count")]
        [Validation(Required=false)]
        public long? MinImageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-12-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("story_end_time")]
        [Validation(Required=false)]
        public string StoryEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9132e0d8-fe92-4e56-86c3-f5f112308003</para>
        /// </summary>
        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2016-12-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("story_start_time")]
        [Validation(Required=false)]
        public string StoryStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Food</para>
        /// </summary>
        [NameInMap("story_sub_type")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TagMemory</para>
        /// </summary>
        [NameInMap("story_type")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

    }

}
