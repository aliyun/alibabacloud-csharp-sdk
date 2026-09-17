// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SlsQueryJoin : TeaModel {
        /// <summary>
        /// <para>The list of join conditions for SLS query result sets. The conditions define the matching rules between multiple SLS query results for cross-Logstore data correlation analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;leftField&quot;:&quot;traceId&quot;,&quot;operator&quot;:&quot;eq&quot;,&quot;rightField&quot;:&quot;trace_id&quot;}]</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<SlsJoinCondition> Conditions { get; set; }

        /// <summary>
        /// <para>The set operation type. Valid values: InnerJoin, LeftJoin, RightJoin, FullJoin, LeftExclude, RightExclude, CrossJoin, NoJoin, and Concat.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LEFT</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
