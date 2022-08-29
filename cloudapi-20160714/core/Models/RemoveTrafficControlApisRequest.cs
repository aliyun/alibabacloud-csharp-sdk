// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveTrafficControlApisRequest : TeaModel {
        [NameInMap("ApiIds")]
        [Validation(Required=false)]
        public string ApiIds { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

    }

}
