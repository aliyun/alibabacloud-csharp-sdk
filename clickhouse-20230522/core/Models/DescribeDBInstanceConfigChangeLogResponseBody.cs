// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeDBInstanceConfigChangeLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceConfigChangeLogResponseBodyData Data { get; set; }
        public class DescribeDBInstanceConfigChangeLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The parameter change records.</para>
            /// </summary>
            [NameInMap("ParamChangeLogs")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceConfigChangeLogResponseBodyDataParamChangeLogs> ParamChangeLogs { get; set; }
            public class DescribeDBInstanceConfigChangeLogResponseBodyDataParamChangeLogs : TeaModel {
                /// <summary>
                /// <para>Indicates whether the configuration takes effect:</para>
                /// <list type="bullet">
                /// <item><description>true: The execution plan takes effect.</description></item>
                /// <item><description>false: The execution plan does not take effect.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Applied")]
                [Validation(Required=false)]
                public bool? Applied { get; set; }

                /// <summary>
                /// <para>The time when the change was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-25 13:46:06</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the change was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-25 13:46:06</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The operation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ID")]
                [Validation(Required=false)]
                public long? ID { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>max_concurrent_queries</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The new parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// <para>The old parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>780DE414-*********-88BE-A2E21B862B57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
