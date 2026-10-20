// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ViewChange : TeaModel {
        /// <summary>
        /// <para>The type of the view change operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>updateComment</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The view comment. Required when you perform the updateComment operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>View update description</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The dialect used in the view query statement. Required when you perform the addDialect, updateDialect, or dropDialect operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flink</para>
        /// </summary>
        [NameInMap("dialect")]
        [Validation(Required=false)]
        public string Dialect { get; set; }

        /// <summary>
        /// <para>The key of the view property. Required when you perform the setOption or removeOption operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>view_option</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The view query statement. Required when you perform the addDialect or updateDialect operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT region, SUM(amount) AS total_amount FROM sales GROUP BY region</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The value of the view property. Required when you perform the setOption operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
