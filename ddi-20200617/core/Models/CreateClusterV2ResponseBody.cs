// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class CreateClusterV2ResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CoreOrderId")]
        [Validation(Required=false)]
        public string CoreOrderId { get; set; }

        [NameInMap("EmrOrderId")]
        [Validation(Required=false)]
        public string EmrOrderId { get; set; }

        [NameInMap("MasterOrderId")]
        [Validation(Required=false)]
        public string MasterOrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
