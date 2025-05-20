// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatDocumentPageNum : TeaModel {
        [NameInMap("num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        [NameInMap("pos")]
        [Validation(Required=false)]
        public List<List<ChatRefDocPostion>> Pos { get; set; }

    }

}
