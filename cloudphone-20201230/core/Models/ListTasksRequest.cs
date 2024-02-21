// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. Valid values: 1 to 100. Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The task IDs. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public List<string> TaskId { get; set; }

        /// <summary>
        /// The task state. Valid values:
        /// 
        /// *   Finished
        /// *   Processing
        /// *   Failed
        /// 
        /// This parameter is empty by default.
        /// 
        /// >  The system only queries tasks that are in the Finished, Processing, and Failed states and ignores other values.
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// The name of the operation that you can call to execute the task on the instance. Valid values:
        /// 
        /// *   Shell: runs a shell command.
        /// *   InstallApplication: installs an application.
        /// *   UninstallApplication: uninstalls an application.
        /// *   SendFile: uploads a file.
        /// *   ImportImage: imports an image.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
