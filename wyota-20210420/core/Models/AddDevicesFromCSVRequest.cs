// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class AddDevicesFromCSVRequest : TeaModel {
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        [NameInMap("SeatCol")]
        [Validation(Required=false)]
        public int? SeatCol { get; set; }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

    }

}
