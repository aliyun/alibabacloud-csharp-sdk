// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ResizeDiskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the disk that you want to resize.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-5tzm9wnhzlhjzcbtxo465****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The size of the disk that you want to resize. Unit: GiB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NewSize")]
        [Validation(Required=false)]
        public string NewSize { get; set; }

    }

}
