// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryPromInstallStatusResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPromInstallStatusResponseBodyData Data { get; set; }
        public class QueryPromInstallStatusResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the call was successful. Valid values:
            /// 
            /// true: The call was successful. false: The call fails.
            /// </summary>
            [NameInMap("isControllerInstalled")]
            [Validation(Required=false)]
            public bool? IsControllerInstalled { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
