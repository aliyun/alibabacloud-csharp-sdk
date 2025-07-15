// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListPlaylistRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the episode list. If you set this parameter, only the information about the specified episode lists is returned. If you do not set this parameter, the information about all episode lists that belong to the account is returned. If the episode list was created by calling the <a href="https://help.aliyun.com/document_detail/2848078.html">AddPlaylistItems</a> operation, check the value of the response parameter ProgramId to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c09f3d63-eacf-4fbf-bd48-a07a6ba7****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
