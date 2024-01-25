// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20211130.Models
{
    public class ListYydComputeTaskListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListYydComputeTaskListResponseBodyData> Data { get; set; }
        public class ListYydComputeTaskListResponseBodyData : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("bcId")]
            [Validation(Required=false)]
            public long? BcId { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
