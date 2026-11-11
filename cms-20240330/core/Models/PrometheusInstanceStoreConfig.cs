// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PrometheusInstanceStoreConfig : TeaModel {
        /// <summary>
        /// <para>The concurrency per host. Valid values: 1 to 8. Default value: 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("parallelCountPerHost")]
        [Validation(Required=false)]
        public int? ParallelCountPerHost { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable parallel query. If not returned, the value is considered false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("parallelEnable")]
        [Validation(Required=false)]
        public bool? ParallelEnable { get; set; }

        /// <summary>
        /// <para>The parallel query mode. Valid values: auto, static. Default value: auto.</para>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("parallelMode")]
        [Validation(Required=false)]
        public string ParallelMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the query cache. If not returned, the value is considered false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("queryCacheEnable")]
        [Validation(Required=false)]
        public bool? QueryCacheEnable { get; set; }

        /// <summary>
        /// <para>The global concurrency. Valid values: 2 to 64. Default value: 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("totalParallelCount")]
        [Validation(Required=false)]
        public int? TotalParallelCount { get; set; }

    }

}
