// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetSCIMSynchronizationStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The status of SCIM synchronization. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled
        /// </summary>
        [NameInMap("SCIMSynchronizationStatus")]
        [Validation(Required=false)]
        public string SCIMSynchronizationStatus { get; set; }

    }

}
