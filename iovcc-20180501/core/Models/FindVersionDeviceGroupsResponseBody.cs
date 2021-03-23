// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindVersionDeviceGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceGroupList")]
        [Validation(Required=false)]
        public FindVersionDeviceGroupsResponseBodyDeviceGroupList DeviceGroupList { get; set; }
        public class FindVersionDeviceGroupsResponseBodyDeviceGroupList : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindVersionDeviceGroupsResponseBodyDeviceGroupListItems> Items { get; set; }
            public class FindVersionDeviceGroupsResponseBodyDeviceGroupListItems : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public string Description { get; set; }
                public string MaxCount { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifyTimestamp { get; set; }
            }
        };

    }

}
