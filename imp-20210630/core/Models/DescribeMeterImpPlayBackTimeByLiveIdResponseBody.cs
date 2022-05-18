// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class DescribeMeterImpPlayBackTimeByLiveIdResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImpPlayBackTimeByLiveIdResponseBodyData> Data { get; set; }
        public class DescribeMeterImpPlayBackTimeByLiveIdResponseBodyData : TeaModel {
            [NameInMap("WatchTime")]
            [Validation(Required=false)]
            public long? WatchTime { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
