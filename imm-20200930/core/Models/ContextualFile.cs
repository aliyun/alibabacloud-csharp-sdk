// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualFile : TeaModel {
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("Elements")]
        [Validation(Required=false)]
        public List<Element> Elements { get; set; }

        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
