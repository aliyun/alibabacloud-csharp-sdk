// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsRcSyncBucketResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddMsRcSyncBucketResponseBodyData Data { get; set; }
        public class AddMsRcSyncBucketResponseBodyData : TeaModel {
            [NameInMap("SourceClusterId")]
            [Validation(Required=false)]
            public string SourceClusterId { get; set; }
            [NameInMap("ClusterTaskStatus")]
            [Validation(Required=false)]
            public string ClusterTaskStatus { get; set; }
            [NameInMap("TargetClusterId")]
            [Validation(Required=false)]
            public string TargetClusterId { get; set; }
            [NameInMap("ClusterTaskId")]
            [Validation(Required=false)]
            public string ClusterTaskId { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
