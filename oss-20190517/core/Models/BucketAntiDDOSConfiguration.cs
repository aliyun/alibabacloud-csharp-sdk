// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class BucketAntiDDOSConfiguration : TeaModel {
        [NameInMap("Cnames")]
        [Validation(Required=false)]
        public BucketAntiDDOSConfigurationCnames Cnames { get; set; }
        public class BucketAntiDDOSConfigurationCnames : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<string> Domain { get; set; }

        }

    }

}
