// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class SlotStatusDetail : TeaModel {
        [NameInMap("LoadedFileNum")]
        [Validation(Required=false)]
        public long? LoadedFileNum { get; set; }

        [NameInMap("LoadedFileSize")]
        [Validation(Required=false)]
        public string LoadedFileSize { get; set; }

        [NameInMap("LoadingTimeCost")]
        [Validation(Required=false)]
        public long? LoadingTimeCost { get; set; }

    }

}
