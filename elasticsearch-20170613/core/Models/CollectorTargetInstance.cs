// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CollectorTargetInstance : TeaModel {
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("enableMonitoring")]
        [Validation(Required=false)]
        public bool? EnableMonitoring { get; set; }

        [NameInMap("hosts")]
        [Validation(Required=false)]
        public List<string> Hosts { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
