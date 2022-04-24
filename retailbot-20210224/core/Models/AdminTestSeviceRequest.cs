// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class AdminTestSeviceRequest : TeaModel {
        [NameInMap("AliyunAccountDTO")]
        [Validation(Required=false)]
        public AdminTestSeviceRequestAliyunAccountDTO AliyunAccountDTO { get; set; }
        public class AdminTestSeviceRequestAliyunAccountDTO : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }
        };

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public long? VersionId { get; set; }

    }

}
