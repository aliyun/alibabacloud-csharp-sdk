// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListQueuesRequest : TeaModel {
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
