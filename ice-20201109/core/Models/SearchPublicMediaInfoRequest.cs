// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchPublicMediaInfoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the user has purchased a resource plan that includes this media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Authorized")]
        [Validation(Required=false)]
        public bool? Authorized { get; set; }

        /// <summary>
        /// <para>The dynamic metadata search matching conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ApprovalStatus=\&quot;Available\&quot;&amp;MaterialBags=\&quot;boutiquemusic\&quot;&amp;Mood=\&quot;Nervous\&quot;&quot;</para>
        /// </summary>
        [NameInMap("DynamicMetaDataMatchFields")]
        [Validation(Required=false)]
        public string DynamicMetaDataMatchFields { get; set; }

        /// <summary>
        /// <para>The entity ID that identifies different types of public copyright media assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Copyright_Music: public copyright music</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Copyright_Music</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>Specifies whether the user has added the media asset to favorites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Favorite")]
        [Validation(Required=false)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// <para>The IMS media asset IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b>,<b><b>15d4a4b0448391508f2cb486</b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting method for results in the format of <field>:<order>. Valid values:</para>
        /// <para>field:</para>
        /// <list type="bullet">
        /// <item><description>&quot;UsageCount&quot;: usage count</description></item>
        /// <item><description>&quot;UnitPrice&quot;: unit price</description></item>
        /// </list>
        /// <para>order:</para>
        /// <list type="bullet">
        /// <item><description>&quot;Desc&quot;: descending order</description></item>
        /// <item><description>&quot;Asc&quot;: ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UsageCount:Desc,UnitPrice:Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
