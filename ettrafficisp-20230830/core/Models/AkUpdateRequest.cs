// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EttrafficIsp20230830.Models
{
    public class AkUpdateRequest : TeaModel {
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("accessKeyName")]
        [Validation(Required=false)]
        public string AccessKeyName { get; set; }

        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<string> Permissions { get; set; }

    }

}
