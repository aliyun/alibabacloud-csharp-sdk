// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricMsgbinginginfoResponseBody : TeaModel {
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
        public List<QueryLinkefabricFabricMsgbinginginfoResponseBodyData> Data { get; set; }
        public class QueryLinkefabricFabricMsgbinginginfoResponseBodyData : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("Eventcode")]
            [Validation(Required=false)]
            public string Eventcode { get; set; }

            [NameInMap("ExchangeType")]
            [Validation(Required=false)]
            public string ExchangeType { get; set; }

            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("FilterType")]
            [Validation(Required=false)]
            public string FilterType { get; set; }

            [NameInMap("FilterValue")]
            [Validation(Required=false)]
            public string FilterValue { get; set; }

            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("Persistence")]
            [Validation(Required=false)]
            public bool? Persistence { get; set; }

            [NameInMap("RoomInfo")]
            [Validation(Required=false)]
            public string RoomInfo { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("ZoneInfo")]
            [Validation(Required=false)]
            public string ZoneInfo { get; set; }

        }

    }

}
