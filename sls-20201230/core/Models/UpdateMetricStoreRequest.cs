// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateMetricStoreRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public bool? AutoSplit { get; set; }

        /// <summary>
        /// <para>The maximum number of shards into which existing shards can be automatically split. This parameter is valid only when you set the autoSplit parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        /// <summary>
        /// <para>The type of the Metricstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The retention period of the metric data. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
