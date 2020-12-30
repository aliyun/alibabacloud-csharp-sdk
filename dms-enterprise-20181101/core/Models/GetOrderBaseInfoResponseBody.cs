// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOrderBaseInfoResponseBody : TeaModel {
        [NameInMap("OrderBaseInfo")]
        [Validation(Required=false)]
        public GetOrderBaseInfoResponseBodyOrderBaseInfo OrderBaseInfo { get; set; }
        public class GetOrderBaseInfoResponseBodyOrderBaseInfo : TeaModel {
            [NameInMap("RelatedUserNickList")]
            [Validation(Required=false)]
            public GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserNickList RelatedUserNickList { get; set; }
            public class GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserNickList : TeaModel {
                [NameInMap("UserNicks")]
                [Validation(Required=false)]
                public List<string> UserNicks { get; set; }

            }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }
            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public long? CommitterId { get; set; }
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }
            [NameInMap("RelatedUserList")]
            [Validation(Required=false)]
            public GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserList RelatedUserList { get; set; }
            public class GetOrderBaseInfoResponseBodyOrderBaseInfoRelatedUserList : TeaModel {
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }
            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }
            [NameInMap("PluginType")]
            [Validation(Required=false)]
            public string PluginType { get; set; }
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
