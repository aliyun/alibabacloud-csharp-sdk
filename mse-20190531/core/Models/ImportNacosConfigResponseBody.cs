// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportNacosConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportNacosConfigResponseBodyData Data { get; set; }
        public class ImportNacosConfigResponseBodyData : TeaModel {
            [NameInMap("FailData")]
            [Validation(Required=false)]
            public List<ImportNacosConfigResponseBodyDataFailData> FailData { get; set; }
            public class ImportNacosConfigResponseBodyDataFailData : TeaModel {
                public string DataId { get; set; }
                public string Group { get; set; }
            }
            [NameInMap("SkipCount")]
            [Validation(Required=false)]
            public int? SkipCount { get; set; }
            [NameInMap("SkipData")]
            [Validation(Required=false)]
            public List<ImportNacosConfigResponseBodyDataSkipData> SkipData { get; set; }
            public class ImportNacosConfigResponseBodyDataSkipData : TeaModel {
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
