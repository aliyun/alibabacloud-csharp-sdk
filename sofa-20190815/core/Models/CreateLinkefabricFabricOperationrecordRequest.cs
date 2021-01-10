// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkefabricFabricOperationrecordRequest : TeaModel {
        [NameInMap("OperationRecordContext")]
        [Validation(Required=false)]
        public string OperationRecordContext { get; set; }

        [NameInMap("OperationRecordVoListRepeatList")]
        [Validation(Required=false)]
        public List<string> OperationRecordVoListRepeatList { get; set; }

    }

}
