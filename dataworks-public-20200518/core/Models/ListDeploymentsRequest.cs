// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDeploymentsRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account used by the user who creates the deployment packages.
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// The time when the deployment packages to be queried are created. This value must be a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        /// <summary>
        /// The time when the deployment packages are run. This value must be a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("EndExecuteTime")]
        [Validation(Required=false)]
        public long? EndExecuteTime { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account used by the user who runs the deployment packages.
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public string Executor { get; set; }

        /// <summary>
        /// The keyword that is contained in the names of the deployment packages. A fuzzy search is supported. After you enter a keyword, all deployment packages whose names contain the keyword are displayed.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the workspace ID.
        /// 
        /// You must configure either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace to which the operation is applied.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the workspace name.
        /// 
        /// You must configure either this parameter or the ProjectId parameter to determine the DataWorks workspace to which the operation is applied.
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// The status of the deployment packages. Valid values:
        /// 
        /// *   0: The deployment packages are ready.
        /// *   1: The deployment packages are deployed.
        /// *   2: The deployment packages fail to be deployed.
        /// *   6: The deployment packages are rejected.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
