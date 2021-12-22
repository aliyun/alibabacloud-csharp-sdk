// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class QueryOutAccountBindStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOutAccountBindStatusResponseBodyData Data { get; set; }
        public class QueryOutAccountBindStatusResponseBodyData : TeaModel {
            [NameInMap("BindStatus")]
            [Validation(Required=false)]
            public int? BindStatus { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
