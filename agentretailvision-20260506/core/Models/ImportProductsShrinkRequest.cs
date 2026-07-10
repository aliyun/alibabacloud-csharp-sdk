// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class ImportProductsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The device ID. This ID is used to establish an association between the device and product vectors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEVICE_001</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>The list of additional image URLs that can be provided.</para>
        /// </summary>
        [NameInMap("ExtraImages")]
        [Validation(Required=false)]
        public string ExtraImagesShrink { get; set; }

        /// <summary>
        /// <para>The product title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>可口可乐330ml</para>
        /// </summary>
        [NameInMap("ImageTitle")]
        [Validation(Required=false)]
        public string ImageTitle { get; set; }

        /// <summary>
        /// <para>The product ID assigned by the business party. This ID must be unique within the same business party.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ITEM_001</para>
        /// </summary>
        [NameInMap("ItemUniqueId")]
        [Validation(Required=false)]
        public string ItemUniqueId { get; set; }

        /// <summary>
        /// <para>The list of main product image URLs. At least one URL is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://img.example.com/item1.jpg%22%5D">https://img.example.com/item1.jpg&quot;]</a></para>
        /// </summary>
        [NameInMap("MainImage")]
        [Validation(Required=false)]
        public string MainImageShrink { get; set; }

        /// <summary>
        /// <para>The list of multi-angle product images.</para>
        /// </summary>
        [NameInMap("MultiViewImages")]
        [Validation(Required=false)]
        public string MultiViewImagesShrink { get; set; }

    }

}
