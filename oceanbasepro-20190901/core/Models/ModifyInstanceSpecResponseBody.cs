// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceSpecResponseBody : TeaModel {
        /// <summary>
        /// The return data of the request.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyInstanceSpecResponseBodyData Data { get; set; }
        public class ModifyInstanceSpecResponseBodyData : TeaModel {
            /// <summary>
            /// The result of the dry-run request.
            /// - If the DryRun parameter is set to true and the dry run succeeds, the DryRunResult parameter returns true. Otherwise, an error code is returned.
            /// - If the DryRun parameter is set to false, no dry run is performed and the DryRunResult parameter returns false.
            /// </summary>
            [NameInMap("DryRunResult")]
            [Validation(Required=false)]
            public bool? DryRunResult { get; set; }

            /// <summary>
            /// The ID of the order that you have placed.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
