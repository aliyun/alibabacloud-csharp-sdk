// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AttachApiProductRequest : TeaModel {
        [NameInMap("ApiProductId")]
        [Validation(Required=false)]
        public string ApiProductId { get; set; }

        [NameInMap("Apis")]
        [Validation(Required=false)]
        public List<AttachApiProductRequestApis> Apis { get; set; }
        public class AttachApiProductRequestApis : TeaModel {
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

        }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
