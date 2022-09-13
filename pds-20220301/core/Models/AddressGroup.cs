// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AddressGroup : TeaModel {
        [NameInMap("address_detail")]
        [Validation(Required=false)]
        public Address AddressDetail { get; set; }

        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("cover_file_id")]
        [Validation(Required=false)]
        public string CoverFileId { get; set; }

        [NameInMap("cover_url")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
