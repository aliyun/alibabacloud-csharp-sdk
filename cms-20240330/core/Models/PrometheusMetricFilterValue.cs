// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PrometheusMetricFilterValue : TeaModel {
        /// <summary>
        /// <para>The filter dimension name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host</para>
        /// </summary>
        [NameInMap("dim")]
        [Validation(Required=false)]
        public string Dim { get; set; }

        /// <summary>
        /// <para>The filter operator, such as eq, neq, contain, not_contain, all, or disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>=</para>
        /// </summary>
        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

        /// <summary>
        /// <para>The filter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web-01</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
