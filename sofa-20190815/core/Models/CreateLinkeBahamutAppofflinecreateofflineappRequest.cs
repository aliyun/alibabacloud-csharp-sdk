// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeBahamutAppofflinecreateofflineappRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("ArchDomainId")]
        [Validation(Required=false)]
        public string ArchDomainId { get; set; }

        [NameInMap("ArchDomainName")]
        [Validation(Required=false)]
        public string ArchDomainName { get; set; }

        [NameInMap("CnName")]
        [Validation(Required=false)]
        public string CnName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("PriArchDomainId")]
        [Validation(Required=false)]
        public string PriArchDomainId { get; set; }

        [NameInMap("PriArchDomainName")]
        [Validation(Required=false)]
        public string PriArchDomainName { get; set; }

        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        [NameInMap("RepoUrl")]
        [Validation(Required=false)]
        public string RepoUrl { get; set; }

        [NameInMap("Station")]
        [Validation(Required=false)]
        public string Station { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ZoneMode")]
        [Validation(Required=false)]
        public string ZoneMode { get; set; }

        [NameInMap("DevOwnersRepeatList")]
        [Validation(Required=false)]
        public List<string> DevOwnersRepeatList { get; set; }

        [NameInMap("PeOwnersRepeatList")]
        [Validation(Required=false)]
        public List<string> PeOwnersRepeatList { get; set; }

        [NameInMap("TestOwnersRepeatList")]
        [Validation(Required=false)]
        public List<string> TestOwnersRepeatList { get; set; }

    }

}
