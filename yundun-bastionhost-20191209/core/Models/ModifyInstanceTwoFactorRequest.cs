// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyInstanceTwoFactorRequest : TeaModel {
        [NameInMap("DingTalkConfig")]
        [Validation(Required=false)]
        public string DingTalkConfig { get; set; }

        [NameInMap("EnableTwoFactor")]
        [Validation(Required=false)]
        public string EnableTwoFactor { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MessageLanguage")]
        [Validation(Required=false)]
        public string MessageLanguage { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SkipTwoFactorTime")]
        [Validation(Required=false)]
        public string SkipTwoFactorTime { get; set; }

        [NameInMap("TwoFactorMethods")]
        [Validation(Required=false)]
        public string TwoFactorMethods { get; set; }

    }

}
