// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductVersionsRequest : TeaModel {
        [NameInMap("fuzzy")]
        [Validation(Required=false)]
        public string Fuzzy { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("platforms")]
        [Validation(Required=false)]
        public List<ListProductVersionsRequestPlatforms> Platforms { get; set; }
        public class ListProductVersionsRequestPlatforms : TeaModel {
            [NameInMap("architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            [NameInMap("os")]
            [Validation(Required=false)]
            public string Os { get; set; }

        }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("productUID")]
        [Validation(Required=false)]
        public string ProductUID { get; set; }

        [NameInMap("released")]
        [Validation(Required=false)]
        public bool? Released { get; set; }

        [NameInMap("supportedFoundationTypes")]
        [Validation(Required=false)]
        public List<string> SupportedFoundationTypes { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public ListProductVersionsRequestTag Tag { get; set; }
        public class ListProductVersionsRequestTag : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
