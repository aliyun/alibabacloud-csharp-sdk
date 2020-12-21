// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetPersonListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPersonListResponseBodyData Data { get; set; }
        public class GetPersonListResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetPersonListResponseBodyDataRecords> Records { get; set; }
            public class GetPersonListResponseBodyDataRecords : TeaModel {
                public List<GetPersonListResponseBodyDataRecordsPropertyTagList> PropertyTagList { get; set; }
                public class GetPersonListResponseBodyDataRecordsPropertyTagList : TeaModel {
                    public string Value { get; set; }
                    public string TagName { get; set; }
                    public string TagCodeName { get; set; }
                    public string Code { get; set; }
                }
                public string FaceUrl { get; set; }
                public string SearchMatchingRate { get; set; }
                public string PersonId { get; set; }
                public long LastShotTime { get; set; }
                public long FirstShotTime { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
