// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetEnvironmentRequest : TeaModel {
        [NameInMap("options")]
        [Validation(Required=false)]
        public GetEnvironmentRequestOptions Options { get; set; }
        public class GetEnvironmentRequestOptions : TeaModel {
            [NameInMap("withSiteSurveyReport")]
            [Validation(Required=false)]
            public bool? WithSiteSurveyReport { get; set; }

        }

    }

}
