// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SaveFavoritesRequest : TeaModel {
        /// <summary>
        /// <para>The user ID of the person who favorites the work. This user ID is the UserID of Quick BI, not the UID of Alibaba Cloud.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121344444790****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the work being favorited.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d23e84a1-82a0-4292-bfdb-521306c3****</para>
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
