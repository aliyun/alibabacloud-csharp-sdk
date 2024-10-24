// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UnbindDirectoryRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
