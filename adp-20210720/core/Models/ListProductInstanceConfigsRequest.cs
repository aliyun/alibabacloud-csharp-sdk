// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductInstanceConfigsRequest : TeaModel {
        [NameInMap("componentReleaseName")]
        [Validation(Required=false)]
        public string ComponentReleaseName { get; set; }

        [NameInMap("environmentUID")]
        [Validation(Required=false)]
        public string EnvironmentUID { get; set; }

        [NameInMap("fuzzy")]
        [Validation(Required=false)]
        public string Fuzzy { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("paramType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        [NameInMap("parameter")]
        [Validation(Required=false)]
        public string Parameter { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

    }

}
