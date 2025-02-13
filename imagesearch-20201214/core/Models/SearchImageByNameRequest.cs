// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByNameRequest : TeaModel {
        /// <summary>
        /// <para>The category of the product. For more information, see <a href="https://help.aliyun.com/document_detail/179184.html">Category references</a>.</para>
        /// <list type="bullet">
        /// <item><description>For product search: If a category is specified, the specified category prevails. If no category is specified, the system estimates and selects a category. The category selected by the system is included in the response.</description></item>
        /// <item><description>For generic search: The parameter value is set to 88888888 regardless of whether a category is specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>88888888</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        [NameInMap("DistinctProductId")]
        [Validation(Required=false)]
        public bool? DistinctProductId { get; set; }

        /// <summary>
        /// <para>The filter conditions. int_attr supports the following operators: &gt;, &gt;=, &lt;, &lt;=, and =. str_attr supports the following operators: = and !=. You can set the logical operator between conditions to AND or OR.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>int_attr&gt;=100</description></item>
        /// <item><description>str_attr!=&quot;value1&quot;</description></item>
        /// <item><description>int_attr=1000 AND str_attr=&quot;value1&quot;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>int_attr&gt;=100</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoinstance1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The number of images to return on each page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        /// <summary>
        /// <para>The name of the image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1.jpg</para>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>The ID of the product.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The number of the image to return. Valid values: 0 to 499. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}
