// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class EstimateStereoImageDepthAdvanceRequest : TeaModel {
        [NameInMap("LeftImageURL")]
        [Validation(Required=false)]
        public Stream LeftImageURLObject { get; set; }

        [NameInMap("RightImageURL")]
        [Validation(Required=false)]
        public Stream RightImageURLObject { get; set; }

    }

}
