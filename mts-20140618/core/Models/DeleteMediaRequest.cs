// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class DeleteMediaRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the media files that you want to remove. Separate multiple IDs with commas (,). You can remove up to 10 media files at a time.</para>
        /// <remarks>
        /// <para>You can obtain the ID of the media file from the response parameters of the <a href="https://help.aliyun.com/document_detail/44458.html">AddMedia</a> operation. Alternatively, you can log on to the MPS console. In the left-side navigation pane, choose <b>Media Management</b> &gt; <b>Media List</b>. Find the required video and click <b>Manage</b> in the Actions column. The ID of the video is displayed on the Basics tab.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e1cd21131a94525be55acf65888****,3e6149d5a8c944c09b1a8d2dc3e4****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

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

    }

}
