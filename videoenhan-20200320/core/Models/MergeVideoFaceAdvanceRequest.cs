// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoFaceAdvanceRequest : TeaModel {
        [NameInMap("ReferenceURL")]
        [Validation(Required=false)]
        public Stream ReferenceURLObject { get; set; }

        [NameInMap("VideoURL")]
        [Validation(Required=false)]
        public Stream VideoURLObject { get; set; }

    }

}
