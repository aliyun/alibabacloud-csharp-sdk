// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class BatchSaveInstructionStatusRequest : TeaModel {
        [NameInMap("factoryId")]
        [Validation(Required=false)]
        public string FactoryId { get; set; }

        [NameInMap("pKey")]
        [Validation(Required=false)]
        public string PKey { get; set; }

        [NameInMap("statusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

    }

}
