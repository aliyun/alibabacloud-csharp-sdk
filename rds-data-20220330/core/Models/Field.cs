// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds_data20220330.Models
{
    public class Field : TeaModel {
        [NameInMap("ArrayValue")]
        [Validation(Required=false)]
        public string ArrayValue { get; set; }

        [NameInMap("BlobValue")]
        [Validation(Required=false)]
        public string BlobValue { get; set; }

        [NameInMap("BooleanValue")]
        [Validation(Required=false)]
        public bool? BooleanValue { get; set; }

        [NameInMap("IsNull")]
        [Validation(Required=false)]
        public bool? IsNull { get; set; }

        [NameInMap("LongValue")]
        [Validation(Required=false)]
        public long? LongValue { get; set; }

        [NameInMap("StringValue")]
        [Validation(Required=false)]
        public string StringValue { get; set; }

    }

}
