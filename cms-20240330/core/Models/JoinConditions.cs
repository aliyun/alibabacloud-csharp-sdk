// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class JoinConditions : TeaModel {
        /// <summary>
        /// <para>The left field in the format $<query_idx>.<field>, such as $0.hostIp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_id</para>
        /// </summary>
        [NameInMap("lhsField")]
        [Validation(Required=false)]
        public string LhsField { get; set; }

        /// <summary>
        /// <para>The comparison operator. Valid values: == / != / &lt; / &gt; / &lt;= / &gt;=.</para>
        /// 
        /// <b>Example:</b>
        /// <para>=</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The right field in the format $<query_idx>.<field>, such as $1.hostIp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace_id</para>
        /// </summary>
        [NameInMap("rhsField")]
        [Validation(Required=false)]
        public string RhsField { get; set; }

    }

}
