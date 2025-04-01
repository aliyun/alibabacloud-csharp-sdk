// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class SourceConfig : TeaModel {
        [NameInMap("oss")]
        [Validation(Required=false)]
        public OpenStructOssSourceConfig Oss { get; set; }

        [NameInMap("repository")]
        [Validation(Required=false)]
        public RepositorySourceConfig Repository { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public TemplateSourceConfig Template { get; set; }

    }

}
