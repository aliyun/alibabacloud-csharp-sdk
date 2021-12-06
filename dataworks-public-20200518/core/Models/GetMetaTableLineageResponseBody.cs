// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableLineageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTableLineageResponseBodyData Data { get; set; }
        public class GetMetaTableLineageResponseBodyData : TeaModel {
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaTableLineageResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTableLineageResponseBodyDataDataEntityList : TeaModel {
                public long? CreateTimestamp { get; set; }
                public string TableGuid { get; set; }
                public string TableName { get; set; }
            }
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }
            [NameInMap("NextPrimaryKey")]
            [Validation(Required=false)]
            public string NextPrimaryKey { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
