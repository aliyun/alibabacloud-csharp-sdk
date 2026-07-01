// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByHybridRequest : TeaModel {
        /// <summary>
        /// <para>Custom filters. A JSON string. Supported backing fields include integer field intField1 and string fields strField1 and strField2. Only one matching condition can be applied per field, and filters across different fields are combined with a logical AND relationship.</para>
        /// <list type="bullet">
        /// <item><description><para>Exact match example: {&quot;intField1&quot;:12,&quot;strField1&quot;:&quot;abc&quot;}</para>
        /// </description></item>
        /// <item><description><para>Multi-value example: {&quot;intField1&quot;:[12,13],&quot;strField1&quot;:[&quot;abc&quot;,&quot;cd&quot;]}</para>
        /// </description></item>
        /// <item><description><para>Range example: {&quot;intField1&quot;:{&quot;gte&quot;:12,&quot;lte&quot;:13}}</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;intField1&quot;:{&quot;gte&quot;:12,&quot;lte&quot;:13},&quot;strField2&quot;:[&quot;cd&quot;,&quot;de&quot;],&quot;strField1&quot;:&quot;abc&quot;}</para>
        /// </summary>
        [NameInMap("CustomFilters")]
        [Validation(Required=false)]
        public string CustomFilters { get; set; }

        /// <summary>
        /// <para>The ID of the media asset. If provided, the details of the media asset are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>c469e944b5a856828dc2</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of media assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>image</para>
        /// </description></item>
        /// <item><description><para>video</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name-1</para>
        /// </summary>
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
        /// <para>The number of entries per page. Valid values: 1 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the search library</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// <para>The natural language search query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Two pandas are fighting.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>Creation time, in milliseconds UNIX timestamp. gte means greater than or equal to, and lte means less than or equal to.</para>
        /// <list type="bullet">
        /// <item><description>Range example: {&quot;gte&quot;:1761205662998,&quot;lte&quot;:1771205662998}</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;gte&quot;:1761205662998,&quot;lte&quot;:1771205662998}</para>
        /// </summary>
        [NameInMap("UtcCreate")]
        [Validation(Required=false)]
        public string UtcCreate { get; set; }

    }

}
