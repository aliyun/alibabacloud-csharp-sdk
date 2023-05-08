// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAssetSelectionConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAssetSelectionConfigResponseBodyData Data { get; set; }
        public class CreateAssetSelectionConfigResponseBodyData : TeaModel {
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public long? SelectionKey { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
