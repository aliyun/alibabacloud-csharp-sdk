// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByMultimodalRequest : TeaModel {
        /// <summary>
        /// <para>Custom filters. A JSON string. Supported backing fields include integer field intField1 and string fields strField1 and strField2. Only one matching condition can be applied per field, and filters across different fields are combined with a logical AND relationship.</para>
        /// <list type="bullet">
        /// <item><description><para>Exact match example: {&quot;intField1&quot;:12,&quot;strField1&quot;:&quot;abc&quot;}</para>
        /// </description></item>
        /// <item><description><para>Multi-value match example: {&quot;intField1&quot;:[12,13],&quot;strField1&quot;:[&quot;abc&quot;,&quot;cd&quot;]}</para>
        /// </description></item>
        /// <item><description><para>Range match example: {&quot;intField1&quot;:{&quot;gte&quot;:12,&quot;lte&quot;:13}}</para>
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
        /// <para>The type of the media assets.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>image</para>
        /// </description></item>
        /// <item><description><para>video (default)</para>
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
        /// <para>Namespace.</para>
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
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// <para>The content that you want to query. You can describe the content in natural language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Two pandas are fighting.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>Creation time, in milliseconds UNIX timestamp. gte indicates greater than or equal to, and lte indicates less than or equal to.</para>
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
