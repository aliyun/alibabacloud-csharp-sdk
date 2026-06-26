// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListScalingConfigsOutput : TeaModel {
        /// <summary>
        /// <para>Paging token for the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Function scaling configuration information</para>
        /// </summary>
        [NameInMap("scalingConfigs")]
        [Validation(Required=false)]
        public List<ScalingConfigStatus> ScalingConfigs { get; set; }

    }

}
