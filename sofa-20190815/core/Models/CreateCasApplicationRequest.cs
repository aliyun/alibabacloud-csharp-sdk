// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateCasApplicationRequest : TeaModel {
        [NameInMap("AppDomainId")]
        [Validation(Required=false)]
        public string AppDomainId { get; set; }

        [NameInMap("AppLevelId")]
        [Validation(Required=false)]
        public string AppLevelId { get; set; }

        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

        [NameInMap("BuildpackVersion")]
        [Validation(Required=false)]
        public string BuildpackVersion { get; set; }

        [NameInMap("ChineseName")]
        [Validation(Required=false)]
        public string ChineseName { get; set; }

        [NameInMap("CodeRepositoryExisted")]
        [Validation(Required=false)]
        public bool? CodeRepositoryExisted { get; set; }

        [NameInMap("CodeRepositoryGroupName")]
        [Validation(Required=false)]
        public string CodeRepositoryGroupName { get; set; }

        [NameInMap("CodeRepositoryName")]
        [Validation(Required=false)]
        public string CodeRepositoryName { get; set; }

        [NameInMap("CodeRepositoryType")]
        [Validation(Required=false)]
        public string CodeRepositoryType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
