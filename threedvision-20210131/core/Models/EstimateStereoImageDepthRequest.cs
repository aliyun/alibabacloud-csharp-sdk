// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class EstimateStereoImageDepthRequest : TeaModel {
        [NameInMap("LeftImageURL")]
        [Validation(Required=false)]
        public string LeftImageURL { get; set; }

        [NameInMap("RightImageURL")]
        [Validation(Required=false)]
        public string RightImageURL { get; set; }

    }

}
