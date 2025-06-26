// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeDBInstanceConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceConfigResponseBodyData Data { get; set; }
        public class DescribeDBInstanceConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            [NameInMap("Params")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceConfigResponseBodyDataParams> Params { get; set; }
            public class DescribeDBInstanceConfigResponseBodyDataParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Maximum number of concurrently executed queries. Zero means unlimited.</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDynamic")]
                [Validation(Required=false)]
                public int? IsDynamic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsUserModifiable")]
                [Validation(Required=false)]
                public int? IsUserModifiable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>max_concurrent_queries</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[0-100]</para>
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public string Optional { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParamRelyRule")]
                [Validation(Required=false)]
                public string ParamRelyRule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>66428721-xxxx-xxxx-xxxx-3BD1B67837E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
