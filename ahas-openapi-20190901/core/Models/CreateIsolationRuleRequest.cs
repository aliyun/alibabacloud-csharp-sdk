// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class CreateIsolationRuleRequest : TeaModel {
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("RelationStrategy")]
        [Validation(Required=false)]
        public int? RelationStrategy { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("LimitOrigin")]
        [Validation(Required=false)]
        public string LimitOrigin { get; set; }

        [NameInMap("RefResource")]
        [Validation(Required=false)]
        public string RefResource { get; set; }

        [NameInMap("AhasRegionId")]
        [Validation(Required=false)]
        public string AhasRegionId { get; set; }

    }

}
