// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemoveRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image to process. This parameter is mutually exclusive with ImageBase64. You must specify one of them.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/bao/uploaded/i2/xxx.jpg">https://img.alicdn.com/bao/uploaded/i2/xxx.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The specific erasure region in RLE format. If this parameter is specified, it takes priority and the remove parameters are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The elements to remove from the non-subject area of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: transparent text block</description></item>
        /// <item><description>2: specific name</description></item>
        /// <item><description>3: text</description></item>
        /// <item><description>4: image blemish</description></item>
        /// </list>
        /// <para>You can specify multiple values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("NonObjectRemoveElements")]
        [Validation(Required=false)]
        public List<int?> NonObjectRemoveElements { get; set; }

        /// <summary>
        /// <para>The elements to remove from the image subject area. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: transparent text block</description></item>
        /// <item><description>2: specific name</description></item>
        /// <item><description>3: text</description></item>
        /// <item><description>4: image blemish</description></item>
        /// </list>
        /// <para>You can specify multiple values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("ObjectRemoveElements")]
        [Validation(Required=false)]
        public List<int?> ObjectRemoveElements { get; set; }

    }

}
