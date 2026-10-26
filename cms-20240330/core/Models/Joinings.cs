// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Joinings : TeaModel {
        /// <summary>
        /// <para>The list of join conditions for query result sets, which defines the matching rules between multiple query result sets to merge query results from different data sources based on specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;lhsField&quot;:&quot;$0.hostIp&quot;,&quot;operator&quot;:&quot;==&quot;,&quot;rhsField&quot;:&quot;$1.hostIp&quot;}]</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<JoinConditions> Conditions { get; set; }

        /// <summary>
        /// <para>The set operation type: InnerJoin / LeftJoin / RightJoin / FullJoin / LeftExclude / RightExclude / CrossJoin / NoJoin / Concat.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INNER</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
