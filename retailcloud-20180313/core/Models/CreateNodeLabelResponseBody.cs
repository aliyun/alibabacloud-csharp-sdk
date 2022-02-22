// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateNodeLabelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateNodeLabelResponseBodyResult Result { get; set; }
        public class CreateNodeLabelResponseBodyResult : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }
            [NameInMap("LabelValue")]
            [Validation(Required=false)]
            public string LabelValue { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
