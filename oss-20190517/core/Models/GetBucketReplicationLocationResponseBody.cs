// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetBucketReplicationLocationResponseBody : TeaModel {
        [NameInMap("Location")]
        [Validation(Required=false)]
        public List<string> Locations { get; set; }

        [NameInMap("LocationTransferTypeConstraint")]
        [Validation(Required=false)]
        public GetBucketReplicationLocationResponseBodyLocationTransferTypeConstraint LocationTransferTypeConstraint { get; set; }
        public class GetBucketReplicationLocationResponseBodyLocationTransferTypeConstraint : TeaModel {
            [NameInMap("LocationTransferType")]
            [Validation(Required=false)]
            public List<string> LocationTransferTypes { get; set; }
        };

    }

}
