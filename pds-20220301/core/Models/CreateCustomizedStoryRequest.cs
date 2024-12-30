// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateCustomizedStoryRequest : TeaModel {
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
        /// </summary>
        [NameInMap("story_cover")]
        [Validation(Required=false)]
        public CreateCustomizedStoryRequestStoryCover StoryCover { get; set; }
        public class CreateCustomizedStoryRequestStoryCover : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63e5e4340f76cb3ead5f40f68163f0f967c1a7bf</para>
            /// </summary>
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>642a88d4aff041ee68fd4fc89beb80e1119da343</para>
            /// </summary>
            [NameInMap("revision_id")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("story_files")]
        [Validation(Required=false)]
        public List<CreateCustomizedStoryRequestStoryFiles> StoryFiles { get; set; }
        public class CreateCustomizedStoryRequestStoryFiles : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63e5e4340f76cb3ead5f40f68163f0f967c1a7bf</para>
            /// </summary>
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>642a88d4aff041ee68fd4fc89beb80e1119da343</para>
            /// </summary>
            [NameInMap("revision_id")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_created</para>
        /// </summary>
        [NameInMap("story_sub_type")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_created</para>
        /// </summary>
        [NameInMap("story_type")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

    }

}
