// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class GetCrowdDatasetRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public GetCrowdDatasetRequestBody Body { get; set; }
        public class GetCrowdDatasetRequestBody : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

        }

    }

}
