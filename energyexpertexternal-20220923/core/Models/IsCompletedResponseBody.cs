// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class IsCompletedResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public IsCompletedResponseBodyData Data { get; set; }
        public class IsCompletedResponseBodyData : TeaModel {
            /// <summary>
            /// Modified time in milliseconds, e.g. 1711438780000.
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// The unique key of this generation task.
            /// </summary>
            [NameInMap("taskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            /// <summary>
            /// Unused temporarily.
            /// </summary>
            [NameInMap("taskShortResult")]
            [Validation(Required=false)]
            public string TaskShortResult { get; set; }

            /// <summary>
            /// The status of the report generation task. The possible values are `running`, `success`, and `error`, which mean generating, generating succeeded, and generating failed, respectively. If you encounter a result generation failure, check the model, correct the model, and then generate the result again.
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
