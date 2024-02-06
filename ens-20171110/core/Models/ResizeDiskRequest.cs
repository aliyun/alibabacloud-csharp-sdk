// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ResizeDiskRequest : TeaModel {
        /// <summary>
        /// The ID of the disk that you want to resize.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The size of the disk that you want to resize. Unit: GiB.
        /// </summary>
        [NameInMap("NewSize")]
        [Validation(Required=false)]
        public string NewSize { get; set; }

    }

}
