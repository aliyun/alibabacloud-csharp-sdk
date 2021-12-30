// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceTwoFactorResponseBody : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetInstanceTwoFactorResponseBodyConfig Config { get; set; }
        public class GetInstanceTwoFactorResponseBodyConfig : TeaModel {
            [NameInMap("DingTalkConfig")]
            [Validation(Required=false)]
            public GetInstanceTwoFactorResponseBodyConfigDingTalkConfig DingTalkConfig { get; set; }
            public class GetInstanceTwoFactorResponseBodyConfigDingTalkConfig : TeaModel {
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                [NameInMap("HasAppSecret")]
                [Validation(Required=false)]
                public bool? HasAppSecret { get; set; }

            }
            [NameInMap("EnableTwoFactor")]
            [Validation(Required=false)]
            public bool? EnableTwoFactor { get; set; }
            [NameInMap("MessageLanguage")]
            [Validation(Required=false)]
            public string MessageLanguage { get; set; }
            [NameInMap("SkipTwoFactorTime")]
            [Validation(Required=false)]
            public long? SkipTwoFactorTime { get; set; }
            [NameInMap("TwoFactorMethods")]
            [Validation(Required=false)]
            public List<string> TwoFactorMethods { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
