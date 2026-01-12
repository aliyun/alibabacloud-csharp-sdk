// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetConversationsRequest : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>GetConversations</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77be60cd-237b-4ca9-9c46-48b663cb****</para>
        /// </summary>
        [NameInMap("LastId")]
        [Validation(Required=false)]
        public string LastId { get; set; }

        /// <summary>
        /// <para>The ID of the last conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Pinned")]
        [Validation(Required=false)]
        public string Pinned { get; set; }

        /// <summary>
        /// <para>Specifies whether to pin the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreatedAt</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
