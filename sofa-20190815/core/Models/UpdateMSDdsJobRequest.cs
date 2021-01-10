// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateMSDdsJobRequest : TeaModel {
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        [NameInMap("CustomParams")]
        [Validation(Required=false)]
        public List<string> CustomParams { get; set; }

        [NameInMap("Des")]
        [Validation(Required=false)]
        public string Des { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ShardingCount")]
        [Validation(Required=false)]
        public int? ShardingCount { get; set; }

    }

}
