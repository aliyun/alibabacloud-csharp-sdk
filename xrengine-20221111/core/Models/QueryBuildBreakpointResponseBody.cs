// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class QueryBuildBreakpointResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBuildBreakpointResponseBodyData Data { get; set; }
        public class QueryBuildBreakpointResponseBodyData : TeaModel {
            [NameInMap("Breakpoints")]
            [Validation(Required=false)]
            public List<QueryBuildBreakpointResponseBodyDataBreakpoints> Breakpoints { get; set; }
            public class QueryBuildBreakpointResponseBodyDataBreakpoints : TeaModel {
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public string Algorithm { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        [NameInMap("ErrorName")]
        [Validation(Required=false)]
        public string ErrorName { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

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
