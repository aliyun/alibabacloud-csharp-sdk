// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ListValueAddedResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ValueAddedList")]
        [Validation(Required=true)]
        public List<ListValueAddedResponseValueAddedList> ValueAddedList { get; set; }
        public class ListValueAddedResponseValueAddedList : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=true)]
            public long? ExpireTime { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }

            [NameInMap("LogSize")]
            [Validation(Required=true)]
            public long? LogSize { get; set; }

        }

    }

}
