// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CheckResourceSupportOperateResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the service resource can be downgraded. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ResourceCanBeDowngraded")]
        [Validation(Required=false)]
        public bool? ResourceCanBeDowngraded { get; set; }

        /// <summary>
        /// Indicates whether the zone where the service resource is deployed can be deleted. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ResourceZoneCanBeDeleted")]
        [Validation(Required=false)]
        public bool? ResourceZoneCanBeDeleted { get; set; }

    }

}
