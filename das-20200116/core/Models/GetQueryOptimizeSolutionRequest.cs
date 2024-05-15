// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeSolutionRequest : TeaModel {
        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **PolarDBMySQL**
        /// *   **PostgreSQL**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The instance ID. You can call the [GetQueryOptimizeDataStats](https://help.aliyun.com/document_detail/405261.html) operation to query the instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The tag ID. For more information, see [Query governance](https://help.aliyun.com/document_detail/290038.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        /// <summary>
        /// The SQL template ID. You can call the [GetQueryOptimizeDataStats](https://help.aliyun.com/document_detail/405261.html) operation to query the SQL template ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

    }

}
