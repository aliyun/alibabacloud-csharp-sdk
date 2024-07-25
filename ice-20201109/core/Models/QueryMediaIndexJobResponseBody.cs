// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryMediaIndexJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IndexJobInfoList")]
        [Validation(Required=false)]
        public List<QueryMediaIndexJobResponseBodyIndexJobInfoList> IndexJobInfoList { get; set; }
        public class QueryMediaIndexJobResponseBodyIndexJobInfoList : TeaModel {
            [NameInMap("GmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            [NameInMap("GmtSubmit")]
            [Validation(Required=false)]
            public string GmtSubmit { get; set; }

            [NameInMap("IndexType")]
            [Validation(Required=false)]
            public string IndexType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
