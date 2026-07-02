// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateInstanceInspectionRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2ze5ru5rjurix7f71sxv</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>异常项</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// <para>The metric source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sysom</para>
        /// </summary>
        [NameInMap("metricSource")]
        [Validation(Required=false)]
        public string MetricSource { get; set; }

        /// <summary>
        /// <para>The region to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
