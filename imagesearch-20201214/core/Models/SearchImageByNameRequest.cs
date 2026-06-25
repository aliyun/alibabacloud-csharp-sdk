// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByNameRequest : TeaModel {
        /// <summary>
        /// <para>The product category. For more information, see <a href="https://help.aliyun.com/document_detail/179184.html">Category reference</a>.</para>
        /// <list type="bullet">
        /// <item><description>For product image search, if you specify a category, the specified category is used. If you do not specify a category, the system predicts the category. You can obtain the predicted category from the response.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>For fabric, trademark, generic, home furnishing, and industrial hardware searches, the system sets the category to 88888888 regardless of whether you specify a category.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>For generic image search, the system sets the category to 88888888 regardless of whether you specify a category..</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>88888888</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to deduplicate results based on ProductId.</para>
        /// <remarks>
        /// <para>Set this parameter to true to enable deduplication.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DistinctProductId")]
        [Validation(Required=false)]
        public bool? DistinctProductId { get; set; }

        /// <summary>
        /// <para>The filter condition. The int_attr field supports the following operators: in, not in, greater than (&gt;), greater than or equal to (&gt;=), less than (&lt;), less than or equal to (&lt;=), and equal to (=). The str_attr field supports the following operators: in, not in, equal to (=), and not equal to (!=). Multiple conditions can be connected by using AND and OR.
        /// Examples:</para>
        /// <list type="bullet">
        /// <item><description>int_attr&gt;=100.</description></item>
        /// <item><description>str_attr!=&quot;value1&quot;.</description></item>
        /// <item><description>int_attr=1000 AND str_attr=&quot;value1&quot;.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The maximum length is 4,096 characters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>int_attr&gt;=100</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.
        /// If you have purchased an Image Search instance, log on to the <a href="https://imagesearch.console.aliyun.com/">Image Search console</a> to view the instance name.
        /// If you have not purchased an Image Search instance, refer to <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
        /// <remarks>
        /// <para>The instance name is not the instance ID. Make sure you distinguish between them.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoinstance1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The number of results to return. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        /// <summary>
        /// <para>The image name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1.jpg</para>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The similarity score threshold. If you specify this parameter, only images with a similarity score greater than or equal to the threshold are returned. Valid values: 0.00 to 1.00. Up to two decimal places are supported. Default value: 0.00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.50</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public string ScoreThreshold { get; set; }

        /// <summary>
        /// <para>The start position of the results to return. Valid values: 0 to 499. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}
