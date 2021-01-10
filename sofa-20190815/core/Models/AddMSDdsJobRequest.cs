// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMSDdsJobRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        [NameInMap("Des")]
        [Validation(Required=false)]
        public string Des { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ShardingCount")]
        [Validation(Required=false)]
        public int? ShardingCount { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("CustomParams")]
        [Validation(Required=false)]
        public List<string> CustomParams { get; set; }

    }

}
