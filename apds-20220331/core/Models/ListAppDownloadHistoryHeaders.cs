// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class ListAppDownloadHistoryHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("biz-module-code")]
        [Validation(Required=false)]
        public string BizModuleCode { get; set; }

        [NameInMap("tenant-proxy-uid")]
        [Validation(Required=false)]
        public string TenantProxyUid { get; set; }

    }

}
