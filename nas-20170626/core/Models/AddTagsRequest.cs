// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class AddTagsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0addcw****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The details about the tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddTagsRequestTag> Tag { get; set; }
        public class AddTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of each tag. A tag consists of a tag key and a tag value. You can add a maximum of 10 tags at a time. The tag key cannot be empty. The tag value can be left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keyN</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of each tag. A tag consists of a tag key and a tag value. You can add a maximum of 10 tags at a time. The tag key cannot be empty. The tag value can be left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>valueN</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
