// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GetDingTalkUserOrgByAliyunTmpCodeRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DingTalkChannel")]
        [Validation(Required=false)]
        public string DingTalkChannel { get; set; }

        [NameInMap("TmpCode")]
        [Validation(Required=false)]
        public string TmpCode { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
