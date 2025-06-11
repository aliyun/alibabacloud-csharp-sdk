// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByAILabelRequest : TeaModel {
        [NameInMap("MatchingMode")]
        [Validation(Required=false)]
        public string MatchingMode { get; set; }

        /// <summary>
        /// <para>The ID of the media asset. This parameter is required if you want to query media asset clips.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>c469e944b5a856828dc2</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of the media assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>video</description></item>
        /// <item><description>audio</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The type of query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PersonName: queries media assets based on character names.</description></item>
        /// <item><description>Ocr: queries media assets based on subtitles.</description></item>
        /// <item><description>AiCategory: queries media assets based on AI categories.</description></item>
        /// <item><description>FullSearch (default): queries all media assets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ocr</para>
        /// </summary>
        [NameInMap("MultimodalSearchType")]
        [Validation(Required=false)]
        public string MultimodalSearchType { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// <para>The sorting method of the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreationTime:Desc (default): sorts results in reverse chronological order.</description></item>
        /// <item><description>CreationTime:Asc: sorts results in chronological order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to query media asset clips. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpecificSearch")]
        [Validation(Required=false)]
        public bool? SpecificSearch { get; set; }

        /// <summary>
        /// <para>The content that you want to query.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
