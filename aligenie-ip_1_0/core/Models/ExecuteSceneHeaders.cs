// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ExecuteSceneHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("x-acs-aligenie-access-token")]
        [Validation(Required=false)]
        public string XAcsAligenieAccessToken { get; set; }

        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

    }

}
