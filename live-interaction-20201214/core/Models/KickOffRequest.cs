// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class KickOffRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public KickOffRequestRequestParams RequestParams { get; set; }
        public class KickOffRequestRequestParams : TeaModel {
            [NameInMap("AppKeys")]
            [Validation(Required=false)]
            public List<string> AppKeys { get; set; }

            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }

            [NameInMap("Information")]
            [Validation(Required=false)]
            public string Information { get; set; }

        }

    }

}
