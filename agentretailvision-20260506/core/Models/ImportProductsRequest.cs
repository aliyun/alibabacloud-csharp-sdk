// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class ImportProductsRequest : TeaModel {
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
        public List<string> ExtraImages { get; set; }

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
        public List<string> MainImage { get; set; }

        /// <summary>
        /// <para>The list of multi-angle product images.</para>
        /// </summary>
        [NameInMap("MultiViewImages")]
        [Validation(Required=false)]
        public List<ImportProductsRequestMultiViewImages> MultiViewImages { get; set; }
        public class ImportProductsRequestMultiViewImages : TeaModel {
            /// <summary>
            /// <para>The digital human angle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: front view, which is the default angle</description></item>
            /// <item><description>1: left side at 30 degrees</description></item>
            /// <item><description>2: right side at 30 degrees</description></item>
            /// </list>
            /// <para>For a preview of each angle, refer to <a href="https://help.aliyun.com/document_detail/447834.html#a989eb5075t9y">3D Digital Human Video Synthesis User Guide</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public string Angle { get; set; }

            /// <summary>
            /// <para>The task URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img5-parcel.oss-cn-hangzhou.aliyuncs.com/2026/01/12/78568805914464s.jpeg?07">https://img5-parcel.oss-cn-hangzhou.aliyuncs.com/2026/01/12/78568805914464s.jpeg?07</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
