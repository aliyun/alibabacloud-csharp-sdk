// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByWorkspaceRequest : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// 
        /// *   Default value: 1.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// 
        /// *   Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The status of the work. Valid values:
        /// 
        /// *   0: unpublished
        /// *   1: published
        /// *   2: modified but not published
        /// *   3: unpublished
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Third-party embedding status. Valid values:
        /// 
        /// *   0: The embed service is not enabled.
        /// *   1: Embed is enabled.
        /// </summary>
        [NameInMap("ThirdPartAuthFlag")]
        [Validation(Required=false)]
        public int? ThirdPartAuthFlag { get; set; }

        /// <summary>
        /// The type of the work. Valid values:
        /// 
        /// *   DATAPRODUCT: BI portal
        /// *   PAGE: Dashboard
        /// *   FULLPAGE: full-screen dashboards
        /// *   REPORT: workbook
        /// </summary>
        [NameInMap("WorksType")]
        [Validation(Required=false)]
        public string WorksType { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
