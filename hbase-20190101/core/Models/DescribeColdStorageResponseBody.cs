// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeColdStorageResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ColdStorageSize")]
        [Validation(Required=false)]
        public string ColdStorageSize { get; set; }

        [NameInMap("ColdStorageType")]
        [Validation(Required=false)]
        public string ColdStorageType { get; set; }

        [NameInMap("ColdStorageUseAmount")]
        [Validation(Required=false)]
        public string ColdStorageUseAmount { get; set; }

        [NameInMap("ColdStorageUsePercent")]
        [Validation(Required=false)]
        public string ColdStorageUsePercent { get; set; }

        [NameInMap("OpenStatus")]
        [Validation(Required=false)]
        public string OpenStatus { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
