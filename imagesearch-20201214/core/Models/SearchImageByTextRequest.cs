// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByTextRequest : TeaModel {
        /// <summary>
        /// <para>If this parameter is set to true, duplicate data is removed based on the ProductId field during the search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DistinctProductId")]
        [Validation(Required=false)]
        public bool? DistinctProductId { get; set; }

        /// <summary>
        /// <para>The filter condition. The int_attr field supports the following operators: in, not in, greater than (&gt;), greater than or equal to (&gt;=), less than (&lt;), less than or equal to (&lt;=), and equal to (=). The str_attr field supports the following operators: in, not in, equal to (=), and not equal to (!=). You can use AND and OR to connect multiple conditions.
        /// Examples:</para>
        /// <list type="bullet">
        /// <item><description>int_attr &gt;= 100.</description></item>
        /// <item><description>str_attr != &quot;value1&quot;.</description></item>
        /// <item><description>int_attr = 1000 AND str_attr = &quot;value1&quot;.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The filter condition can be up to 4,096 characters in length.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>int_attr=1000 AND str_attr=&quot;value1&quot;</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.
        /// If you have purchased an Image Search instance, log on to the <a href="https://imagesearch.console.aliyun.com/">Image Search console</a> to view the instance name.
        /// If you have not purchased an Image Search instance, see <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
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
        /// <para>The similarity score threshold. After you specify this parameter, only images whose similarity scores are greater than or equal to the threshold are returned. Valid values: 0.00 to 1.00. The value supports up to two decimal places. Default value: 0.00.</para>
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

        /// <summary>
        /// <para>The description text for searching images. Chinese and English are supported.</para>
        /// <remarks>
        /// <para>The text can be up to 512 characters in length.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
