// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class ImportProductsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DEVICE_001</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("ExtraImages")]
        [Validation(Required=false)]
        public List<string> ExtraImages { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>可口可乐330ml</para>
        /// </summary>
        [NameInMap("ImageTitle")]
        [Validation(Required=false)]
        public string ImageTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ITEM_001</para>
        /// </summary>
        [NameInMap("ItemUniqueId")]
        [Validation(Required=false)]
        public string ItemUniqueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://img.example.com/item1.jpg%22%5D">https://img.example.com/item1.jpg&quot;]</a></para>
        /// </summary>
        [NameInMap("MainImage")]
        [Validation(Required=false)]
        public List<string> MainImage { get; set; }

        [NameInMap("MultiViewImages")]
        [Validation(Required=false)]
        public List<ImportProductsRequestMultiViewImages> MultiViewImages { get; set; }
        public class ImportProductsRequestMultiViewImages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public string Angle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://img5-parcel.oss-cn-hangzhou.aliyuncs.com/2026/01/12/78568805914464s.jpeg?07">https://img5-parcel.oss-cn-hangzhou.aliyuncs.com/2026/01/12/78568805914464s.jpeg?07</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
