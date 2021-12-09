// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class PutBucketEncryptionRequest : TeaModel {
        [NameInMap("ServerSideEncryptionRule")]
        [Validation(Required=false)]
        public ServerSideEncryptionRule ServerSideEncryptionRule { get; set; }

    }

}
