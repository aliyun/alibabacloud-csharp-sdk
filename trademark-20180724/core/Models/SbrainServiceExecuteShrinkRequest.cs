// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class SbrainServiceExecuteShrinkRequest : TeaModel {
        [NameInMap("ExecuteParams")]
        [Validation(Required=false)]
        public string ExecuteParamsShrink { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ReferenceNo")]
        [Validation(Required=false)]
        public string ReferenceNo { get; set; }

        [NameInMap("ReferenceType")]
        [Validation(Required=false)]
        public string ReferenceType { get; set; }

        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("SchemeId")]
        [Validation(Required=false)]
        public long? SchemeId { get; set; }

        [NameInMap("ServicePlace")]
        [Validation(Required=false)]
        public string ServicePlace { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
