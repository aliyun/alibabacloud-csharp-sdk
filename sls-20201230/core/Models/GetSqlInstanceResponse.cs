// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetSqlInstanceResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GetSqlInstanceResponseBody> Body { get; set; }
        public class GetSqlInstanceResponseBody : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public int? UpdateTime { get; set; }

            [NameInMap("useAsDefault")]
            [Validation(Required=false)]
            public bool? UseAsDefault { get; set; }

        }

    }

}
