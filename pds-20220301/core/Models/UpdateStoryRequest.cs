// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateStoryRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("cover")]
        [Validation(Required=false)]
        public UpdateStoryRequestCover Cover { get; set; }
        public class UpdateStoryRequestCover : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>63e5e4340f76cb3ead5f40f68163f0f967c1a7bf</para>
            /// </summary>
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>642a88dd06e49d9c0a14411ebae606f70edd9a59</para>
            /// </summary>
            [NameInMap("revision_id")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9132e0d8-fe92-4e56-86c3-f5f112308003</para>
        /// </summary>
        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

    }

}
