// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeFaceAdvanceRequest : TeaModel {
        [NameInMap("ImageURLObject")]
        [Validation(Required=true)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("Age")]
        [Validation(Required=false)]
        public bool? Age { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public bool? Gender { get; set; }

        [NameInMap("Hat")]
        [Validation(Required=false)]
        public bool? Hat { get; set; }

        [NameInMap("Glass")]
        [Validation(Required=false)]
        public bool? Glass { get; set; }

        [NameInMap("Beauty")]
        [Validation(Required=false)]
        public bool? Beauty { get; set; }

        [NameInMap("Expression")]
        [Validation(Required=false)]
        public bool? Expression { get; set; }

        [NameInMap("Mask")]
        [Validation(Required=false)]
        public bool? Mask { get; set; }

        [NameInMap("Quality")]
        [Validation(Required=false)]
        public bool? Quality { get; set; }

        [NameInMap("MaxFaceNumber")]
        [Validation(Required=false)]
        public long? MaxFaceNumber { get; set; }

    }

}
