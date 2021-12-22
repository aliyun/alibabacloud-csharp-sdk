// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetGameCcuResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<GetGameCcuResponseBodyDataList> DataList { get; set; }
        public class GetGameCcuResponseBodyDataList : TeaModel {
            [NameInMap("Ccu")]
            [Validation(Required=false)]
            public long? Ccu { get; set; }

            [NameInMap("GameId")]
            [Validation(Required=false)]
            public string GameId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
