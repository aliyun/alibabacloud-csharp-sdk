// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdateJobConfigParam : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;table.exec.parallelism：4&quot;}</para>
        /// </summary>
        [NameInMap("newFlinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> NewFlinkConf { get; set; }

    }

}
