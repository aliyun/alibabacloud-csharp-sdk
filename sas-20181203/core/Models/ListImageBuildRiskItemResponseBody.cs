// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageBuildRiskItemResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListImageBuildRiskItemResponseBodyData> Data { get; set; }
        public class ListImageBuildRiskItemResponseBodyData : TeaModel {
            /// <summary>
            /// The type key of the risky build command.
            /// </summary>
            [NameInMap("ItemKey")]
            [Validation(Required=false)]
            public string ItemKey { get; set; }

            /// <summary>
            /// The type name of the risky build command.
            /// </summary>
            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
