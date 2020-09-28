// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidTagsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("PidTagList")]
        [Validation(Required=true)]
        public List<ListPidTagsResponsePidTagList> PidTagList { get; set; }
        public class ListPidTagsResponsePidTagList : TeaModel {
            [NameInMap("PidTagId")]
            [Validation(Required=true)]
            public string PidTagId { get; set; }

            [NameInMap("PidProjectId")]
            [Validation(Required=true)]
            public string PidProjectId { get; set; }

            [NameInMap("PidTagName")]
            [Validation(Required=true)]
            public string PidTagName { get; set; }

            [NameInMap("PidTagType")]
            [Validation(Required=true)]
            public string PidTagType { get; set; }

            [NameInMap("UploadProjectId")]
            [Validation(Required=true)]
            public long UploadProjectId { get; set; }

        }

    }

}
