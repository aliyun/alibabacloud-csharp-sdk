// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListChangeRequestWorkflowExecutionsResponseBody : TeaModel {
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("pages")]
        [Validation(Required=false)]
        public long? Pages { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<object> Records { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
