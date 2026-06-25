// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DeleteImageRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition. The operators supported for int_attr include greater than (&gt;), greater than or equal to (&gt;=), less than (&lt;), less than or equal to (&lt;=), and equal to (=). The operators supported for str_attr include equal to (=) and not equal to (!=). Multiple conditions can be connected by using AND and OR.
        /// Examples:</para>
        /// <list type="bullet">
        /// <item><description>int_attr &gt;= 100.</description></item>
        /// <item><description>str_attr != &quot;value1&quot;.</description></item>
        /// <item><description>int_attr = 1000 AND str_attr = &quot;value1&quot;.<remarks>
        /// <para>A maximum of 4096 characters are supported.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// If you have not purchased an Image Search instance, refer to <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
        /// <remarks>
        /// <para>The instance name is not the instance ID. The instance name must be unique within the same region. Make sure that you use the correct value.</para>
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
        /// <para>Specifies whether to delete images based on the Filter parameter.</para>
        /// <remarks>
        /// <ol>
        /// <item><description>If this parameter is set to true, images are deleted based on the Filter parameter, and Filter is required.   </description></item>
        /// <item><description>If this parameter is set to false, images are deleted based on ProductId or the combination of ProductId and PicName. ProductId is required.</description></item>
        /// </ol>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDeleteByFilter")]
        [Validation(Required=false)]
        public bool? IsDeleteByFilter { get; set; }

        /// <summary>
        /// <para>The image name.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, all images under the specified ProductId are deleted.</description></item>
        /// <item><description>If you specify this parameter, the image specified by the combination of ProductId and PicName is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1.jpg</para>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// <remarks>
        /// <ol>
        /// <item><description>A product can have multiple images. 2. If IsDeleteByFilter is set to false, this parameter is required.</description></item>
        /// </ol>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

    }

}
