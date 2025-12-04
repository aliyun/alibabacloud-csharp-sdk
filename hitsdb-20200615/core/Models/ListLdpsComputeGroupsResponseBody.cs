// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class ListLdpsComputeGroupsResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<ListLdpsComputeGroupsResponseBodyGroupList> GroupList { get; set; }
        public class ListLdpsComputeGroupsResponseBodyGroupList : TeaModel {
            [NameInMap("ExceptionInfo")]
            [Validation(Required=false)]
            public string ExceptionInfo { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("WebUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
