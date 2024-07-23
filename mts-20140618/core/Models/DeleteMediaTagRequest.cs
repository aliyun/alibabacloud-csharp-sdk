// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class DeleteMediaTagRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media file for which you want to remove a tag. To obtain the ID of a media file, you can call the <a href="https://help.aliyun.com/document_detail/44458.html">AddMedia</a> operation. Alternatively, perform the following operations in the ApsaraVideo Media Processing (MPS) console: In the left-side navigation pane, choose <b>Media Management</b> &gt; <b>Media List</b>. Find the required video and click <b>Manage</b> in the Actions column. The ID of the video is displayed on the Basics tab.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e6149d5a8c944c09b1a8d2dc3e4****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The media tag that you want to remove. The value is encoded in UTF-8 and can be up to 32 bytes in length.</para>
        /// <remarks>
        /// <para>You can remove only one tag at a time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tag1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
