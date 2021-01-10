// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSClientsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryTSClientsResponseBodyList> List { get; set; }
        public class QueryTSClientsResponseBodyList : TeaModel {
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
