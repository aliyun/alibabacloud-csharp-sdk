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
                [NameInMap("AlertMethods")]
                [Validation(Required=false)]
                public List<string> AlertMethods { get; set; }

                [NameInMap("AlertTargets")]
                [Validation(Required=false)]
                public List<string> AlertTargets { get; set; }

                [NameInMap("AlertUnit")]
                [Validation(Required=false)]
                public string AlertUnit { get; set; }

                [NameInMap("BaselineIds")]
                [Validation(Required=false)]
                public List<long?> BaselineIds { get; set; }

                [NameInMap("BizProcessIds")]
                [Validation(Required=false)]
                public List<long?> BizProcessIds { get; set; }

                [NameInMap("DndEnd")]
                [Validation(Required=false)]
                public string DndEnd { get; set; }

                [NameInMap("DndStart")]
                [Validation(Required=false)]
                public string DndStart { get; set; }

                [NameInMap("Founder")]
                [Validation(Required=false)]
                public string Founder { get; set; }

                [NameInMap("NodeIds")]
                [Validation(Required=false)]
                public List<long?> NodeIds { get; set; }

                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<long?> ProjectIds { get; set; }

                [NameInMap("RemindId")]
                [Validation(Required=false)]
                public long? RemindId { get; set; }

                [NameInMap("RemindName")]
                [Validation(Required=false)]
                public string RemindName { get; set; }

                [NameInMap("RemindType")]
                [Validation(Required=false)]
                public string RemindType { get; set; }

                [NameInMap("RemindUnit")]
                [Validation(Required=false)]
                public string RemindUnit { get; set; }

                [NameInMap("Useflag")]
                [Validation(Required=false)]
                public bool? Useflag { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
