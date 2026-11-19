// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetQpsStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The chart configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cn-shanghai&quot;:{&quot;X&quot;:[&quot;20260701&quot;],&quot;Y&quot;:[{&quot;Name&quot;:&quot;cn-shanghai&quot;,&quot;Data&quot;:[10]}]}}</para>
        /// </summary>
        [NameInMap("Charts")]
        [Validation(Required=false)]
        public Dictionary<string, ChartsValue> Charts { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
