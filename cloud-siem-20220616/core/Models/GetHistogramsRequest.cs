// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetHistogramsRequest : TeaModel {
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
