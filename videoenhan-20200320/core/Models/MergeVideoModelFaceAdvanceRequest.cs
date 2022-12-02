// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoModelFaceAdvanceRequest : TeaModel {
        [NameInMap("FaceImageURL")]
        [Validation(Required=false)]
        public Stream FaceImageURLObject { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
