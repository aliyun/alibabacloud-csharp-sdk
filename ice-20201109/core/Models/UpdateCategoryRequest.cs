// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://ims.console.aliyun.com">Intelligent Media Services (IMS) console</a> and choose <b>Media Asset Management</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
        /// <item><description>View the value of CateId returned by the AddCategory operation that you called to create a category.</description></item>
        /// <item><description>View the value of CateId returned by the GetCategories operation that you called to query a category.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The category name.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

    }

}
