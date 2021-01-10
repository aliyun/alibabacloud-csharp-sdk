// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinkaAllsourcefilenodesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryLinkeLinkaAllsourcefilenodesResponseBodyResult> Result { get; set; }
        public class QueryLinkeLinkaAllsourcefilenodesResponseBodyResult : TeaModel {
            [NameInMap("BranchCovered")]
            [Validation(Required=false)]
            public long? BranchCovered { get; set; }

            [NameInMap("BranchTotal")]
            [Validation(Required=false)]
            public long? BranchTotal { get; set; }

            [NameInMap("ClassCovered")]
            [Validation(Required=false)]
            public long? ClassCovered { get; set; }

            [NameInMap("ClassTotal")]
            [Validation(Required=false)]
            public long? ClassTotal { get; set; }

            [NameInMap("CxtyCovered")]
            [Validation(Required=false)]
            public long? CxtyCovered { get; set; }

            [NameInMap("CxtyTotal")]
            [Validation(Required=false)]
            public long? CxtyTotal { get; set; }

            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("HasSourceCode")]
            [Validation(Required=false)]
            public bool? HasSourceCode { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstrCovered")]
            [Validation(Required=false)]
            public long? InstrCovered { get; set; }

            [NameInMap("InstrTotal")]
            [Validation(Required=false)]
            public long? InstrTotal { get; set; }

            [NameInMap("LineCoverageData")]
            [Validation(Required=false)]
            public string LineCoverageData { get; set; }

            [NameInMap("LineCovered")]
            [Validation(Required=false)]
            public long? LineCovered { get; set; }

            [NameInMap("LineTotal")]
            [Validation(Required=false)]
            public long? LineTotal { get; set; }

            [NameInMap("MethodCovered")]
            [Validation(Required=false)]
            public long? MethodCovered { get; set; }

            [NameInMap("MethodTotal")]
            [Validation(Required=false)]
            public long? MethodTotal { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("DiffLines")]
            [Validation(Required=false)]
            public List<long?> DiffLines { get; set; }

        }

    }

}
