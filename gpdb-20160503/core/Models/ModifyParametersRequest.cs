// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyParametersRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to forcibly restart the instance. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ForceRestartInstance")]
        [Validation(Required=false)]
        public bool? ForceRestartInstance { get; set; }

        /// <summary>
        /// The name and value of the parameter to be modified. Specify the parameter in the `<Parameter name>:<Parameter value>` format.
        /// 
        /// You can call the [DescribeParameters](https://help.aliyun.com/document_detail/208310.html) operation to query the parameters that can be modified.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

    }

}
