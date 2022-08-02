// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ReplicationRuleProgress : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        [NameInMap("PrefixSet")]
        [Validation(Required=false)]
        public ReplicationPrefixSet PrefixSet { get; set; }

    }

}
