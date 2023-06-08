// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropResponseBody : TeaModel {
        /// <summary>
        /// The number of packets that are blocked.
        /// </summary>
        [NameInMap("Drops")]
        [Validation(Required=false)]
        public int? Drops { get; set; }

        /// <summary>
        /// Indicates whether the information is found.
        /// 
        /// *   Found
        /// *   Not Found
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The character string that is concatenated based on the request parameters and is used to locate causes when data is not found.
        /// </summary>
        [NameInMap("UuidStr")]
        [Validation(Required=false)]
        public string UuidStr { get; set; }

    }

}
