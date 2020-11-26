// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class UpdateAppPackageRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long Id { get; set; }

        [NameInMap("PackageUrl")]
        [Validation(Required=true)]
        public string PackageUrl { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("Debug")]
        [Validation(Required=false)]
        public bool? Debug { get; set; }

    }

}
