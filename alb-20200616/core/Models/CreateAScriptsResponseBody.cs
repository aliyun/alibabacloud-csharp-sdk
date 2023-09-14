// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateAScriptsResponseBody : TeaModel {
        /// <summary>
        /// The AScript rule IDs.
        /// </summary>
        [NameInMap("AScriptIds")]
        [Validation(Required=false)]
        public List<CreateAScriptsResponseBodyAScriptIds> AScriptIds { get; set; }
        public class CreateAScriptsResponseBodyAScriptIds : TeaModel {
            /// <summary>
            /// The AScript rule ID.
            /// </summary>
            [NameInMap("AScriptId")]
            [Validation(Required=false)]
            public string AScriptId { get; set; }

        }

        /// <summary>
        /// The asynchronous task ID.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
