// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetHDMLastAliyunResourceSyncResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHDMLastAliyunResourceSyncResultResponseBodyData Data { get; set; }
        public class GetHDMLastAliyunResourceSyncResultResponseBodyData : TeaModel {
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public string Results { get; set; }

            [NameInMap("SubResults")]
            [Validation(Required=false)]
            public GetHDMLastAliyunResourceSyncResultResponseBodyDataSubResults SubResults { get; set; }
            public class GetHDMLastAliyunResourceSyncResultResponseBodyDataSubResults : TeaModel {
                [NameInMap("ResourceSyncSubResult")]
                [Validation(Required=false)]
                public List<GetHDMLastAliyunResourceSyncResultResponseBodyDataSubResultsResourceSyncSubResult> ResourceSyncSubResult { get; set; }
                public class GetHDMLastAliyunResourceSyncResultResponseBodyDataSubResultsResourceSyncSubResult : TeaModel {
                    [NameInMap("ErrMsg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    [NameInMap("SyncCount")]
                    [Validation(Required=false)]
                    public int? SyncCount { get; set; }

                }

            }

            [NameInMap("SyncStatus")]
            [Validation(Required=false)]
            public string SyncStatus { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public string Synchro { get; set; }

    }

}
