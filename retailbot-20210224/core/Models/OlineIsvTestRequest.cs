// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class OlineIsvTestRequest : TeaModel {
        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("AliyunAccountDTO")]
        [Validation(Required=false)]
        public OlineIsvTestRequestAliyunAccountDTO AliyunAccountDTO { get; set; }
        public class OlineIsvTestRequestAliyunAccountDTO : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }
        };

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public long? VersionId { get; set; }

    }

}
