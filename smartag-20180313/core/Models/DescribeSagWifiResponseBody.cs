// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagWifiResponseBody : TeaModel {
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public string IsEnable { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IsAuth")]
        [Validation(Required=false)]
        public string IsAuth { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("Ssid")]
        [Validation(Required=false)]
        public string Ssid { get; set; }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagWifiResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagWifiResponseBodyTaskStates : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        [NameInMap("IsBroadcast")]
        [Validation(Required=false)]
        public string IsBroadcast { get; set; }

    }

}
