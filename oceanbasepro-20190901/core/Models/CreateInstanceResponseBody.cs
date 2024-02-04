// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyData Data { get; set; }
        public class CreateInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The result of the dry-run request.
            /// 
            /// If the DryRun parameter is set to true and the dry run succeeds, the DryRunResult parameter returns true. Otherwise, an error code is returned.
            /// If the DryRun parameter is set to false, no dry run is performed and the DryRunResult parameter returns false.
            /// </summary>
            [NameInMap("DryRunResult")]
            [Validation(Required=false)]
            public bool? DryRunResult { get; set; }

            /// <summary>
            /// Instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Order ID. The ID of the order that you have placed.
            /// This parameter returns a value after you create a pre-paid or post-paid cluster.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// Resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
