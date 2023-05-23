// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyCenRouteMapResponseBody : TeaModel {
        /// <summary>
        /// The action that is performed on the community. Valid values:
        /// 
        /// *   **Additive**: adds the community to the route.
        /// *   **Replace**: replaces the original community of the route.
        /// 
        /// This parameter specifies the action to be performed when a route meets the match condition.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
