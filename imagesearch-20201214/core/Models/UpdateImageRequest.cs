// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class UpdateImageRequest : TeaModel {
        /// <summary>
        /// <para>The custom content. The content can be up to 4,096 characters in length.</para>
        /// <remarks>
        /// <para>This field is returned when you call the &quot;&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/202282.html">SearchImageByPic</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/image-search/latest/updateimage">SearchImageByPic</a>&quot; operation. For example, you can add text such as image descriptions.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomContent")]
        [Validation(Required=false)]
        public string CustomContent { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.
        /// If you have purchased an Image Search instance, go to the <a href="https://imagesearch.console.aliyun.com/">Image Search console</a> to view the instance name.
        /// If you have not purchased an Image Search instance, see <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
        /// <remarks>
        /// <para>The instance name is not the instance ID. Make sure to distinguish between them.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The integer attribute. This attribute can be used to filter query results. This field is returned in query results.</para>
        /// </summary>
        [NameInMap("IntAttr")]
        [Validation(Required=false)]
        public int? IntAttr { get; set; }

        /// <summary>
        /// <para>The integer attribute. This attribute can be used to filter query results. This field is returned in query results.</para>
        /// </summary>
        [NameInMap("IntAttr2")]
        [Validation(Required=false)]
        public int? IntAttr2 { get; set; }

        /// <summary>
        /// <para>The integer attribute. This attribute can be used to filter query results. This field is returned in query results.</para>
        /// </summary>
        [NameInMap("IntAttr3")]
        [Validation(Required=false)]
        public int? IntAttr3 { get; set; }

        /// <summary>
        /// <para>The integer attribute. This attribute can be used to filter query results. This field is returned in query results.</para>
        /// </summary>
        [NameInMap("IntAttr4")]
        [Validation(Required=false)]
        public int? IntAttr4 { get; set; }

        /// <summary>
        /// <para>The image name. The name can be up to 256 characters in length.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The combination of ProductId and PicName uniquely identifies an image.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you add an image multiple times with the same ProductId and PicName, the most recently added image takes effect and the previously added images are replaced.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>The product ID. The ID can be up to 256 characters in length.</para>
        /// <remarks>
        /// <para>A product can have multiple images. You can customize the value of this parameter based on your business requirements. For example: top001, pants002.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The string attribute. The attribute can be up to 128 characters in length. It can be used to filter query results. This field is returned in query results.</para>
        /// </summary>
        [NameInMap("StrAttr")]
        [Validation(Required=false)]
        public string StrAttr { get; set; }

        /// <summary>
        /// <para>The string attribute. The attribute can be up to 128 characters in length. It can be used to filter query results. This field is returned in query results.</para>
        /// </summary>
        [NameInMap("StrAttr2")]
        [Validation(Required=false)]
        public string StrAttr2 { get; set; }

        /// <summary>
        /// <para>The string attribute. The attribute can be up to 128 characters in length. It can be used to filter query results. This field is returned in query results.</para>
        /// </summary>
        [NameInMap("StrAttr3")]
        [Validation(Required=false)]
        public string StrAttr3 { get; set; }

        /// <summary>
        /// <para>The string attribute. The attribute can be up to 128 characters in length. It can be used to filter query results. This field is returned in query results.</para>
        /// </summary>
        [NameInMap("StrAttr4")]
        [Validation(Required=false)]
        public string StrAttr4 { get; set; }

    }

}
