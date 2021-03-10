// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceGroupByDeviceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("GroupInfos")]
        [Validation(Required=true)]
        public QueryDeviceGroupByDeviceResponseGroupInfos GroupInfos { get; set; }
        public class QueryDeviceGroupByDeviceResponseGroupInfos : TeaModel {
            [NameInMap("GroupInfo")]
            [Validation(Required=true)]
            public List<QueryDeviceGroupByDeviceResponseGroupInfosGroupInfo> GroupInfo { get; set; }
            public class QueryDeviceGroupByDeviceResponseGroupInfosGroupInfo : TeaModel {
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string UtcCreate { get; set; }
                public string GroupDesc { get; set; }
            }
        };

    }

}
