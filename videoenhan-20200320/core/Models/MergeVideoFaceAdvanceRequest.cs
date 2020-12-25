// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoFaceAdvanceRequest : TeaModel {
        [NameInMap("VideoURLObject")]
        [Validation(Required=true)]
        public Stream VideoURLObject { get; set; }

        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("PostURL")]
        [Validation(Required=false)]
        public string PostURL { get; set; }

        [NameInMap("ReferenceURL")]
        [Validation(Required=false)]
        public string ReferenceURL { get; set; }

    }

}
