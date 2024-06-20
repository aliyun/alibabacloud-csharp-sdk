// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeFabricOrganizationChaincodesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeFabricOrganizationChaincodesResponseBodyResult> Result { get; set; }
        public class DescribeFabricOrganizationChaincodesResponseBodyResult : TeaModel {
            [NameInMap("ChaincodeId")]
            [Validation(Required=false)]
            public string ChaincodeId { get; set; }

            [NameInMap("ChaincodeName")]
            [Validation(Required=false)]
            public string ChaincodeName { get; set; }

            [NameInMap("ChaincodeVersion")]
            [Validation(Required=false)]
            public string ChaincodeVersion { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            [NameInMap("ConsortiumId")]
            [Validation(Required=false)]
            public string ConsortiumId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public string DeployTime { get; set; }

            [NameInMap("EndorsePolicy")]
            [Validation(Required=false)]
            public string EndorsePolicy { get; set; }

            [NameInMap("Installed")]
            [Validation(Required=false)]
            public string Installed { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
