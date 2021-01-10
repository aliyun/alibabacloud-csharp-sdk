// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeProjectsidrepositorylsifhoverResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Contents")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeProjectsidrepositorylsifhoverResponseBodyContents Contents { get; set; }
        public class QueryLinkeantcodeAntcodeProjectsidrepositorylsifhoverResponseBodyContents : TeaModel {
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }
        };

        [NameInMap("Range")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeProjectsidrepositorylsifhoverResponseBodyRange Range { get; set; }
        public class QueryLinkeantcodeAntcodeProjectsidrepositorylsifhoverResponseBodyRange : TeaModel {
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }
        };

    }

}
