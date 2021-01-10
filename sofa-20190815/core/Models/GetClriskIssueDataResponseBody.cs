// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskIssueDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

        [NameInMap("IssueDataId")]
        [Validation(Required=false)]
        public string IssueDataId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        [NameInMap("Heads")]
        [Validation(Required=false)]
        public List<string> Heads { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<GetClriskIssueDataResponseBodyValues> Values { get; set; }
        public class GetClriskIssueDataResponseBodyValues : TeaModel {
            [NameInMap("Names")]
            [Validation(Required=false)]
            public List<string> Names { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

    }

}
