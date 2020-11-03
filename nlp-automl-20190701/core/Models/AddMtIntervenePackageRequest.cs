// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class AddMtIntervenePackageRequest : TeaModel {
        [NameInMap("PackageName")]
        [Validation(Required=true)]
        public string PackageName { get; set; }

        [NameInMap("SourceLanguage")]
        [Validation(Required=true)]
        public string SourceLanguage { get; set; }

        [NameInMap("TargetLanguage")]
        [Validation(Required=true)]
        public string TargetLanguage { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public int? ProjectId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
