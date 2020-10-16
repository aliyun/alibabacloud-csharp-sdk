// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListPersonsResponseData Data { get; set; }
        public class ListPersonsResponseData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=true)]
            public string PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public string PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public string TotalCount { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=true)]
            public string TotalPage { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<ListPersonsResponseDataRecords> Records { get; set; }
            public class ListPersonsResponseDataRecords : TeaModel {
                public string FirstAppearTime { get; set; }
                public string PersonId { get; set; }
                public string PicUrl { get; set; }
                public List<ListPersonsResponseDataRecordsTagList> TagList { get; set; }
                public class ListPersonsResponseDataRecordsTagList : TeaModel {
                    public string TagCode { get; set; }
                    public string TagName { get; set; }
                    public string TagValue { get; set; }
                    public string TagValueId { get; set; }
                }
            }
        };

    }

}
