// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPersonsResponseBodyData Data { get; set; }
        public class ListPersonsResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListPersonsResponseBodyDataRecords> Records { get; set; }
            public class ListPersonsResponseBodyDataRecords : TeaModel {
                public string PicUrl { get; set; }
                public List<ListPersonsResponseBodyDataRecordsTagList> TagList { get; set; }
                public class ListPersonsResponseBodyDataRecordsTagList : TeaModel {
                    public string TagValueId { get; set; }
                    public string TagName { get; set; }
                    public string TagCode { get; set; }
                    public string TagValue { get; set; }
                }
                public string FirstAppearTime { get; set; }
                public string PersonId { get; set; }
            }
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public string PageNo { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public string TotalPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
