// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCacheReserveSpecificationResponseBody : TeaModel {
        [NameInMap("CacheReserveCapacity")]
        [Validation(Required=false)]
        public List<string> CacheReserveCapacity { get; set; }

        [NameInMap("CacheReserveRegion")]
        [Validation(Required=false)]
        public List<string> CacheReserveRegion { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
