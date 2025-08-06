// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPageByCondAppInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPageByCondAppInfoResponseBodyData Data { get; set; }
        public class GetPageByCondAppInfoResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<AppInfoDTO> List { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
