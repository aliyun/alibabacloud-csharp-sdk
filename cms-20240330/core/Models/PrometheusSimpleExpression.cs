// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PrometheusSimpleExpression : TeaModel {
        /// <summary>
        /// <para>The comparison operator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GT: greater than</description></item>
        /// <item><description>GE: greater than or equal to</description></item>
        /// <item><description>LT: less than</description></item>
        /// <item><description>LE: less than or equal to</description></item>
        /// <item><description>EQ: equal to</description></item>
        /// <item><description>NE: not equal to</description></item>
        /// </list>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The referenced query name, corresponding to QueryConfigUnified.queries[].name.</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The comparison threshold.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
