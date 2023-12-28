// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class GetActionResponseBody : TeaModel {
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public byte[] Content { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("Popularity")]
        [Validation(Required=false)]
        public string Popularity { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
