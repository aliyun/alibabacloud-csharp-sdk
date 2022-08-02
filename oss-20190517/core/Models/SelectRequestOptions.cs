// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class SelectRequestOptions : TeaModel {
        [NameInMap("MaxSkippedRecordsAllowed")]
        [Validation(Required=false)]
        public long? MaxSkippedRecordsAllowed { get; set; }

        [NameInMap("SkipPartialDataRecord")]
        [Validation(Required=false)]
        public bool? SkipPartialDataRecord { get; set; }

    }

}
