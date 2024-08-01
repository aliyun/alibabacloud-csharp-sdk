// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class SearchCustomLinesRequest : TeaModel {
        [NameInMap("CreateTimestampEnd")]
        [Validation(Required=false)]
        public long? CreateTimestampEnd { get; set; }

        [NameInMap("CreateTimestampStart")]
        [Validation(Required=false)]
        public long? CreateTimestampStart { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public List<string> Creator { get; set; }

        [NameInMap("Ipv4")]
        [Validation(Required=false)]
        public string Ipv4 { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("UpdateTimestampEnd")]
        [Validation(Required=false)]
        public long? UpdateTimestampEnd { get; set; }

        [NameInMap("UpdateTimestampStart")]
        [Validation(Required=false)]
        public long? UpdateTimestampStart { get; set; }

    }

}
