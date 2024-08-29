// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateSqlInstanceRequest : TeaModel {
        /// <summary>
        /// The number of compute units (CUs). When you use the Dedicated SQL feature, CUs are used in parallel.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// Specifies whether to enable the Dedicated SQL feature for the project. If you set this parameter to true, the Dedicated SQL feature is enabled for the specified project and takes effect for all query statements that you execute in the project, including the query statements for alerts and dashboards.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("useAsDefault")]
        [Validation(Required=false)]
        public bool? UseAsDefault { get; set; }

    }

}
