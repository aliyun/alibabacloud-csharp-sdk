// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class PunishResourceSearchResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<PunishResourceSearchResponseBodyDataList> DataList { get; set; }
        public class PunishResourceSearchResponseBodyDataList : TeaModel {
            [NameInMap("ActionCode")]
            [Validation(Required=false)]
            public string ActionCode { get; set; }

            [NameInMap("BussinessCode")]
            [Validation(Required=false)]
            public string BussinessCode { get; set; }

            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

            [NameInMap("Coordinate")]
            [Validation(Required=false)]
            public string Coordinate { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Extras")]
            [Validation(Required=false)]
            public string Extras { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            [NameInMap("ObjectValue")]
            [Validation(Required=false)]
            public string ObjectValue { get; set; }

            [NameInMap("PunishFrom")]
            [Validation(Required=false)]
            public string PunishFrom { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public long? RequestId { get; set; }

            [NameInMap("SourceCode")]
            [Validation(Required=false)]
            public string SourceCode { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ViewCount")]
        [Validation(Required=false)]
        public int? ViewCount { get; set; }

    }

}
