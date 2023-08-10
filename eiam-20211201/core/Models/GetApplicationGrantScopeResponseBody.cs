// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationGrantScopeResponseBody : TeaModel {
        /// <summary>
        /// The permissions of the Developer API feature.
        /// </summary>
        [NameInMap("ApplicationGrantScope")]
        [Validation(Required=false)]
        public GetApplicationGrantScopeResponseBodyApplicationGrantScope ApplicationGrantScope { get; set; }
        public class GetApplicationGrantScopeResponseBodyApplicationGrantScope : TeaModel {
            /// <summary>
            /// The permissions of the Developer API feature.
            /// </summary>
            [NameInMap("GrantScopes")]
            [Validation(Required=false)]
            public List<string> GrantScopes { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
