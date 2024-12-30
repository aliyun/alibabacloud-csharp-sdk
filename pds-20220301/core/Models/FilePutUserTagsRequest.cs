// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FilePutUserTagsRequest : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9520943DC264</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The tags to be added to the file. You cannot leave this parameter empty. You can specify up to 1,000 tags. You cannot specify tags that have the same name.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public List<FilePutUserTagsRequestUserTags> UserTags { get; set; }
        public class FilePutUserTagsRequestUserTags : TeaModel {
            /// <summary>
            /// <para>The name of the tag. The tag name cannot be empty and cannot contain number signs (#).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The tag value cannot contain number signs (#).</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
