// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteInstancesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteInstancesResponseBodyData Data { get; set; }
        public class DeleteInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// The result of the dry-run request.
            /// - If the DryRun parameter is set to true and the dry run succeeds, the DryRunResult parameter returns true. Otherwise, an error code is returned.
            /// - If the DryRun parameter is set to false, no dry run is performed and the DryRunResult parameter returns false.
            /// </summary>
            [NameInMap("DryRunResult")]
            [Validation(Required=false)]
            public bool? DryRunResult { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
