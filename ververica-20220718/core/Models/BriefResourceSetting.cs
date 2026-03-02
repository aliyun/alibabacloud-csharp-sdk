// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class BriefResourceSetting : TeaModel {
        /// <summary>
        /// <para>The resource configuration for the deployment in batch mode. This parameter is required for a deployment in batch mode.</para>
        /// </summary>
        [NameInMap("batchResourceSetting")]
        [Validation(Required=false)]
        public BatchResourceSetting BatchResourceSetting { get; set; }

        /// <summary>
        /// <para>The Realtime Compute for Apache Flink configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“execution.checkpointing.interval: 180s”</para>
        /// </summary>
        [NameInMap("flinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlinkConf { get; set; }

        /// <summary>
        /// <para>The resource configuration for the deployment in streaming mode. This parameter is required for a deployment in streaming mode.</para>
        /// </summary>
        [NameInMap("streamingResourceSetting")]
        [Validation(Required=false)]
        public StreamingResourceSetting StreamingResourceSetting { get; set; }

    }

}
