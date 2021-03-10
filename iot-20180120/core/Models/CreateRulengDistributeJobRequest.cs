// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateRulengDistributeJobRequest : TeaModel {
        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("SourceInstanceId")]
        [Validation(Required=true)]
        public string SourceInstanceId { get; set; }

        [NameInMap("TargetInstanceId")]
        [Validation(Required=true)]
        public string TargetInstanceId { get; set; }

    }

}
