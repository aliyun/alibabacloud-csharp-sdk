// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListClassesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListClassesResponseBodyResult Result { get; set; }
        public class ListClassesResponseBodyResult : TeaModel {
            [NameInMap("ClassList")]
            [Validation(Required=false)]
            public List<ListClassesResponseBodyResultClassList> ClassList { get; set; }
            public class ListClassesResponseBodyResultClassList : TeaModel {
                public string ClassId { get; set; }
                public string ConfId { get; set; }
                public string CreateNickname { get; set; }
                public string CreateUserId { get; set; }
                public long? EndTime { get; set; }
                public string LiveId { get; set; }
                public string RoomId { get; set; }
                public long? StartTime { get; set; }
                public int? Status { get; set; }
                public string Title { get; set; }
                public string WhiteboardId { get; set; }
                public string WhiteboardRecordId { get; set; }
            }
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
