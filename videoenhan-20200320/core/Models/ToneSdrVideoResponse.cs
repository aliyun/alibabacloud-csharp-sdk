// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class ToneSdrVideoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ToneSdrVideoResponseData Data { get; set; }
        public class ToneSdrVideoResponseData : TeaModel {
            [NameInMap("VideoURL")]
            [Validation(Required=true)]
            public string VideoURL { get; set; }
        };

    }

}
