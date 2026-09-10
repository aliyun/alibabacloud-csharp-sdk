// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PrometheusNamedQueryEntry : TeaModel {
        /// <summary>
        /// <para>The PromQL query expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>avg(cpu_usage) &gt; 80</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The query name, such as $A or $B, referenced by the condition trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpuQuery</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
