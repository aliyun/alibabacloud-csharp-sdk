// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatRefDocInfo : TeaModel {
        [NameInMap("pageListInfo")]
        [Validation(Required=false)]
        public List<ChatRefDocPageInfo> PageListInfo { get; set; }

        [NameInMap("pages")]
        [Validation(Required=false)]
        public long? Pages { get; set; }

    }

}
