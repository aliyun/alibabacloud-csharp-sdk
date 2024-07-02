// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantReadableScnResponseBody : TeaModel {
        /// <summary>
        /// The data in the return result of the request.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTenantReadableScnResponseBodyData Data { get; set; }
        public class DescribeTenantReadableScnResponseBodyData : TeaModel {
            /// <summary>
            /// The maximum readable timestamp.
            /// </summary>
            [NameInMap("ReadableScn")]
            [Validation(Required=false)]
            public long? ReadableScn { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
