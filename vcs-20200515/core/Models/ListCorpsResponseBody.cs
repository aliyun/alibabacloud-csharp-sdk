// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListCorpsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCorpsResponseBodyData Data { get; set; }
        public class ListCorpsResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListCorpsResponseBodyDataRecords> Records { get; set; }
            public class ListCorpsResponseBodyDataRecords : TeaModel {
                public string ParentCorpId { get; set; }
                public string AppName { get; set; }
                public string IsvSubId { get; set; }
                public string Description { get; set; }
                public string CorpName { get; set; }
                public string CorpId { get; set; }
                public int? AcuUsed { get; set; }
                public string CreateDate { get; set; }
                public string IconPath { get; set; }
                public int? DeviceCount { get; set; }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
