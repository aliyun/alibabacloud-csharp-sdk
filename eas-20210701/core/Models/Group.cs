// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Group : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("QueueService")]
        [Validation(Required=false)]
        public string QueueService { get; set; }

        [NameInMap("TrafficMode")]
        [Validation(Required=false)]
        public string TrafficMode { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
