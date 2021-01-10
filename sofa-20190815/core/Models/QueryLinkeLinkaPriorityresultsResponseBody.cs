// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinkaPriorityresultsResponseBody : TeaModel {
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
        public List<QueryLinkeLinkaPriorityresultsResponseBodyResult> Result { get; set; }
        public class QueryLinkeLinkaPriorityresultsResponseBodyResult : TeaModel {
            [NameInMap("BeginColumn")]
            [Validation(Required=false)]
            public long? BeginColumn { get; set; }

            [NameInMap("BeginLine")]
            [Validation(Required=false)]
            public long? BeginLine { get; set; }

            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndColumn")]
            [Validation(Required=false)]
            public long? EndColumn { get; set; }

            [NameInMap("EndLine")]
            [Validation(Required=false)]
            public long? EndLine { get; set; }

            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            [NameInMap("MethodName")]
            [Validation(Required=false)]
            public string MethodName { get; set; }

            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("VarName")]
            [Validation(Required=false)]
            public string VarName { get; set; }

            [NameInMap("RelatedFiles")]
            [Validation(Required=false)]
            public List<string> RelatedFiles { get; set; }

        }

    }

}
