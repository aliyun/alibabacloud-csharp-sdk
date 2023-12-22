// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListInstanceRequest : TeaModel {
        /// <summary>
        /// The instance name.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The status of the instance. Valid values:
        /// 
        /// *   `PENDING`: The instance is being initialized.
        /// *   `INIT_ERROR`: The initialization of the instance fails.
        /// *   `STARTING`: The instance is being started.
        /// *   `RUNNING`: The instance is running.
        /// *   `STOPPING`: The instance is being stopped.
        /// *   `STOPPED`: The instance is stopped.
        /// *   `DELETING`: The instance is being deleted.
        /// *   `DELETED`: The instance is deleted.
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
