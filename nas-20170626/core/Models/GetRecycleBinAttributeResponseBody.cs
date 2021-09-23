// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetRecycleBinAttributeResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RecycleBinAttribute")]
        [Validation(Required=false)]
        public GetRecycleBinAttributeResponseBodyRecycleBinAttribute RecycleBinAttribute { get; set; }
        public class GetRecycleBinAttributeResponseBodyRecycleBinAttribute : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ReservedDays")]
            [Validation(Required=false)]
            public long? ReservedDays { get; set; }
            [NameInMap("EnableTime")]
            [Validation(Required=false)]
            public string EnableTime { get; set; }
        };

    }

}
