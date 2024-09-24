// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CheckUsedPropertyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of convenience users that are associated with the property.
        /// </summary>
        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public long? UseCount { get; set; }

    }

}
