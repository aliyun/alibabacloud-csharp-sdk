// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricMsgtypeinfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryLinkefabricFabricMsgtypeinfoResponseBodyData> Data { get; set; }
        public class QueryLinkefabricFabricMsgtypeinfoResponseBodyData : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Eventcode")]
            [Validation(Required=false)]
            public string Eventcode { get; set; }

            [NameInMap("MsgSize")]
            [Validation(Required=false)]
            public string MsgSize { get; set; }

            [NameInMap("MsgTotal")]
            [Validation(Required=false)]
            public string MsgTotal { get; set; }

            [NameInMap("NormalTps")]
            [Validation(Required=false)]
            public string NormalTps { get; set; }

            [NameInMap("PeakTotal")]
            [Validation(Required=false)]
            public string PeakTotal { get; set; }

            [NameInMap("PeakTps")]
            [Validation(Required=false)]
            public string PeakTps { get; set; }

            [NameInMap("Pgroup")]
            [Validation(Required=false)]
            public string Pgroup { get; set; }

            [NameInMap("ReadPartition")]
            [Validation(Required=false)]
            public string ReadPartition { get; set; }

            [NameInMap("ReliabilityReq")]
            [Validation(Required=false)]
            public string ReliabilityReq { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("TypeDesc")]
            [Validation(Required=false)]
            public string TypeDesc { get; set; }

            [NameInMap("UseCase")]
            [Validation(Required=false)]
            public string UseCase { get; set; }

            [NameInMap("WritePartition")]
            [Validation(Required=false)]
            public string WritePartition { get; set; }

        }

    }

}
