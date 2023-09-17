// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutAnnotationDataRequest : TeaModel {
        [NameInMap("annotationdataId")]
        [Validation(Required=false)]
        public string AnnotationdataId { get; set; }

        [NameInMap("mlDataParam")]
        [Validation(Required=false)]
        public MLDataParam MlDataParam { get; set; }

        [NameInMap("rawLog")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> RawLog { get; set; }

    }

}
