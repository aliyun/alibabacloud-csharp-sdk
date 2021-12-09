// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class DeleteMultipleObjectsRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public Delete Body { get; set; }

        [NameInMap("delete")]
        [Validation(Required=false)]
        public Delete Delete { get; set; }

        [NameInMap("encoding-type")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

    }

}
