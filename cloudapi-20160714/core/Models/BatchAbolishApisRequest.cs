// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class BatchAbolishApisRequest : TeaModel {
        [NameInMap("Api")]
        [Validation(Required=false)]
        public List<BatchAbolishApisRequestApi> Api { get; set; }
        public class BatchAbolishApisRequestApi : TeaModel {
            [NameInMap("ApiUid")]
            [Validation(Required=false)]
            public string ApiUid { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("StageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

        }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
