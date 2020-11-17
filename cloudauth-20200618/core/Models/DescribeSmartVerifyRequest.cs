// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class DescribeSmartVerifyRequest : TeaModel {
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long SceneId { get; set; }

        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

    }

}
