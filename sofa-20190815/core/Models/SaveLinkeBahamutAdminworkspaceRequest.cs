// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveLinkeBahamutAdminworkspaceRequest : TeaModel {
        [NameInMap("AccessSecret")]
        [Validation(Required=false)]
        public string AccessSecret { get; set; }

        [NameInMap("BahamutAccessKey")]
        [Validation(Required=false)]
        public string BahamutAccessKey { get; set; }

        [NameInMap("CloudTenant")]
        [Validation(Required=false)]
        public string CloudTenant { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        [NameInMap("CrossCloud")]
        [Validation(Required=false)]
        public bool? CrossCloud { get; set; }

        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        [NameInMap("DefaultUse")]
        [Validation(Required=false)]
        public bool? DefaultUse { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public long? LastModified { get; set; }

        [NameInMap("LinkETenant")]
        [Validation(Required=false)]
        public string LinkETenant { get; set; }

        [NameInMap("Modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Use")]
        [Validation(Required=false)]
        public string Use { get; set; }

        [NameInMap("WorkspaceGroupId")]
        [Validation(Required=false)]
        public string WorkspaceGroupId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
