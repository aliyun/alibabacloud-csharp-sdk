// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateQueryOptimizeTagRequest : TeaModel {
        /// <summary>
        /// The remarks.
        /// 
        /// The remarks can be 1 to 300 characters in length.
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **MySQL**: ApsaraDB RDS for MySQL
        /// *   **PolarDBMySQL**: PolarDB for MySQL
        /// *   **PostgreSQL**: ApsaraDB RDS for PostgreSQL
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The SQL template IDs. You can call the [GetQueryOptimizeExecErrorStats](https://help.aliyun.com/document_detail/405261.html) operation to obtain the SQL template ID. Separate multiple SQL template IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SqlIds")]
        [Validation(Required=false)]
        public string SqlIds { get; set; }

        /// <summary>
        /// The status of **Tags**. Valid values:
        /// 
        /// *   **0**: removes all tags added to the SQL templates that are specified by **SqlIds** and leaves **Tags** empty.
        /// *   **1**: adds the tags specified by **Tags** to the SQL templates that are specified by **SqlIds**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The SQL tags. Separate multiple SQL tags with commas (,). Valid values:
        /// 
        /// *   **DAS_IMPORTANT**: The SQL template is important.
        /// *   **DAS_NOT_IMPORTANT**: The SQL template is unimportant.
        /// *   **USER_IGNORE**: The scheduling of the SQL template does not need to be optimized.
        /// *   **DAS_IN_PLAN**: The scheduling of the SQL template needs to be optimized.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
