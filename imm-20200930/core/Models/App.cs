// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class App : TeaModel {
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppRegion")]
        [Validation(Required=false)]
        public long? AppRegion { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public long? AppType { get; set; }

        [NameInMap("EnglishName")]
        [Validation(Required=false)]
        public string EnglishName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("PackageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

    }

}
