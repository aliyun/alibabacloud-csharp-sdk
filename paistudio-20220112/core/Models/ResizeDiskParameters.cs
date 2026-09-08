// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResizeDiskParameters : TeaModel {
        /// <summary>
        /// <para>The target disk capacity after the change.</para>
        /// </summary>
        [NameInMap("NewDiskSize")]
        [Validation(Required=false)]
        public string NewDiskSize { get; set; }

    }

}
