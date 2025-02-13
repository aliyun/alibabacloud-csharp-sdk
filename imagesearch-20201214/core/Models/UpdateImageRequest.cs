// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class UpdateImageRequest : TeaModel {
        /// <summary>
        /// <para>The user-defined content. The value can be up to 4,096 characters in length.</para>
        /// <remarks>
        /// <para> If you set this parameter, the response includes this parameter and its value. You can add text such as an image description.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zidingyi</para>
        /// </summary>
        [NameInMap("CustomContent")]
        [Validation(Required=false)]
        public string CustomContent { get; set; }

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
        /// <para>The attribute, which is an integer. The attribute can be used to filter images when you search for images. If you set this parameter, the response includes this parameter and its value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("IntAttr")]
        [Validation(Required=false)]
        public int? IntAttr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("IntAttr2")]
        [Validation(Required=false)]
        public int? IntAttr2 { get; set; }

        [NameInMap("IntAttr3")]
        [Validation(Required=false)]
        public int? IntAttr3 { get; set; }

        [NameInMap("IntAttr4")]
        [Validation(Required=false)]
        public int? IntAttr4 { get; set; }

        /// <summary>
        /// <para>The name of the image. The name can be up to 512 characters in length.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>An image is uniquely identified by the values of the ProductId and PicName parameters.</description></item>
        /// <item><description>If you add an image whose product ID (ProductId) and image name (PicName) are the same as those of an existing image, the newly added image overwrites the existing image.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namexxx.jpg</para>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>The ID of the product. The ID can be up to 512 characters in length.</para>
        /// <remarks>
        /// <para> A product may have multiple images.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The attribute, which is a string. The value can be up to 128 characters in length. The attribute can be used to filter images. If you set this parameter, the response includes this parameter and its value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss</para>
        /// </summary>
        [NameInMap("StrAttr")]
        [Validation(Required=false)]
        public string StrAttr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StrAttr2")]
        [Validation(Required=false)]
        public string StrAttr2 { get; set; }

        [NameInMap("StrAttr3")]
        [Validation(Required=false)]
        public string StrAttr3 { get; set; }

        [NameInMap("StrAttr4")]
        [Validation(Required=false)]
        public string StrAttr4 { get; set; }

    }

}
