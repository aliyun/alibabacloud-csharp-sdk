// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemoveRequest : TeaModel {
        /// <summary>
        /// <para>URL of the image to be processed (mutually exclusive with ImageBase64)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/bao/uploaded/i2/xxx.jpg">https://img.alicdn.com/bao/uploaded/i2/xxx.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Specific removal area in RLE format. If provided, this takes priority and the remove parameters are ignored</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>Elements to remove from the non-subject area of the image (1=transparent text blocks; 2=specific names; 3=text; 4=blemishes). Multiple selections allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("NonObjectRemoveElements")]
        [Validation(Required=false)]
        public List<int?> NonObjectRemoveElements { get; set; }

        /// <summary>
        /// <para>Elements to remove from the image subject (1=transparent text blocks; 2=specific names; 3=text; 4=blemishes). Multiple selections allowed</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("ObjectRemoveElements")]
        [Validation(Required=false)]
        public List<int?> ObjectRemoveElements { get; set; }

    }

}
