// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SemanticViewModel : TeaModel {
        /// <summary>
        /// <para>The annotation for the semantic view</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个定义销售额相关指标的视图</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The YAML definition of the semantic view</para>
        /// 
        /// <b>Example:</b>
        /// <para>name: revenue_analysis
        /// description: &quot;Semantic view for analyzing revenue across products and customers&quot;</para>
        /// <para>tables:</para>
        /// <list type="bullet">
        /// <item><description><para>name: customers
        /// description: &quot;Customer information&quot;
        /// base_table:
        ///   schema: sales_db
        ///   table: customers
        /// dimensions:</para>
        /// <list type="bullet">
        /// <item><description>name: customer_name
        /// synonyms: [&quot;client name&quot;, &quot;customer&quot;]
        /// description: &quot;Full name of the customer&quot;
        /// expr: c_name
        /// data_type: VARCHAR</description></item>
        /// <item><description>name: customer_segment
        /// synonyms: [&quot;segment&quot;, &quot;market segment&quot;]
        /// description: &quot;Customer market segment&quot;
        /// expr: c_mktsegment
        /// data_type: VARCHAR
        /// is_enum: true</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>name: orders
        /// description: &quot;Order information&quot;
        /// base_table:
        ///   schema: sales_db
        ///   table: orders
        /// dimensions:</para>
        /// <list type="bullet">
        /// <item><description>name: order_date
        /// description: &quot;Date when order was placed&quot;
        /// expr: o_orderdate
        /// data_type: DATE</description></item>
        /// <item><description>name: order_year
        /// description: &quot;Year when order was placed&quot;
        /// expr: YEAR(o_orderdate)
        /// data_type: NUMBER
        /// facts:</description></item>
        /// <item><description>name: order_total
        /// description: &quot;Total order amount&quot;
        /// expr: o_totalprice
        /// data_type: NUMBER
        /// metrics:</description></item>
        /// <item><description>name: total_orders
        /// description: &quot;Total number of orders&quot;
        /// expr: COUNT(*)</description></item>
        /// <item><description>name: total_revenue
        /// description: &quot;Total revenue of orders&quot;
        /// expr: SUM(o_totalprice)</description></item>
        /// <item><description>name: average_order_value
        /// description: &quot;Average order value&quot;
        /// expr: AVG(o_totalprice)</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>relationships:</para>
        /// <list type="bullet">
        /// <item><description>name: orders_to_customers
        /// left_table: orders
        /// right_table: customers
        /// relationship_columns:<list type="bullet">
        /// <item><description>left_column: o_custkey
        /// right_column: c_custkey</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>metrics:</para>
        /// <list type="bullet">
        /// <item><description>name: revenue_per_customer
        /// description: &quot;Average revenue per customer&quot;
        /// expr: orders.total_revenue / customers.customer_count</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The vector retrieval match score (defaults to 1; during retrieval queries, it is a decimal between 0 and 1 representing vector similarity)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.81</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

        /// <summary>
        /// <para>The name of the semantic view</para>
        /// 
        /// <b>Example:</b>
        /// <para>revenue_analysis</para>
        /// </summary>
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

        /// <summary>
        /// <para>The schema where the semantic view resides</para>
        /// 
        /// <b>Example:</b>
        /// <para>sales_db</para>
        /// </summary>
        [NameInMap("ViewSchema")]
        [Validation(Required=false)]
        public string ViewSchema { get; set; }

    }

}
