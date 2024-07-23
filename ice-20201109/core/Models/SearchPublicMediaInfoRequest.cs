// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchPublicMediaInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Authorized")]
        [Validation(Required=false)]
        public bool? Authorized { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ApprovalStatus=\&quot;Available\&quot;&amp;MaterialBags=\&quot;boutiquemusic\&quot;&amp;Mood=\&quot;Nervous\&quot;&quot;</para>
        /// </summary>
        [NameInMap("DynamicMetaDataMatchFields")]
        [Validation(Required=false)]
        public string DynamicMetaDataMatchFields { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Copyright_Music</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Favorite")]
        [Validation(Required=false)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b>,<b><b>15d4a4b0448391508f2cb486</b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UsageCount:Desc,UnitPrice:Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
