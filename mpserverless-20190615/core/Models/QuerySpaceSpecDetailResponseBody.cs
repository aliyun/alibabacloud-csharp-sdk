// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class QuerySpaceSpecDetailResponseBody : TeaModel {
        [NameInMap("CsCdnTraffic")]
        [Validation(Required=false)]
        public long? CsCdnTraffic { get; set; }

        [NameInMap("CsDownloadCount")]
        [Validation(Required=false)]
        public long? CsDownloadCount { get; set; }

        [NameInMap("CsStorageSize")]
        [Validation(Required=false)]
        public long? CsStorageSize { get; set; }

        [NameInMap("CsUploadCount")]
        [Validation(Required=false)]
        public long? CsUploadCount { get; set; }

        [NameInMap("DbReadCount")]
        [Validation(Required=false)]
        public long? DbReadCount { get; set; }

        [NameInMap("DbStorageSize")]
        [Validation(Required=false)]
        public long? DbStorageSize { get; set; }

        [NameInMap("DbWriteCount")]
        [Validation(Required=false)]
        public long? DbWriteCount { get; set; }

        [NameInMap("FcCost")]
        [Validation(Required=false)]
        public long? FcCost { get; set; }

        [NameInMap("FcRequestCount")]
        [Validation(Required=false)]
        public long? FcRequestCount { get; set; }

        [NameInMap("FcTxTraffic")]
        [Validation(Required=false)]
        public long? FcTxTraffic { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpecCode")]
        [Validation(Required=false)]
        public string SpecCode { get; set; }

        [NameInMap("SpecDetailText")]
        [Validation(Required=false)]
        public string SpecDetailText { get; set; }

        [NameInMap("WhCdnTraffic")]
        [Validation(Required=false)]
        public long? WhCdnTraffic { get; set; }

        [NameInMap("WhStorageSize")]
        [Validation(Required=false)]
        public long? WhStorageSize { get; set; }

    }

}
