// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeBahamutAdmincreatebasejarRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BaseJarInfo")]
        [Validation(Required=false)]
        public string BaseJarInfo { get; set; }

        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        [NameInMap("RepoUrl")]
        [Validation(Required=false)]
        public string RepoUrl { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("DevOwnerRepeatList")]
        [Validation(Required=false)]
        public List<string> DevOwnerRepeatList { get; set; }

        [NameInMap("ModuleListRepeatList")]
        [Validation(Required=false)]
        public List<string> ModuleListRepeatList { get; set; }

        [NameInMap("TestOwnerRepeatList")]
        [Validation(Required=false)]
        public List<string> TestOwnerRepeatList { get; set; }

    }

}
