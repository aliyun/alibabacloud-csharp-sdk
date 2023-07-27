// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class BucketCnameConfiguration : TeaModel {
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public BucketCnameConfigurationCname Cname { get; set; }
        public class BucketCnameConfigurationCname : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

    }

}
