// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAllResourceGroupsResponseBody : TeaModel {
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
        public QueryRmsAllResourceGroupsResponseBodyResponse Response { get; set; }
        public class QueryRmsAllResourceGroupsResponseBodyResponse : TeaModel {
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("ErrResolution")]
            [Validation(Required=false)]
            public string ErrResolution { get; set; }
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<QueryRmsAllResourceGroupsResponseBodyResponseEntities> Entities { get; set; }
            public class QueryRmsAllResourceGroupsResponseBodyResponseEntities : TeaModel {
                [NameInMap("ResId")]
                [Validation(Required=false)]
                public string ResId { get; set; }

                [NameInMap("ResName")]
                [Validation(Required=false)]
                public string ResName { get; set; }

            }
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public List<QueryRmsAllResourceGroupsResponseBodyResponseMeta> Meta { get; set; }
            public class QueryRmsAllResourceGroupsResponseBodyResponseMeta : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
