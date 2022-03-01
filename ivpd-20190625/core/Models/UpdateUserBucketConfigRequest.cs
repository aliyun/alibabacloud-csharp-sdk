// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class UpdateUserBucketConfigRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<UpdateUserBucketConfigRequestData> Data { get; set; }
        public class UpdateUserBucketConfigRequestData : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
