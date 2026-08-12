// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmCompositeCompareConfig : TeaModel {
        /// <summary>
        /// <para>The aggregate functions used for aggregation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>The comparison operator. GTE/LTE indicates greater than or equal to/less than or equal to. YOY_UP/YOY_DOWN indicates year-over-year increase/decrease, which requires yoyTimeUnit and yoyTimeValue to be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The threshold.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        /// <summary>
        /// <para>The year-over-year time unit. This parameter takes effect only when operator is set to YOY_UP or YOY_DOWN.</para>
        /// </summary>
        [NameInMap("yoyTimeUnit")]
        [Validation(Required=false)]
        public string YoyTimeUnit { get; set; }

        /// <summary>
        /// <para>The year-over-year time value. This parameter takes effect only when operator is set to YOY_UP or YOY_DOWN.</para>
        /// </summary>
        [NameInMap("yoyTimeValue")]
        [Validation(Required=false)]
        public int? YoyTimeValue { get; set; }

    }

}
