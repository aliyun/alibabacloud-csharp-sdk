// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateInstanceInspectionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i-2ze5ru5rjurix7f71sxv</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<string> Items { get; set; }

        [NameInMap("metricSource")]
        [Validation(Required=false)]
        public string MetricSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
