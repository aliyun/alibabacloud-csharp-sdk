// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetUserResponseBodyData Data { get; set; }
        public class GetUserResponseBodyData : TeaModel {
            [NameInMap("DeviceExt")]
            [Validation(Required=false)]
            public string DeviceExt { get; set; }
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
            [NameInMap("DeviceState")]
            [Validation(Required=false)]
            public string DeviceState { get; set; }
            [NameInMap("DisplayId")]
            [Validation(Required=false)]
            public string DisplayId { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("WorkMode")]
            [Validation(Required=false)]
            public string WorkMode { get; set; }
        };

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
