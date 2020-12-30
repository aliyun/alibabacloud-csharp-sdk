// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class CreatePkgVersionResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PkgVersion")]
        [Validation(Required=false)]
        public CreatePkgVersionResponseBodyPkgVersion PkgVersion { get; set; }
        public class CreatePkgVersionResponseBodyPkgVersion : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("PkgVersionLabel")]
            [Validation(Required=false)]
            public string PkgVersionLabel { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("PackageSource")]
            [Validation(Required=false)]
            public string PackageSource { get; set; }
            [NameInMap("PkgVersionId")]
            [Validation(Required=false)]
            public string PkgVersionId { get; set; }
            [NameInMap("PkgVersionDescription")]
            [Validation(Required=false)]
            public string PkgVersionDescription { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
