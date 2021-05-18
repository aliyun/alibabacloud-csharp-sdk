// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineCallActionResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotlineCallActionResponseBodyData Data { get; set; }
        public class GetHotlineCallActionResponseBodyData : TeaModel {
            [NameInMap("TouchId")]
            [Validation(Required=false)]
            public long? TouchId { get; set; }
            [NameInMap("DepId")]
            [Validation(Required=false)]
            public long? DepId { get; set; }
            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }
            [NameInMap("ServicerName")]
            [Validation(Required=false)]
            public string ServicerName { get; set; }
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public long? ChannelType { get; set; }
            [NameInMap("ActionId")]
            [Validation(Required=false)]
            public long? ActionId { get; set; }
            [NameInMap("CalloutName")]
            [Validation(Required=false)]
            public string CalloutName { get; set; }
            [NameInMap("SubTouchId")]
            [Validation(Required=false)]
            public long? SubTouchId { get; set; }
            [NameInMap("ServicerId")]
            [Validation(Required=false)]
            public long? ServicerId { get; set; }
            [NameInMap("BuId")]
            [Validation(Required=false)]
            public long? BuId { get; set; }
            [NameInMap("CalloutId")]
            [Validation(Required=false)]
            public long? CalloutId { get; set; }
            [NameInMap("CaseId")]
            [Validation(Required=false)]
            public long? CaseId { get; set; }
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }
            [NameInMap("IsTransfer")]
            [Validation(Required=false)]
            public string IsTransfer { get; set; }
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public string MemberList { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
