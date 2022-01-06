// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceGroupTagListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceGroupTagListResponseBodyData Data { get; set; }
        public class QueryDeviceGroupTagListResponseBodyData : TeaModel {
            [NameInMap("GroupTagInfo")]
            [Validation(Required=false)]
            public List<QueryDeviceGroupTagListResponseBodyDataGroupTagInfo> GroupTagInfo { get; set; }
            public class QueryDeviceGroupTagListResponseBodyDataGroupTagInfo : TeaModel {
                public string TagKey { get; set; }
                public string TagValue { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
