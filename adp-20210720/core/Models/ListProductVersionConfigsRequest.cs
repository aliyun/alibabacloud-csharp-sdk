// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductVersionConfigsRequest : TeaModel {
        [NameInMap("componentReleaseName")]
        [Validation(Required=false)]
        public string ComponentReleaseName { get; set; }

        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("fuzzy")]
        [Validation(Required=false)]
        public string Fuzzy { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("parameter")]
        [Validation(Required=false)]
        public string Parameter { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
