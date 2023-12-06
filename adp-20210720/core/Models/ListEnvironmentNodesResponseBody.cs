// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListEnvironmentNodesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListEnvironmentNodesResponseBodyData Data { get; set; }
        public class ListEnvironmentNodesResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<InstanceInfo> List { get; set; }

            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
