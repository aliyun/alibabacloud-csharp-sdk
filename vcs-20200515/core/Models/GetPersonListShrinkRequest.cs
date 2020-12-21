// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetPersonListShrinkRequest : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long PageSize { get; set; }

        [NameInMap("FaceUrl")]
        [Validation(Required=false)]
        public string FaceUrl { get; set; }

        [NameInMap("CorpIdList")]
        [Validation(Required=false)]
        public string CorpIdListShrink { get; set; }

        [NameInMap("FaceMatchingRateThreshold")]
        [Validation(Required=false)]
        public string FaceMatchingRateThreshold { get; set; }

        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("PersonIdList")]
        [Validation(Required=false)]
        public string PersonIdListShrink { get; set; }

    }

}
