// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTagValuesResponseBody : TeaModel {
        /// <summary>
        /// The mappings between tag groups and tags.
        /// </summary>
        [NameInMap("Map")]
        [Validation(Required=false)]
        public string Map { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
