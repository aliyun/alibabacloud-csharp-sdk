// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListPlaylistItemsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the playlist. You can obtain the ID from the ProgramId parameter in the response of the <a href="https://help.aliyun.com/document_detail/2848078.html">AddPlaylistItems</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The IDs of the playlist items. Separate multiple IDs with commas (,). If you specify this parameter, only the information about the specified items is returned. If you leave this parameter empty, the information about all items in the playlist is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c10f3d63-eacf-4fbf-bd48-a07a6ba7****,c09f3d63-eacf-4fbf-bd48-a07a6ba7****</para>
        /// </summary>
        [NameInMap("ProgramItemIds")]
        [Validation(Required=false)]
        public string ProgramItemIds { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
