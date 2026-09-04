// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowWaste : TeaModel {
        /// <summary>
        /// <para>The cumulative duration of trained trajectories, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183</para>
        /// </summary>
        [NameInMap("UsefulSec")]
        [Validation(Required=false)]
        public long? UsefulSec { get; set; }

    }

}
