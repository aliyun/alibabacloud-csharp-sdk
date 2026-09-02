// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AgentDataSemanticsExample : TeaModel {
        /// <summary>
        /// <para>The example usage description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Use this example when a user asks about high-value customers based on weekly statistics</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The example name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High-value customers with weekly sales exceeding 150</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The SQL example parameter list. A maximum of 20 items are supported.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<AgentDataSemanticsExampleParameter> Parameters { get; set; }

        /// <summary>
        /// <para>The standard SQL example.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT customerID FROM sales_transactions</para>
        /// </summary>
        [NameInMap("SQLExpression")]
        [Validation(Required=false)]
        public string SQLExpression { get; set; }

    }

}
