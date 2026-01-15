// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeOperationParameters : TeaModel {
        [NameInMap("CordonParameters")]
        [Validation(Required=false)]
        public NodeCordonParameters CordonParameters { get; set; }

        [NameInMap("DrainParameters")]
        [Validation(Required=false)]
        public NodeDrainParameters DrainParameters { get; set; }

        [NameInMap("UncordonParameters")]
        [Validation(Required=false)]
        public NodeUncordonParameters UncordonParameters { get; set; }

    }

}
