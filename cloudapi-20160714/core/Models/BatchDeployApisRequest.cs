// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class BatchDeployApisRequest : TeaModel {
        [NameInMap("Api")]
        [Validation(Required=false)]
        public List<BatchDeployApisRequestApi> Api { get; set; }
        public class BatchDeployApisRequestApi : TeaModel {
            [NameInMap("ApiUid")]
            [Validation(Required=false)]
            public string ApiUid { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
