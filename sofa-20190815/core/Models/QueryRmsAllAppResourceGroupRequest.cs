// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAllAppResourceGroupRequest : TeaModel {
        [NameInMap("EnvJsonStr")]
        [Validation(Required=false)]
        public string EnvJsonStr { get; set; }

        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
