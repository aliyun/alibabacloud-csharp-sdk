// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLocalDefaultRegionResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The access type of the multi-cloud site. Valid values:
        /// 
        /// *   **0**: The current site is not the default site of the multi-cloud site. You can specify a site as the default site of the multi-cloud site.
        /// *   **1**: The current site is the default site of the multi-cloud site.
        /// *   **2**: Another site is set as the default site of the multi-cloud site.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
