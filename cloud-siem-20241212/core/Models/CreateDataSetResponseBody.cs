// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDataSetResponseBody : TeaModel {
        [NameInMap("DataSetRecordStatistic")]
        [Validation(Required=false)]
        public CreateDataSetResponseBodyDataSetRecordStatistic DataSetRecordStatistic { get; set; }
        public class CreateDataSetResponseBodyDataSetRecordStatistic : TeaModel {
            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public string DataSetId { get; set; }

            [NameInMap("NewDataSetRecordCount")]
            [Validation(Required=false)]
            public int? NewDataSetRecordCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
