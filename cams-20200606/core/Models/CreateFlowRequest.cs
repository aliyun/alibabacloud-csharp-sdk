// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateFlowRequest : TeaModel {
        /// <summary>
        /// The categories of the Flow.
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// The space ID of the user within the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The name of the Flow.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

    }

}
