// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListFlowRequest : TeaModel {
        /// <summary>
        /// The space ID of the RAM user within the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The name of the Flow that you want to query. If FlowName is left empty, the information about all Flows is queried.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The returned pages.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListFlowRequestPage Page { get; set; }
        public class ListFlowRequestPage : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

    }

}
