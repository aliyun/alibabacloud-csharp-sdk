// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class DeleteMultipleObjectsResponseBody : TeaModel {
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public List<DeletedObject> Deleted { get; set; }

        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

    }

}
