// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySuperDeviceGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySuperDeviceGroupResponseBodyData Data { get; set; }
        public class QuerySuperDeviceGroupResponseBodyData : TeaModel {
            [NameInMap("GroupInfo")]
            [Validation(Required=false)]
            public List<QuerySuperDeviceGroupResponseBodyDataGroupInfo> GroupInfo { get; set; }
            public class QuerySuperDeviceGroupResponseBodyDataGroupInfo : TeaModel {
                public string GroupDesc { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
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
