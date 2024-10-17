// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCategoriesRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://ims.console.aliyun.com">Intelligent Media Services (IMS) console</a> and choose <b>Media Asset Management</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
        /// <item><description>View the value of CateId returned by the AddCategory operation that you called to create a category.</description></item>
        /// <item><description>View the value of CateId returned by the GetCategories operation that you called to query a category.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 10 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting rule of results. Valid values:</para>
        /// <para>\- CreationTime:Desc (default): The results are sorted in reverse chronological order based on the creation time.</para>
        /// <para>\- CreationTime:Asc: The results are sorted in chronological order based on the creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The type of the category. Valid values: default and material. A value of default indicates audio, video, and image files. This is the default value. A value of material indicates short video materials.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
