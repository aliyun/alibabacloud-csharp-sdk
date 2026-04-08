// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class EnvironmentConfiguration : TeaModel {
        /// <summary>
        /// <para>环境变量条目列表，每个条目包含 name、value 和可选 description</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<EnvironmentVariable> Variables { get; set; }

    }

}
