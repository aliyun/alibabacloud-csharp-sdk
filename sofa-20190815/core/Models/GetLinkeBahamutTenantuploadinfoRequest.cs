// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutTenantuploadinfoRequest : TeaModel {
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("Folder")]
        [Validation(Required=false)]
        public string Folder { get; set; }

        [NameInMap("TenantPath")]
        [Validation(Required=false)]
        public string TenantPath { get; set; }

    }

}
