// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClientAlertModeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListClientAlertModeResponseBodyData Data { get; set; }
        public class ListClientAlertModeResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("Uuids")]
            [Validation(Required=false)]
            public List<string> Uuids { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
