// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetCategoriesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the category. If you specify this parameter, the system queries the category based on the ID. You can specify only one category ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. Choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b>. On the Audio and Video / Image Category or Short Video Material Category tab, view the category ID.</description></item>
        /// <item><description>Obtain the category ID from the response to the <a href="~~AddCategory~~">AddCategory</a> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>49339****</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The number of the page where the subcategories to be returned are listed. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page of the subcategory list. Default value: <b>10</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting method of the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreationTime:Desc</b> (default): The results are sorted in reverse chronological order based on the creation time.</description></item>
        /// <item><description><b>CreationTime:Asc</b>: The results are sorted in chronological order based on the creation time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The type of the category. If you specify this parameter, the system queries the category based on the type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b> (default): audio, video, and image files</description></item>
        /// <item><description><b>material</b>: short video materials</description></item>
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
