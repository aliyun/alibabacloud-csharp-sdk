// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class InitDWSTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InitDWSTaskResponseBodyData Data { get; set; }
        public class InitDWSTaskResponseBodyData : TeaModel {
            [NameInMap("DstCategory")]
            [Validation(Required=false)]
            public string DstCategory { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Linkman")]
            [Validation(Required=false)]
            public string Linkman { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Scenarios")]
            [Validation(Required=false)]
            public string Scenarios { get; set; }
            [NameInMap("SrcCategory")]
            [Validation(Required=false)]
            public string SrcCategory { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TaskParamJson")]
            [Validation(Required=false)]
            public string TaskParamJson { get; set; }
        };

    }

}
