// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodeLsifhoverResponseBody : TeaModel {
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public CreateLinkeantcodeAntcodeLsifhoverResponseBodyContents Contents { get; set; }
        public class CreateLinkeantcodeAntcodeLsifhoverResponseBodyContents : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Range")]
        [Validation(Required=false)]
        public CreateLinkeantcodeAntcodeLsifhoverResponseBodyRange Range { get; set; }
        public class CreateLinkeantcodeAntcodeLsifhoverResponseBodyRange : TeaModel {
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }
        };

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
