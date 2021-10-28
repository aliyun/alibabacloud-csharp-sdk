// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayCredentialResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ConsolePassword")]
        [Validation(Required=false)]
        public string ConsolePassword { get; set; }

        [NameInMap("ConsoleUsername")]
        [Validation(Required=false)]
        public string ConsoleUsername { get; set; }

        [NameInMap("EcsIp")]
        [Validation(Required=false)]
        public string EcsIp { get; set; }

        [NameInMap("EcsPassword")]
        [Validation(Required=false)]
        public string EcsPassword { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
