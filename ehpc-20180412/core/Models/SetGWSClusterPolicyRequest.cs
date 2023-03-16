// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetGWSClusterPolicyRequest : TeaModel {
        /// <summary>
        /// Specifies whether to support the asynchronous calls.
        /// 
        /// *   false: not supported. The result is returned after the request is completed.
        /// *   true: supported. The result is immediately returned while the request is being processed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("AsyncMode")]
        [Validation(Required=false)]
        public bool? AsyncMode { get; set; }

        /// <summary>
        /// The permissions on the clipboard. Valid values:
        /// 
        /// *   read: read-only. You can copy data from your local computer to the cloud desktop, but cannot copy data from the cloud desktop to your local computer.
        /// *   readwrite: read and write. You can copy data between your local computer and the cloud desktop.
        /// *   off: disabled. You cannot copy data between your local computer and the cloud desktop.
        /// 
        /// Default value: off.
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// The ID of the visualization service.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The permissions on local disk mapping. Valid values:
        /// 
        /// *   read: read-only. The disks on your local computer are mapped to the cloud desktop. You can only read (copy) files on the local computer, but cannot modify the files.
        /// *   readwrite: read and write. The disks on your local computer are mapped to the cloud desktop. You can read (copy) and modify files on your local computer.
        /// *   off: disabled. The disks on your local computer are not mapped to the cloud desktop.
        /// 
        /// Default value: off.
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        /// <summary>
        /// The UDP port. Valid values:
        /// 
        /// *   on
        /// *   off
        /// 
        /// Default value: on.
        /// </summary>
        [NameInMap("UdpPort")]
        [Validation(Required=false)]
        public string UdpPort { get; set; }

        /// <summary>
        /// The USB redirection feature. Valid values:
        /// 
        /// *   on
        /// *   off
        /// 
        /// Default value: off.
        /// </summary>
        [NameInMap("UsbRedirect")]
        [Validation(Required=false)]
        public string UsbRedirect { get; set; }

        /// <summary>
        /// The watermarking feature. Valid values:
        /// 
        /// *   on
        /// *   off
        /// 
        /// Default value: off.
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

    }

}
