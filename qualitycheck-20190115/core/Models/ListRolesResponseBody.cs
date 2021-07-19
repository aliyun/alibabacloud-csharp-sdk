// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListRolesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRolesResponseBodyData Data { get; set; }
        public class ListRolesResponseBodyData : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyDataRole> Role { get; set; }
            public class ListRolesResponseBodyDataRole : TeaModel {
                public string DisplayName { get; set; }
                public string UpdateTime { get; set; }
                public string CreateTime { get; set; }
                public string Name { get; set; }
                public long? Id { get; set; }
                public int? Level { get; set; }
            }
        };

    }

}
