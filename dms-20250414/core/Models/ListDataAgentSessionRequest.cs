// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentSessionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1770912000000</para>
        /// </summary>
        [NameInMap("CreateEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1770825600000</para>
        /// </summary>
        [NameInMap("CreateStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ca-4y3ca4khkcu**********ysf</para>
        /// </summary>
        [NameInMap("CustomAgentId")]
        [Validation(Required=false)]
        public string CustomAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSaved")]
        [Validation(Required=false)]
        public bool? IsSaved { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>myFavorite</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20923*****7291</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
