// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class MetricDefRespDTO : TeaModel {
        /// <summary>
        /// <para>Metric key name</para>
        /// 
        /// <b>Example:</b>
        /// <para>total_calls</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Metric display name</para>
        /// 
        /// <b>Example:</b>
        /// <para>调用次数</para>
        /// </summary>
        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>Is sortable</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("sortable")]
        [Validation(Required=false)]
        public bool? Sortable { get; set; }

        /// <summary>
        /// <para>Metric unit</para>
        /// 
        /// <b>Example:</b>
        /// <para>次</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
