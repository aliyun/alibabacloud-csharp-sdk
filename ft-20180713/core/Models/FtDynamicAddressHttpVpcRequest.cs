// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ft20180713.Models
{
    public class FtDynamicAddressHttpVpcRequest : TeaModel {
        [NameInMap("BooleanParam")]
        [Validation(Required=false)]
        public bool? BooleanParam { get; set; }

        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public Dictionary<string, object> DefaultValue { get; set; }

        [NameInMap("OtherParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> OtherParam { get; set; }

        [NameInMap("P1")]
        [Validation(Required=false)]
        public string P1 { get; set; }

        [NameInMap("StringValue")]
        [Validation(Required=false)]
        public Dictionary<string, object> StringValue { get; set; }

    }

}
