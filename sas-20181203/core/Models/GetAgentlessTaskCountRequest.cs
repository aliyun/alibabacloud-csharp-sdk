// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAgentlessTaskCountRequest : TeaModel {
        /// <summary>
        /// The instance ID of the asset.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// Specifies the type of the object being inspected. Valid values:
        /// 
        /// *   **3**: User Snapshot.
        /// *   **4**: User Image.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

    }

}
