// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class SignInGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SignInGroupResponseBodyData Data { get; set; }
        public class SignInGroupResponseBodyData : TeaModel {
            [NameInMap("BreakCode")]
            [Validation(Required=false)]
            public string BreakCode { get; set; }

            [NameInMap("ChatDeviceId")]
            [Validation(Required=false)]
            public string ChatDeviceId { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("OutboundScenario")]
            [Validation(Required=false)]
            public bool? OutboundScenario { get; set; }

            [NameInMap("SignedSkillGroupIdList")]
            [Validation(Required=false)]
            public List<string> SignedSkillGroupIdList { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserState")]
            [Validation(Required=false)]
            public string UserState { get; set; }

            [NameInMap("WorkMode")]
            [Validation(Required=false)]
            public string WorkMode { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
