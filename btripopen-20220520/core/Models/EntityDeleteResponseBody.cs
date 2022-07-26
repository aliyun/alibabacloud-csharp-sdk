// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EntityDeleteResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public EntityDeleteResponseBodyModule Module { get; set; }
        public class EntityDeleteResponseBodyModule : TeaModel {
            [NameInMap("remove_num")]
            [Validation(Required=false)]
            public int? RemoveNum { get; set; }
            [NameInMap("selected_user_num")]
            [Validation(Required=false)]
            public int? SelectedUserNum { get; set; }
        };

        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
