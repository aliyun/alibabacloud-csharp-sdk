// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CloneNacosConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloneNacosConfigResponseBodyData Data { get; set; }
        public class CloneNacosConfigResponseBodyData : TeaModel {
            [NameInMap("FailData")]
            [Validation(Required=false)]
            public List<CloneNacosConfigResponseBodyDataFailData> FailData { get; set; }
            public class CloneNacosConfigResponseBodyDataFailData : TeaModel {
                public string DataId { get; set; }
                public string Group { get; set; }
            }
            [NameInMap("SkipCount")]
            [Validation(Required=false)]
            public int? SkipCount { get; set; }
            [NameInMap("SkipData")]
            [Validation(Required=false)]
            public List<CloneNacosConfigResponseBodyDataSkipData> SkipData { get; set; }
            public class CloneNacosConfigResponseBodyDataSkipData : TeaModel {
                public string DataId { get; set; }
                public string Group { get; set; }
            }
            [NameInMap("SuccCount")]
            [Validation(Required=false)]
            public int? SuccCount { get; set; }
        };

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
