// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ft20180713.Models
{
    public class FtDynamicAddressHttpVpcShrinkRequest : TeaModel {
        [NameInMap("BooleanParam")]
        [Validation(Required=false)]
        public bool? BooleanParam { get; set; }

        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValueShrink { get; set; }

        [NameInMap("OtherParam")]
        [Validation(Required=false)]
        public string OtherParamShrink { get; set; }

        [NameInMap("P1")]
        [Validation(Required=false)]
        public string P1 { get; set; }

        [NameInMap("StringValue")]
        [Validation(Required=false)]
        public string StringValueShrink { get; set; }

    }

}
