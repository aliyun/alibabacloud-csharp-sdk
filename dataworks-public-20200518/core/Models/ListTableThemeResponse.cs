// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTableThemeResponse : TeaModel {
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
        public ListTableThemeResponseData Data { get; set; }
        public class ListTableThemeResponseData : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long? TotalCount { get; set; }
            [NameInMap("ThemeList")]
            [Validation(Required=true)]
            public List<ListTableThemeResponseDataThemeList> ThemeList { get; set; }
            public class ListTableThemeResponseDataThemeList : TeaModel {
                public long? ThemeId { get; set; }
                public string Name { get; set; }
                public int? Level { get; set; }
                public long? ParentId { get; set; }
                public long? ProjectId { get; set; }
                public string Creator { get; set; }
                public long? CreateTimeStamp { get; set; }
            }
        };

    }

}
