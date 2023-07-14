// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceDashboardSync : TeaModel {
        [NameInMap("dashboardTitle")]
        [Validation(Required=false)]
        public string DashboardTitle { get; set; }

        [NameInMap("dashboardURL")]
        [Validation(Required=false)]
        public string DashboardURL { get; set; }

        [NameInMap("dashboardUid")]
        [Validation(Required=false)]
        public string DashboardUid { get; set; }

        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("folderTitle")]
        [Validation(Required=false)]
        public string FolderTitle { get; set; }

        [NameInMap("folderURL")]
        [Validation(Required=false)]
        public string FolderURL { get; set; }

        [NameInMap("folderUid")]
        [Validation(Required=false)]
        public string FolderUid { get; set; }

        [NameInMap("orgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
