// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AgentDataSemanticsJoin : TeaModel {
        /// <summary>
        /// <para>The join condition.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public AgentDataSemanticsJoinCondition Condition { get; set; }

        /// <summary>
        /// <para>The join usage description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Use this join when analyzing customer attributes associated with sales transactions</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The full name of the left table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>samples.bakehouse.sales_transactions</para>
        /// </summary>
        [NameInMap("LeftTable")]
        [Validation(Required=false)]
        public string LeftTable { get; set; }

        /// <summary>
        /// <para>The table relationship type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>many_to_one</para>
        /// </summary>
        [NameInMap("RelationshipType")]
        [Validation(Required=false)]
        public string RelationshipType { get; set; }

        /// <summary>
        /// <para>The full name of the right table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>samples.bakehouse.customers</para>
        /// </summary>
        [NameInMap("RightTable")]
        [Validation(Required=false)]
        public string RightTable { get; set; }

    }

}
