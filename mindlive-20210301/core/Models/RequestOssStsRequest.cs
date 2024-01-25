// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MindLive20210301.Models
{
    public class RequestOssStsRequest : TeaModel {
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("ExpireSeconds")]
        [Validation(Required=false)]
        public long? ExpireSeconds { get; set; }

    }

}
