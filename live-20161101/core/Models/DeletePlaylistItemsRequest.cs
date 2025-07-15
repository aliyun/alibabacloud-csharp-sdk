// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeletePlaylistItemsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the episode list. If the episode list was created by calling the <a href="https://help.aliyun.com/document_detail/2848078.html">AddPlaylistItems</a> operation, check the value of the response parameter ProgramId to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The IDs of the episodes that you want to remove.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;c09f3d63-eacf-4fbf-bd48-a07a6ba7****&quot;,&quot;c10f3d63-eacf-4fbf-bd48-a07a6ba7****&quot;]</para>
        /// </summary>
        [NameInMap("ProgramItemIds")]
        [Validation(Required=false)]
        public string ProgramItemIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
