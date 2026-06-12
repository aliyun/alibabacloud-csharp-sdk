// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateSqlInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of compute units (CUs). CUs are the compute cores that can be used in parallel when Dedicated SQL is running.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Dedicated SQL by default for the project. If you set this parameter to \<c>true\\</c>, all query and analysis operations in the project, such as alerting and dashboards, use Dedicated SQL.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("useAsDefault")]
        [Validation(Required=false)]
        public bool? UseAsDefault { get; set; }

    }

}
