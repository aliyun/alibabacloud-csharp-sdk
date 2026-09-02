// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AgentDataSemanticsMetric : TeaModel {
        /// <summary>
        /// <para>The usage description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Use totalPrice to calculate total sales for sales performance comparison</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the SQL expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TotalSales</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The SQL expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUM(sales_transactions.totalPrice)</para>
        /// </summary>
        [NameInMap("SQLExpression")]
        [Validation(Required=false)]
        public string SQLExpression { get; set; }

        /// <summary>
        /// <para>The list of synonyms. A maximum of 10 items are supported. Each item can contain up to 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Sales&quot;,&quot;Revenue&quot;,&quot;GMV&quot;]</para>
        /// </summary>
        [NameInMap("Synonyms")]
        [Validation(Required=false)]
        public List<string> Synonyms { get; set; }

        /// <summary>
        /// <para>The type of the SQL expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>measure</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
