// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeprecateBuildpackRequest : TeaModel {
        [NameInMap("DepracationNoteMapJsonStr")]
        [Validation(Required=false)]
        public string DepracationNoteMapJsonStr { get; set; }

        [NameInMap("IdRepeatList")]
        [Validation(Required=false)]
        public List<string> IdRepeatList { get; set; }

    }

}
