// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupConfigSynFlowResponseBody : TeaModel {
        [NameInMap("ApiCopyVersion")]
        [Validation(Required=false)]
        public string ApiCopyVersion { get; set; }

        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        [NameInMap("TargetGroupId")]
        [Validation(Required=false)]
        public string TargetGroupId { get; set; }

        [NameInMap("ExecutionTime")]
        [Validation(Required=false)]
        public string ExecutionTime { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("FlowStatus")]
        [Validation(Required=false)]
        public string FlowStatus { get; set; }

        [NameInMap("TargetGroupName")]
        [Validation(Required=false)]
        public string TargetGroupName { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("SourceGroupName")]
        [Validation(Required=false)]
        public string SourceGroupName { get; set; }

    }

}
