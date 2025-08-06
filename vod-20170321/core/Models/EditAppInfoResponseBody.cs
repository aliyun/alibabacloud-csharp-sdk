// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class EditAppInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EditAppInfoResponseBodyData Data { get; set; }
        public class EditAppInfoResponseBodyData : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
