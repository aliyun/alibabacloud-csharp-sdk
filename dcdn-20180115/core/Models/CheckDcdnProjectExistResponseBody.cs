// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CheckDcdnProjectExistResponseBody : TeaModel {
        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CheckDcdnProjectExistResponseBodyContent Content { get; set; }
        public class CheckDcdnProjectExistResponseBodyContent : TeaModel {
            /// <summary>
            /// Indicates whether the real-time log delivery project exists. Valid values:
            /// 
            /// *   **false**
            /// *   **true**
            /// </summary>
            [NameInMap("Exist")]
            [Validation(Required=false)]
            public string Exist { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
