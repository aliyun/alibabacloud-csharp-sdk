// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class RefreshErObjectCachesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the refresh task. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("RefreshTaskId")]
        [Validation(Required=false)]
        public string RefreshTaskId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
