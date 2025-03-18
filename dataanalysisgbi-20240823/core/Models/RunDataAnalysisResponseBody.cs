// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class RunDataAnalysisResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RunDataAnalysisResponseBodyData Data { get; set; }
        public class RunDataAnalysisResponseBodyData : TeaModel {
            [NameInMap("attempts")]
            [Validation(Required=false)]
            public List<object> Attempts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Access was denied, message: No such namespace namespaces/tech-scp-chain7.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rewrite</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("evidence")]
            [Validation(Required=false)]
            public string Evidence { get; set; }

            [NameInMap("httpStatusCode")]
            [Validation(Required=false)]
            public long? HttpStatusCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DA2578F7-88A5-5D6E-9305-33E724E97D60</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("rewrite")]
            [Validation(Required=false)]
            public string Rewrite { get; set; }

            [NameInMap("selector")]
            [Validation(Required=false)]
            public List<string> Selector { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sessionid1</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>select p.product_id, p.product_name, sum(o.quantity) as total_sales from products p join orders o on p.product_id = o.product_id where o.order_date between \&quot;2022-10-22\&quot; and \&quot;2024-10-22\&quot; group by p.product_id, p.product_name having total_sales &gt; 5</para>
            /// </summary>
            [NameInMap("sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            [NameInMap("sqlData")]
            [Validation(Required=false)]
            public RunDataAnalysisResponseBodyDataSqlData SqlData { get; set; }
            public class RunDataAnalysisResponseBodyDataSqlData : TeaModel {
                [NameInMap("column")]
                [Validation(Required=false)]
                public List<string> Column { get; set; }

                [NameInMap("data")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Data { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Can not issue data manipulation statements with executeQuery()</para>
            /// </summary>
            [NameInMap("sqlError")]
            [Validation(Required=false)]
            public string SqlError { get; set; }

            [NameInMap("visualization")]
            [Validation(Required=false)]
            public RunDataAnalysisResponseBodyDataVisualization Visualization { get; set; }
            public class RunDataAnalysisResponseBodyDataVisualization : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public RunDataAnalysisResponseBodyDataVisualizationData Data { get; set; }
                public class RunDataAnalysisResponseBodyDataVisualizationData : TeaModel {
                    [NameInMap("option")]
                    [Validation(Required=false)]
                    public string Option { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bar</para>
                    /// </summary>
                    [NameInMap("plotType")]
                    [Validation(Required=false)]
                    public string PlotType { get; set; }

                    [NameInMap("stack")]
                    [Validation(Required=false)]
                    public bool? Stack { get; set; }

                    [NameInMap("xAxis")]
                    [Validation(Required=false)]
                    public List<string> XAxis { get; set; }

                    [NameInMap("yAxis")]
                    [Validation(Required=false)]
                    public List<string> YAxis { get; set; }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
