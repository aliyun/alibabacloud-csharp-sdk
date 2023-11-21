// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListGeographicSubRegionsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The region list.
        /// </summary>
        [NameInMap("GeographicSubRegions")]
        [Validation(Required=false)]
        public List<string> GeographicSubRegions { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
