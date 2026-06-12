// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateSqlInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of Compute Units (CUs). A CU is a compute core that can be used for parallel processing when Dedicated SQL is running.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Dedicated SQL for the project by default. If this parameter is set to true, all query and analysis operations in the project, such as alerts and dashboards, use Dedicated SQL.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("useAsDefault")]
        [Validation(Required=false)]
        public bool? UseAsDefault { get; set; }

    }

}
