// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkeLinktRemovetemplatefromprojectResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckLinkeLinktRemovetemplatefromprojectResponseBodyData Data { get; set; }
        public class CheckLinkeLinktRemovetemplatefromprojectResponseBodyData : TeaModel {
            [NameInMap("WorkItemCount")]
            [Validation(Required=false)]
            public long? WorkItemCount { get; set; }
            [NameInMap("CheckSuccess")]
            [Validation(Required=false)]
            public bool? CheckSuccess { get; set; }
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public long? ErrorCode { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
