// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDagResponse : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=true)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=true)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetDagResponseData Data { get; set; }
        public class GetDagResponseData : TeaModel {
            [NameInMap("ProjectId")]
            [Validation(Required=true)]
            public long ProjectId { get; set; }
            [NameInMap("DagId")]
            [Validation(Required=true)]
            public long DagId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }
            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("Bizdate")]
            [Validation(Required=true)]
            public long Bizdate { get; set; }
            [NameInMap("Gmtdate")]
            [Validation(Required=true)]
            public long Gmtdate { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public long StartTime { get; set; }
            [NameInMap("FinishTime")]
            [Validation(Required=true)]
            public long FinishTime { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public long CreateTime { get; set; }
            [NameInMap("CreateUser")]
            [Validation(Required=true)]
            public string CreateUser { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=true)]
            public long ModifyTime { get; set; }
        };

    }

}
