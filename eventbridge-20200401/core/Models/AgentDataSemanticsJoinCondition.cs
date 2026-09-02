// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AgentDataSemanticsJoinCondition : TeaModel {
        /// <summary>
        /// <para>The left table field name in form mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customerID</para>
        /// </summary>
        [NameInMap("LeftColumn")]
        [Validation(Required=false)]
        public string LeftColumn { get; set; }

        /// <summary>
        /// <para>The conditional expression method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>form</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The right table field name in form mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customerID</para>
        /// </summary>
        [NameInMap("RightColumn")]
        [Validation(Required=false)]
        public string RightColumn { get; set; }

        /// <summary>
        /// <para>The join SQL expression in SQL mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sales_transactions.customerID = customers.customerID</para>
        /// </summary>
        [NameInMap("SQLExpression")]
        [Validation(Required=false)]
        public string SQLExpression { get; set; }

    }

}
