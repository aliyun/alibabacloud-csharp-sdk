// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFacesRequest : TeaModel {
        [NameInMap("SourceImageType")]
        [Validation(Required=false)]
        public string SourceImageType { get; set; }

        [NameInMap("SourceImageValue")]
        [Validation(Required=false)]
        public string SourceImageValue { get; set; }

        [NameInMap("TargetImageType")]
        [Validation(Required=false)]
        public string TargetImageType { get; set; }

        [NameInMap("TargetImageValue")]
        [Validation(Required=false)]
        public string TargetImageValue { get; set; }

    }

}
