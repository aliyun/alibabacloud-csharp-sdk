// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EttrafficIsp20230830.Models
{
    public class AkGenerateRequest : TeaModel {
        [NameInMap("accessKeyName")]
        [Validation(Required=false)]
        public string AccessKeyName { get; set; }

        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<string> Permissions { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
