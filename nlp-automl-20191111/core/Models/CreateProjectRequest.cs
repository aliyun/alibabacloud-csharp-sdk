// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class CreateProjectRequest : TeaModel {
        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("ProjectDescription")]
        [Validation(Required=false)]
        public string ProjectDescription { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
