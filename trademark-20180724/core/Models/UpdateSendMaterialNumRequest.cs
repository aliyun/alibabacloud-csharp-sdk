// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class UpdateSendMaterialNumRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Num")]
        [Validation(Required=false)]
        public string Num { get; set; }

        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

    }

}
