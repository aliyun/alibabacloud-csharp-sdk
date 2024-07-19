// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class QueryAvatarResourceResponseBody : TeaModel {
        [NameInMap("queryResourceInfoList")]
        [Validation(Required=false)]
        public List<QueryAvatarResourceResponseBodyQueryResourceInfoList> QueryResourceInfoList { get; set; }
        public class QueryAvatarResourceResponseBodyQueryResourceInfoList : TeaModel {
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("validPeriodTime")]
            [Validation(Required=false)]
            public string ValidPeriodTime { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
