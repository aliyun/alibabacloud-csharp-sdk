// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds_data20220330.Models
{
    public class InsertListResult : TeaModel {
        [NameInMap("AutoIncrementKeys")]
        [Validation(Required=false)]
        public List<long?> AutoIncrementKeys { get; set; }

        [NameInMap("NumberOfRecordsUpdated")]
        [Validation(Required=false)]
        public long? NumberOfRecordsUpdated { get; set; }

    }

}
