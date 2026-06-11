// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmMeasureConfig : TeaModel {
        /// <summary>
        /// <para>An array of dimension keys used to group the results.</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>The unique code that identifies the metric.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("measureCode")]
        [Validation(Required=false)]
        public string MeasureCode { get; set; }

        /// <summary>
        /// <para>The aggregation period in seconds, which determines the time granularity of data points.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public int? WindowSecs { get; set; }

    }

}
