// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryPictureSearchAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPictureSearchAppResponseBodyData Data { get; set; }
        public class QueryPictureSearchAppResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<QueryPictureSearchAppResponseBodyDataData> Data { get; set; }
            public class QueryPictureSearchAppResponseBodyDataData : TeaModel {
                public string AppInstanceId { get; set; }
                public long? ModifiedTime { get; set; }
                public string Version { get; set; }
                public long? CreateTime { get; set; }
                public string AppTemplateId { get; set; }
                public string Name { get; set; }
                public string Level { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
