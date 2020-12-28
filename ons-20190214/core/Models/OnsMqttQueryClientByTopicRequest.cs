// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMqttQueryClientByTopicRequest : TeaModel {
        [NameInMap("ParentTopic")]
        [Validation(Required=false)]
        public string ParentTopic { get; set; }

        [NameInMap("SubTopic")]
        [Validation(Required=false)]
        public string SubTopic { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
