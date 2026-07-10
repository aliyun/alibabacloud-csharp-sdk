// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class UpdateProductShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The device ID, which is used to establish the vector association between the device and the item.</para>
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
        /// <para>The title of the item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>可口可乐330ml</para>
        /// </summary>
        [NameInMap("ImageTitle")]
        [Validation(Required=false)]
        public string ImageTitle { get; set; }

        /// <summary>
        /// <para>The business-side item ID, which is unique within the same business party.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ITEM_001</para>
        /// </summary>
        [NameInMap("ItemUniqueId")]
        [Validation(Required=false)]
        public string ItemUniqueId { get; set; }

        /// <summary>
        /// <para>The list of main image URLs for the item. At least one image is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://img.example.com/item1.jpg%22%5D">https://img.example.com/item1.jpg&quot;]</a></para>
        /// </summary>
        [NameInMap("MainImage")]
        [Validation(Required=false)]
        public string MainImageShrink { get; set; }

        /// <summary>
        /// <para>The list of multi-angle images for the item.</para>
        /// </summary>
        [NameInMap("MultiViewImages")]
        [Validation(Required=false)]
        public string MultiViewImagesShrink { get; set; }

        /// <summary>
        /// <para>The platform item ID, which is globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PLAT_001</para>
        /// </summary>
        [NameInMap("PlatformItemId")]
        [Validation(Required=false)]
        public string PlatformItemId { get; set; }

    }

}
