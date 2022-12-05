// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListMessageAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListMessageAppResponseBodyResult Result { get; set; }
        public class ListMessageAppResponseBodyResult : TeaModel {
            [NameInMap("AppList")]
            [Validation(Required=false)]
            public List<ListMessageAppResponseBodyResultAppList> AppList { get; set; }
            public class ListMessageAppResponseBodyResultAppList : TeaModel {
                [NameInMap("AppConfig")]
                [Validation(Required=false)]
                public Dictionary<string, string> AppConfig { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
