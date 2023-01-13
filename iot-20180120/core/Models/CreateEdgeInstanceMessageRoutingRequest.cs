// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateEdgeInstanceMessageRoutingRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SourceData")]
        [Validation(Required=false)]
        public string SourceData { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=true)]
        public string SourceType { get; set; }

        [NameInMap("TargetData")]
        [Validation(Required=false)]
        public string TargetData { get; set; }

        [NameInMap("TargetIotHubQos")]
        [Validation(Required=false)]
        public int? TargetIotHubQos { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=true)]
        public string TargetType { get; set; }

        [NameInMap("TopicFilter")]
        [Validation(Required=false)]
        public string TopicFilter { get; set; }

    }

}
