// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListDevopsProjectTaskListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public ListDevopsProjectTaskListResponseBodyObject Object { get; set; }
        public class ListDevopsProjectTaskListResponseBodyObject : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListDevopsProjectTaskListResponseBodyObjectResult> Result { get; set; }
            public class ListDevopsProjectTaskListResponseBodyObjectResult : TeaModel {
                public string Id { get; set; }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

    }

}
