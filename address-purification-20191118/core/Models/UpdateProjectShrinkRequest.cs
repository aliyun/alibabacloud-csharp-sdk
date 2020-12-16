// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Address_purification20191118.Models
{
    public class UpdateProjectShrinkRequest : TeaModel {
        [NameInMap("ServiceCode")]
        [Validation(Required=true)]
        public string ServiceCode { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=true)]
        public string ParametersShrink { get; set; }

    }

}
