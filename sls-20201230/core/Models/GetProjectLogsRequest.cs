// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetProjectLogsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the Dedicated SQL feature. For more information, see [Enable Dedicated SQL](~~223777~~). Valid values:
        /// 
        /// *   true
        /// *   false (default): enables the Standard SQL feature.
        /// 
        /// You can use the powerSql or **query** parameter to configure Dedicated SQL.
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// The standard SQL statement. In this example, the SQL statement queries the number of page views (PVs) from 2022-03-01 10:41:40 to 2022-03-01 10:56:40 in a Logstore whose name is nginx-moni.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
