// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class DescribeSitePairResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PrimarySiteId")]
        [Validation(Required=false)]
        public string PrimarySiteId { get; set; }

        [NameInMap("PrimarySiteName")]
        [Validation(Required=false)]
        public string PrimarySiteName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecondarySiteId")]
        [Validation(Required=false)]
        public string SecondarySiteId { get; set; }

        [NameInMap("SecondarySiteName")]
        [Validation(Required=false)]
        public string SecondarySiteName { get; set; }

        [NameInMap("SitePairId")]
        [Validation(Required=false)]
        public string SitePairId { get; set; }

        [NameInMap("SitePairType")]
        [Validation(Required=false)]
        public string SitePairType { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
