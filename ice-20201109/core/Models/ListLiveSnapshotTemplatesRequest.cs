// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveSnapshotTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Valid values: [1,n). Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword. You can use the template ID or name as the keyword to search for templates. If you search for templates by name, fuzzy match is supported.</para>
        /// <list type="bullet">
        /// <item><description>It cannot exceed 128 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("SearchKeyWord")]
        [Validation(Required=false)]
        public string SearchKeyWord { get; set; }

        /// <summary>
        /// <para>The sorting order. By default, the query results are sorted by creation time in descending order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: sorts the query results by creation time in ascending order.</description></item>
        /// <item><description>desc: sorts the query results by creation time in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The template IDs.</para>
        /// <list type="bullet">
        /// <item><description>If you specify the SearchKeyWord parameter, this condition does not take effect.</description></item>
        /// <item><description>The maximum length of the array is 200.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// <para>The type of the template. By default, all types are queried.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system</description></item>
        /// <item><description>custom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
