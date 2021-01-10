// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ConfirmLinkefabricFabricSmartdeployconfigsRequest : TeaModel {
        [NameInMap("Context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        [NameInMap("AntxConfigsRepeatList")]
        [Validation(Required=false)]
        public List<string> AntxConfigsRepeatList { get; set; }

        [NameInMap("DrmConfigsRepeatList")]
        [Validation(Required=false)]
        public List<string> DrmConfigsRepeatList { get; set; }

    }

}
