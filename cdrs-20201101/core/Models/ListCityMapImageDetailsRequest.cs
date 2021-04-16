// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListCityMapImageDetailsRequest : TeaModel {
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("RecordNumber")]
        [Validation(Required=false)]
        public long? RecordNumber { get; set; }

        [NameInMap("TimeInterval")]
        [Validation(Required=false)]
        public string TimeInterval { get; set; }

    }

}
