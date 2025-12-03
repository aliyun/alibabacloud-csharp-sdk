// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetConversationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-iBuGU1VxEY42zrQRQfNA****</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>77be60cd-237b-4ca9-9c46-48b663cb****</para>
        /// </summary>
        [NameInMap("LastId")]
        [Validation(Required=false)]
        public string LastId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Pinned")]
        [Validation(Required=false)]
        public string Pinned { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreatedAt</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
