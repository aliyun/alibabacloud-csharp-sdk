// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableLineageResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=true)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=true)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetMetaTableLineageResponseData Data { get; set; }
        public class GetMetaTableLineageResponseData : TeaModel {
            [NameInMap("HasNext")]
            [Validation(Required=true)]
            public bool? HasNext { get; set; }
            [NameInMap("NextPrimaryKey")]
            [Validation(Required=true)]
            public string NextPrimaryKey { get; set; }
            [NameInMap("DataEntityList")]
            [Validation(Required=true)]
            public List<GetMetaTableLineageResponseDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTableLineageResponseDataDataEntityList : TeaModel {
                public string TableName { get; set; }
                public string TableGuid { get; set; }
            }
        };

    }

}
