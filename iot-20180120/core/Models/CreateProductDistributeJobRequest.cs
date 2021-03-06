// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductDistributeJobRequest : TeaModel {
        [NameInMap("SourceInstanceId")]
        [Validation(Required=true)]
        public string SourceInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("TargetInstanceId")]
        [Validation(Required=true)]
        public string TargetInstanceId { get; set; }

        [NameInMap("TargetUid")]
        [Validation(Required=false)]
        public string TargetUid { get; set; }

        [NameInMap("TargetAliyunId")]
        [Validation(Required=false)]
        public string TargetAliyunId { get; set; }

    }

}
