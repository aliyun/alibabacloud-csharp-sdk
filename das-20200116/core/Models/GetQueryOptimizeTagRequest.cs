// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeTagRequest : TeaModel {
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
        /// The SQL template ID. You can call the [GetQueryOptimizeDataStats](https://help.aliyun.com/document_detail/405261.html) operation to query the SQL template ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

    }

}
