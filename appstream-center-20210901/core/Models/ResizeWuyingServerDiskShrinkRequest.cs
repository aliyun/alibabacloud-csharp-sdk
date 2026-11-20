// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ResizeWuyingServerDiskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The size and specifications of the data cloud disks.</para>
        /// </summary>
        [NameInMap("DataDiskList")]
        [Validation(Required=false)]
        public string DataDiskListShrink { get; set; }

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
        /// <para>The new capacity of the system cloud disk, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>220</para>
        /// </summary>
        [NameInMap("SystemDiskNewSize")]
        [Validation(Required=false)]
        public int? SystemDiskNewSize { get; set; }

        /// <summary>
        /// <para>The workstation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-0bw2f11****dial</para>
        /// </summary>
        [NameInMap("WuyingServerId")]
        [Validation(Required=false)]
        public string WuyingServerId { get; set; }

    }

}
