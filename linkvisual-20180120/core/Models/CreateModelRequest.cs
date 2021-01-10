// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class CreateModelRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public long? AlgorithmId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ModelPackageStandard")]
        [Validation(Required=false)]
        public string ModelPackageStandard { get; set; }

        [NameInMap("Hardware")]
        [Validation(Required=false)]
        public string Hardware { get; set; }

        [NameInMap("UploadModelPath")]
        [Validation(Required=false)]
        public string UploadModelPath { get; set; }

        [NameInMap("NeedEncrypt")]
        [Validation(Required=false)]
        public bool? NeedEncrypt { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
