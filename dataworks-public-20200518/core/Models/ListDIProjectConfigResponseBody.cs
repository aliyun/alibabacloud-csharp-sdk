// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIProjectConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDIProjectConfigResponseBodyData Data { get; set; }
        public class ListDIProjectConfigResponseBodyData : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
