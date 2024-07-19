// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SelectResourceResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resourceInfoList")]
        [Validation(Required=false)]
        public List<SelectResourceResponseBodyResourceInfoList> ResourceInfoList { get; set; }
        public class SelectResourceResponseBodyResourceInfoList : TeaModel {
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("lastExpire")]
            [Validation(Required=false)]
            public int? LastExpire { get; set; }

            [NameInMap("remainCount")]
            [Validation(Required=false)]
            public int? RemainCount { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public int? ResourceType { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

    }

}
