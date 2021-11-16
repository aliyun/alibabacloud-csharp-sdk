// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTableThemeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTableThemeResponseBodyData Data { get; set; }
        public class ListTableThemeResponseBodyData : TeaModel {
            [NameInMap("ThemeList")]
            [Validation(Required=false)]
            public List<ListTableThemeResponseBodyDataThemeList> ThemeList { get; set; }
            public class ListTableThemeResponseBodyDataThemeList : TeaModel {
                public long? CreateTimeStamp { get; set; }
                public string Creator { get; set; }
                public int? Level { get; set; }
                public string Name { get; set; }
                public long? ParentId { get; set; }
                public long? ProjectId { get; set; }
                public long? ThemeId { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
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
