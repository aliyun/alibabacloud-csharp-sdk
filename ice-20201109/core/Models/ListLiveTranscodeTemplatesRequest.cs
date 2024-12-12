// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveTranscodeTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The category of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system</description></item>
        /// <item><description>customized</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customized</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The search keyword. You can use the template ID or name as the keyword to search for templates. If you search for templates by name, fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_template</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting order. By default, the query results are sorted by creation time in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc</description></item>
        /// <item><description>desc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The type of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal</description></item>
        /// <item><description>narrow-band</description></item>
        /// <item><description>audio-only</description></item>
        /// <item><description>origin</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The video codec. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>H.264</description></item>
        /// <item><description>H.265</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>H.264</para>
        /// </summary>
        [NameInMap("VideoCodec")]
        [Validation(Required=false)]
        public string VideoCodec { get; set; }

    }

}
