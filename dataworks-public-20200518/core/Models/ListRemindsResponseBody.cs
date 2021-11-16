// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRemindsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRemindsResponseBodyData Data { get; set; }
        public class ListRemindsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Reminds")]
            [Validation(Required=false)]
            public List<ListRemindsResponseBodyDataReminds> Reminds { get; set; }
            public class ListRemindsResponseBodyDataReminds : TeaModel {
                public List<string> AlertMethods { get; set; }
                public List<string> AlertTargets { get; set; }
                public string AlertUnit { get; set; }
                public List<string> BaselineIds { get; set; }
                public List<string> BizProcessIds { get; set; }
                public string DndEnd { get; set; }
                public string DndStart { get; set; }
                public string Founder { get; set; }
                public List<string> NodeIds { get; set; }
                public List<string> ProjectIds { get; set; }
                public long? RemindId { get; set; }
                public string RemindName { get; set; }
                public string RemindType { get; set; }
                public string RemindUnit { get; set; }
                public bool? Useflag { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
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
