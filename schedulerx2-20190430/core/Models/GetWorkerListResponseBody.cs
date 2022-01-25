// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkerListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkerListResponseBodyData Data { get; set; }
        public class GetWorkerListResponseBodyData : TeaModel {
            [NameInMap("WorkerInfos")]
            [Validation(Required=false)]
            public List<GetWorkerListResponseBodyDataWorkerInfos> WorkerInfos { get; set; }
            public class GetWorkerListResponseBodyDataWorkerInfos : TeaModel {
                public string Ip { get; set; }
                public string Label { get; set; }
                public int? Port { get; set; }
                public string Starter { get; set; }
                public string Version { get; set; }
                public string WorkerAddress { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
