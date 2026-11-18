// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetCategoriesRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. If you specify this parameter, you can query the category with the specified ID. You can specify only one category ID. You can obtain the category ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Asset Configuration</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
        /// <item><description>The category ID is returned when you call the <a href="~~AddCategory~~">AddCategory</a> operation to create a category.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>49339****</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The page number of the subcategory list. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page in the subcategory list. Default value: <b>10</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting method of the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreationTime:Desc</b> (default): Sort by creation time in descending order.</description></item>
        /// <item><description><b>CreationTime:Asc</b>: Sort by creation time in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The categorization type. If you specify this parameter, you can perform a filtered query for categorizations of the specified type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: Audio, video, or image categorization.</description></item>
        /// <item><description><b>material</b>: Short video material categorization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
