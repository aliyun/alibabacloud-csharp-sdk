// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceGroupByDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("GroupInfos")]
        [Validation(Required=false)]
        public QueryDeviceGroupByDeviceResponseBodyGroupInfos GroupInfos { get; set; }
        public class QueryDeviceGroupByDeviceResponseBodyGroupInfos : TeaModel {
            [NameInMap("GroupInfo")]
            [Validation(Required=false)]
            public List<QueryDeviceGroupByDeviceResponseBodyGroupInfosGroupInfo> GroupInfo { get; set; }
            public class QueryDeviceGroupByDeviceResponseBodyGroupInfosGroupInfo : TeaModel {
                [NameInMap("GroupDesc")]
                [Validation(Required=false)]
                public string GroupDesc { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
