// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityProjectLogResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetQualityProjectLogResponseBodyData> Data { get; set; }
        public class GetQualityProjectLogResponseBodyData : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("ActionData")]
            [Validation(Required=false)]
            public string ActionData { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("ProjectCreateTime")]
            [Validation(Required=false)]
            public string ProjectCreateTime { get; set; }

            [NameInMap("ActionTime")]
            [Validation(Required=false)]
            public string ActionTime { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
