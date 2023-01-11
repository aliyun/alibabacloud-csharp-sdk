// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListTopicsShrinkRequest : TeaModel {
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("messageTypes")]
        [Validation(Required=false)]
        public string MessageTypesShrink { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
