// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSearchLibResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SearchLibInfoList")]
        [Validation(Required=false)]
        public List<ListSearchLibResponseBodySearchLibInfoList> SearchLibInfoList { get; set; }
        public class ListSearchLibResponseBodySearchLibInfoList : TeaModel {
            [NameInMap("SearchLibName")]
            [Validation(Required=false)]
            public string SearchLibName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
