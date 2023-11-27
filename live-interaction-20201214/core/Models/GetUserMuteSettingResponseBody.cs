// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetUserMuteSettingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetUserMuteSettingResponseBodyResult Result { get; set; }
        public class GetUserMuteSettingResponseBodyResult : TeaModel {
            [NameInMap("UserMuteSettings")]
            [Validation(Required=false)]
            public Dictionary<string, ResultUserMuteSettingsValue> UserMuteSettings { get; set; }

        }

    }

}
