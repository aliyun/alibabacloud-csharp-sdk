// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateGroupConfigSynFlowRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public int? FlowVersion { get; set; }

        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        [NameInMap("TargetGroupId")]
        [Validation(Required=false)]
        public string TargetGroupId { get; set; }

        [NameInMap("ApiSynVersion")]
        [Validation(Required=false)]
        public string ApiSynVersion { get; set; }

        [NameInMap("SourceGroupRegion")]
        [Validation(Required=false)]
        public string SourceGroupRegion { get; set; }

    }

}
