// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class RunSqlGenerationResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public RunSqlGenerationResponseBodyData Data { get; set; }
        public class RunSqlGenerationResponseBodyData : TeaModel {
            [NameInMap("chat")]
            [Validation(Required=false)]
            public RunSqlGenerationResponseBodyDataChat Chat { get; set; }
            public class RunSqlGenerationResponseBodyDataChat : TeaModel {
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Access was denied, message: No such namespace namespaces/tech-scp-chain7.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sql</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("evidence")]
            [Validation(Required=false)]
            public string Evidence { get; set; }

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
            /// <para>f64c38dd-a235-4bb4-ae6c-79eaedcba699</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>Can not issue data manipulation statements with executeQuery()</para>
            /// </summary>
            [NameInMap("sqlError")]
            [Validation(Required=false)]
            public string SqlError { get; set; }

        }

    }

}
