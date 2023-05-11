// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDeviceDistributeJobRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// 
        /// The **NextToken** or **CurrentPage** parameter specifies a condition for displaying the results. You can specify one of the two parameters. If you specify both parameters at the same time, the **NextToken parameter** is used.
        /// 
        /// For information about the **NextToken** parameter, see the description of the **NextToken** parameter.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the distribution task. The ID is globally unique.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The token that is used to retrieve subsequent pages of the query results. The first time you perform a query operation, you do not need to specify this parameter.
        /// 
        /// The **NextToken** or **CurrentPage** parameter specifies a condition for displaying the results. You can specify one of the two parameters. If you specify both parameters at the same time, the **NextToken** parameter is used.
        /// 
        /// 
        /// 
        /// **Important**
        /// 
        /// The offset in the number of results is obtained by using the following formula: **PageSize** × (**CurrentPage** - 1).
        /// 
        /// If the offset is greater than 10,000, you must use the token that is returned in the previous query as the value of the **NextToken** parameter to obtain the value of the **Data** parameter. Otherwise, the current request is terminated and the value of the **Data** parameter cannot be returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 200.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the device belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The status of the device distribution task.
        /// 
        /// *   **0**: The task is being initialized.
        /// *   **1**: The task is running.
        /// *   **2**: The task is completed. The status indicates that the distribution task is complete but does not indicate that all products and devices are distributed. To obtain distribution results, call the [QueryDeviceDistributeDetail](~~199533~~) operation.
        /// *   **3**: The task is unexpectedly interrupted.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the devices are distributed.
        /// </summary>
        [NameInMap("TargetUid")]
        [Validation(Required=false)]
        public string TargetUid { get; set; }

    }

}
