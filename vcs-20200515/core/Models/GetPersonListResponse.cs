// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetPersonListResponse : TeaModel {
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
        public GetPersonListResponseData Data { get; set; }
        public class GetPersonListResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public long PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public long PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<GetPersonListResponseDataRecords> Records { get; set; }
            public class GetPersonListResponseDataRecords : TeaModel {
                public string FaceUrl { get; set; }
                public long FirstShotTime { get; set; }
                public string PersonId { get; set; }
                public string SearchMatchingRate { get; set; }
                public long LastShotTime { get; set; }
                public List<GetPersonListResponseDataRecordsPropertyTagList> PropertyTagList { get; set; }
                public class GetPersonListResponseDataRecordsPropertyTagList : TeaModel {
                    public string Code { get; set; }
                    public string TagCodeName { get; set; }
                    public string TagName { get; set; }
                    public string Value { get; set; }
                }
            }
        };

    }

}
