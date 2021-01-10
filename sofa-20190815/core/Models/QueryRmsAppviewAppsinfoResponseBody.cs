// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAppviewAppsinfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsAppviewAppsinfoResponseBodyResponse Response { get; set; }
        public class QueryRmsAppviewAppsinfoResponseBodyResponse : TeaModel {
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public QueryRmsAppviewAppsinfoResponseBodyResponseEntity Entity { get; set; }
            public class QueryRmsAppviewAppsinfoResponseBodyResponseEntity : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<QueryRmsAppviewAppsinfoResponseBodyResponseEntityData> Data { get; set; }
                public class QueryRmsAppviewAppsinfoResponseBodyResponseEntityData : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("UtcCreated")]
                    [Validation(Required=false)]
                    public string UtcCreated { get; set; }

                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public string UtcModified { get; set; }

                }

            }
        };

    }

}
