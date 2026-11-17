// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ResizeWuyingServerDiskRequest : TeaModel {
        /// <summary>
        /// <para>The size and specifications of the data cloud disks.</para>
        /// </summary>
        [NameInMap("DataDiskList")]
        [Validation(Required=false)]
        public List<ResizeWuyingServerDiskRequestDataDiskList> DataDiskList { get; set; }
        public class ResizeWuyingServerDiskRequestDataDiskList : TeaModel {
            /// <summary>
            /// <para>The disk number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiskNo")]
            [Validation(Required=false)]
            public string DiskNo { get; set; }

            /// <summary>
            /// <para>The disk subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_DATA</para>
            /// </summary>
            [NameInMap("DiskSubType")]
            [Validation(Required=false)]
            public string DiskSubType { get; set; }

            /// <summary>
            /// <para>The type of disk data included in the image. By default, the system cloud disk and data cloud disks of the instance are included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The new size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220</para>
            /// </summary>
            [NameInMap("NewSize")]
            [Validation(Required=false)]
            public int? NewSize { get; set; }

        }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WuyingServer</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The new size of the system cloud disk, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>220</para>
        /// </summary>
        [NameInMap("SystemDiskNewSize")]
        [Validation(Required=false)]
        public int? SystemDiskNewSize { get; set; }

        /// <summary>
        /// <para>The ID of the WUYING Workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-0bw2f11****dial</para>
        /// </summary>
        [NameInMap("WuyingServerId")]
        [Validation(Required=false)]
        public string WuyingServerId { get; set; }

    }

}
