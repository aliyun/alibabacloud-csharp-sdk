// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListComponentVersionsRequest : TeaModel {
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("platforms")]
        [Validation(Required=false)]
        public List<ListComponentVersionsRequestPlatforms> Platforms { get; set; }
        public class ListComponentVersionsRequestPlatforms : TeaModel {
            [NameInMap("architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            [NameInMap("os")]
            [Validation(Required=false)]
            public string Os { get; set; }

        }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
